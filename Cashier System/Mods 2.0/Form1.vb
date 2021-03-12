Public Class Form1


    Dim decTax As Decimal
    Dim decSubTotal As Decimal
    Dim decTotal As Decimal
    Dim decItmCost(20) As Decimal
    Const decTaxRate As Decimal = 0.85



    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()




        For Each txt In {txtAdPh, txtFLStd, txtKasLab, txtKeyBord, txtMonitor, txtMouse, txtMsO,
                         txtMsV, txtNint, txtNTBuk, txtPCBx, txtPS3, txtPS4, txtX360, txtXOne}

            txt.Enabled = False
        Next

        For Each chk In {chkFLStd, chkKasLab, chkKeybrd, chkMonitor, chkMouse, chkMSOff, chkNint, chkNotebook, chkPCBox,
                         chkPhotoshop, chkPS3, chkPS4, chkVS, chkXbx1, chkXbx360}

            chk.Enabled = False

        Next


    End Sub

    Private Sub Category()
        If chkHrdw.Checked = False And chkSoftw.Checked = False And chkCons.Checked = False Then
            MessageBox.Show("Please Choose a category/ries to proceed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf chkHrdw.Checked = True And chkSoftw.Checked = False And chkCons.Checked = False Then
            grpHrdware.Show()
            btnChkOut.Show()
            btnClr.Show()
            grpItems.Show()
            grpItems_Hardware.Show()

            grpItems_Software.Hide()
            grpItems_Consoles.Hide()
        ElseIf chkHrdw.Checked = False And chkSoftw.Checked = True And chkCons.Checked = False Then
            grpSoftware.Show()
            btnChkOut.Show()
            btnClr.Show()

            grpItems.Show()
            grpItems_Software.Show()

            grpItems_Hardware.Hide()
            grpItems_Consoles.Hide()



        ElseIf chkHrdw.Checked = False And chkSoftw.Checked = False And chkCons.Checked = True Then
            grpConsl.Show()
            btnChkOut.Show()
            btnClr.Show()
            grpItems.Show()
            grpItems_Hardware.Hide()
            grpItems_Software.Hide()
            grpItems_Consoles.Show()



        ElseIf chkHrdw.Checked = True And chkSoftw.Checked = True And chkCons.Checked = False Then
            grpHrdware.Show()
            grpSoftware.Show()
            btnChkOut.Show()
            btnClr.Show()
            grpItems.Show()
            grpItems_Consoles.Hide()
            grpItems_Hardware.Show()
            grpItems_Software.Show()



        ElseIf chkHrdw.Checked = True And chkSoftw.Checked = False And chkCons.Checked = True Then
            grpHrdware.Show()
            grpConsl.Show()
            btnChkOut.Show()
            btnClr.Show()

            grpItems.Show()
            grpItems_Software.Hide()
            grpItems_Hardware.Show()
            grpItems_Consoles.Show()


        ElseIf chkHrdw.Checked = False And chkSoftw.Checked = True And chkCons.Checked = True Then
            grpSoftware.Show()
            grpConsl.Show()
            btnChkOut.Show()
            btnClr.Show()

            grpItems.Show()
            grpItems_Hardware.Hide()
            grpItems_Consoles.Show()
            grpItems_Software.Show()


        ElseIf chkHrdw.Checked = True And chkSoftw.Checked = True And chkCons.Checked = True Then
            grpSoftware.Show()
            grpConsl.Show()
            grpHrdware.Show()
            btnChkOut.Show()
            btnClr.Show()
            grpItems.Show()
            grpItems_Consoles.Show()
            grpItems_Hardware.Show()
            grpItems_Software.Show()

        End If
    End Sub

    Private Sub bnAppl_Click(sender As System.Object, e As System.EventArgs) Handles bnAppl.Click
        Call Category()
    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        grpConsl.Hide()
        grpHrdware.Hide()
        grpSoftware.Hide()
        grpItems.Hide()


        btnChkOut.Hide()
        btnClr.Hide()

        chkHrdw.Checked = False
        chkSoftw.Checked = False
        chkCons.Checked = False


        ListBox1.Items.Clear()

        For Each chk In {chkFLStd, chkKasLab, chkKeybrd, chkMonitor, chkMouse, chkMSOff, chkNint, chkNotebook, chkPCBox,
                         chkPhotoshop, chkPS3, chkPS4, chkVS, chkXbx1, chkXbx360}

            chk.Checked = False
            chk.Enabled = False
        Next

    End Sub

    Private Sub btnChkOut_Click(sender As System.Object, e As System.EventArgs) Handles btnChkOut.Click


        ListBox1.Items.Clear()

        decItmCost(0) = (txtMonitor.Text * 1499.99)
        decItmCost(1) = (txtKeyBord.Text * 199.99)
        decItmCost(2) = (txtMouse.Text * 99.99)
        decItmCost(3) = (txtNTBuk.Text * 10999.99)
        decItmCost(4) = (txtPCBx.Text * 8999.99)

        decItmCost(5) = (749.99 * (txtKasLab.Text))
        decItmCost(6) = (1299.99 * (txtMsO.Text))
        decItmCost(7) = (649.99 * (txtAdPh.Text))
        decItmCost(8) = (319.99 * (txtMsV.Text))
        decItmCost(9) = (539.99 * (txtFLStd.Text))

        decItmCost(10) = (5699.99 * (txtX360.Text))
        decItmCost(11) = (3299.99 * (txtXOne.Text))
        decItmCost(12) = (2199.99 * (txtPS3.Text))
        decItmCost(13) = (5999.99 * (txtPS4.Text))
        decItmCost(14) = (5699.99 * (txtNint.Text))

        decItmCost(15) = decItmCost(0) + decItmCost(1) + decItmCost(2) + decItmCost(3) + decItmCost(4)
        decItmCost(16) = decItmCost(5) + decItmCost(6) + decItmCost(7) + decItmCost(8) + decItmCost(9)
        decItmCost(17) = decItmCost(10) + decItmCost(11) + decItmCost(12) + decItmCost(13) + decItmCost(14)

        decItmCost(18) = decItmCost(15) + decItmCost(16) + decItmCost(17)

        decTax = calcTax(decItmCost(18))

        decSubTotal = decItmCost(18)

        decTotal = decItmCost(18) + decTax

        ListBox1.Items.Add(vbNewLine)
        ListBox1.Items.Add(vbTab & "G6 TRADING STORE" & vbNewLine)
        ListBox1.Items.Add(vbTab & "Store 6 at Garankuwa Mall" & vbNewLine)
        ListBox1.Items.Add(vbTab & "- - - - - - - - - - - - - - - - -" & vbNewLine)

        ListBox1.Items.Add(vbNewLine)
        ListBox1.Items.Add(vbNewLine)
        ListBox1.Items.Add("Amount Due Incl. VAT" & vbTab & "R" & decTotal.ToString("N2"))
        ListBox1.Items.Add("Taxable Value" & vbTab & vbTab & "R" & decSubTotal.ToString("N2"))
        ListBox1.Items.Add("VAT Value" & vbTab & "@ 15%" & vbTab & "R" & decTax.ToString("N2"))
        ListBox1.Items.Add(vbTab & "- - - - - - - - - - - - - - - - -" & vbNewLine)
        ListBox1.Items.Add(vbNewLine)
        ListBox1.Items.Add("THANK YOU FOR SHOPPING WITH US" & vbNewLine)




    End Sub

    Private Function calcTax(ByVal decAmt As Decimal) As Double
        calcTax = decAmt - (decAmt * decTaxRate)
    End Function



    Private Sub btnClr_Click(sender As System.Object, e As System.EventArgs) Handles btnClr.Click
        ListBox1.Items.Clear()

        For Each txt In {txtAdPh, txtFLStd, txtKasLab, txtKeyBord, txtMonitor, txtMouse, txtMsO,
                         txtMsV, txtNint, txtNTBuk, txtPCBx, txtPS3, txtPS4, txtX360, txtXOne}

            txt.Text = "0"


        Next

        For Each chk In {chkFLStd, chkKasLab, chkKeybrd, chkMonitor, chkMouse, chkMSOff, chkNint, chkNotebook, chkPCBox,
                         chkPhotoshop, chkPS3, chkPS4, chkVS, chkXbx1, chkXbx360}

            chk.Checked = False
            chk.Enabled = False
        Next

        grpConsl.Hide()
        grpHrdware.Hide()
        grpSoftware.Hide()
        grpItems.Hide()


        btnChkOut.Hide()
        btnClr.Hide()

        chkHrdw.Checked = False
        chkSoftw.Checked = False
        chkCons.Checked = False



    End Sub


    Private Sub btnMontr_Click(sender As System.Object, e As System.EventArgs) Handles btnMontr.Click
        chkMonitor.Enabled = True
    End Sub



    Private Sub btnMice_Click(sender As System.Object, e As System.EventArgs) Handles btnMice.Click
        chkMouse.Enabled = True
    End Sub

    Private Sub btnNTbuk_Click(sender As System.Object, e As System.EventArgs) Handles btnNTbuk.Click
        chkNotebook.Enabled = True
    End Sub

    Private Sub btnCompBox_Click(sender As System.Object, e As System.EventArgs) Handles btnCompBox.Click
        chkPCBox.Enabled = True
    End Sub

    Private Sub btnKasLB_Click(sender As System.Object, e As System.EventArgs) Handles btnKasLB.Click
        chkKasLab.Enabled = True
    End Sub

    Private Sub btnMsOffiC_Click(sender As System.Object, e As System.EventArgs) Handles btnMsOffiC.Click
        chkMSOff.Enabled = True
    End Sub

    Private Sub btnAdPh_Click(sender As System.Object, e As System.EventArgs) Handles btnAdPh.Click
        chkPhotoshop.Enabled = True
    End Sub

    Private Sub btnMsVisio_Click(sender As System.Object, e As System.EventArgs) Handles btnMsVisio.Click
        chkVS.Enabled = True
    End Sub

    Private Sub btnFLStudio_Click(sender As System.Object, e As System.EventArgs) Handles btnFLStudio.Click
        chkFLStd.Enabled = True
    End Sub

    Private Sub btnX360_Click(sender As System.Object, e As System.EventArgs) Handles btnX360.Click
        chkXbx360.Enabled = True
    End Sub

    Private Sub btnOne1_Click(sender As System.Object, e As System.EventArgs) Handles btnOne1.Click
        chkXbx1.Enabled = True
    End Sub

    Private Sub btnPlayS3_Click(sender As System.Object, e As System.EventArgs) Handles btnPlayS3.Click
        chkPS3.Enabled = True
    End Sub

    Private Sub btnPlayS4_Click(sender As System.Object, e As System.EventArgs) Handles btnPlayS4.Click
        chkPS4.Enabled = True
    End Sub

    Private Sub btnNinte_Click(sender As System.Object, e As System.EventArgs) Handles btnNinte.Click
        chkNint.Enabled = True
    End Sub


    Private Sub btnKeyBrd_Click(sender As System.Object, e As System.EventArgs) Handles btnKeyBrd.Click
        chkKeybrd.Enabled = True

    End Sub

    Private Sub chkMonitor_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMonitor.CheckedChanged
        If chkMonitor.Checked = True Then

            txtMonitor.Enabled = True
            txtMonitor.Text = " "
            txtMonitor.Focus()
        End If

        If chkMonitor.Checked = False Then
            txtMonitor.Enabled = False
            txtMonitor.Text = "0"
        End If
    End Sub

    Private Sub chkKeybrd_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkKeybrd.CheckedChanged
        If chkKeybrd.Checked = True Then

            txtKeyBord.Enabled = True
            txtKeyBord.Text = " "
            txtKeyBord.Focus()
        End If

        If chkKeybrd.Checked = False Then
            txtKeyBord.Enabled = False
            txtKeyBord.Text = "0"
        End If
    End Sub

    Private Sub chkMouse_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMouse.CheckedChanged
        If chkMouse.Checked = True Then

            txtMouse.Enabled = True
            txtMouse.Text = " "
            txtMouse.Focus()
        End If

        If chkMouse.Checked = False Then
            txtMouse.Enabled = False
            txtMouse.Text = "0"
        End If
    End Sub

    Private Sub chkNotebook_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkNotebook.CheckedChanged
        If chkNotebook.Checked = True Then

            txtNTBuk.Enabled = True
            txtNTBuk.Text = " "
            txtNTBuk.Focus()
        End If

        If chkNotebook.Checked = False Then
            txtNTBuk.Enabled = False
            txtNTBuk.Text = "0"
        End If
    End Sub

    Private Sub chkPCBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPCBox.CheckedChanged
        If chkPCBox.Checked = True Then

            txtPCBx.Enabled = True
            txtPCBx.Text = " "
            txtPCBx.Focus()
        End If

        If chkPCBox.Checked = False Then
            txtPCBx.Enabled = False
            txtPCBx.Text = "0"
        End If
    End Sub

    Private Sub chkKasLab_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkKasLab.CheckedChanged
        If chkKasLab.Checked = True Then

            txtKasLab.Enabled = True
            txtKasLab.Text = " "
            txtKasLab.Focus()
        End If

        If chkKasLab.Checked = False Then
            txtKasLab.Enabled = False
            txtKasLab.Text = "0"
        End If
    End Sub

    Private Sub chkMSOff_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMSOff.CheckedChanged
        If chkMSOff.Checked = True Then

            txtMsO.Enabled = True
            txtMsO.Text = " "
            txtMsO.Focus()
        End If

        If chkMSOff.Checked = False Then
            txtMsO.Enabled = False
            txtMsO.Text = "0"
        End If
    End Sub

    Private Sub chkPhotoshop_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPhotoshop.CheckedChanged
        If chkPhotoshop.Checked = True Then

            txtAdPh.Enabled = True
            txtAdPh.Text = " "
            txtAdPh.Focus()
        End If

        If chkPhotoshop.Checked = False Then
            txtAdPh.Enabled = False
            txtAdPh.Text = "0"
        End If
    End Sub

    Private Sub chkVS_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkVS.CheckedChanged
        If chkVS.Checked = True Then

            txtMsV.Enabled = True
            txtMsV.Text = " "
            txtMsV.Focus()
        End If

        If chkVS.Checked = False Then
            txtMsV.Enabled = False
            txtMsV.Text = "0"
        End If
    End Sub

    Private Sub chkFLStd_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkFLStd.CheckedChanged
        If chkFLStd.Checked = True Then

            txtFLStd.Enabled = True
            txtFLStd.Text = " "
            txtFLStd.Focus()
        End If

        If chkFLStd.Checked = False Then
            txtFLStd.Enabled = False
            txtFLStd.Text = "0"
        End If
    End Sub

    Private Sub chkXbx360_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkXbx360.CheckedChanged
        If chkXbx360.Checked = True Then

            txtX360.Enabled = True
            txtX360.Text = " "
            txtX360.Focus()
        End If

        If chkXbx360.Checked = False Then
            txtX360.Enabled = False
            txtX360.Text = "0"
        End If
    End Sub

    Private Sub chkXbx1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkXbx1.CheckedChanged
        If chkXbx1.Checked = True Then

            txtXOne.Enabled = True
            txtXOne.Text = " "
            txtMonitor.Focus()
        End If

        If chkXbx1.Checked = False Then
            txtXOne.Enabled = False
            txtXOne.Text = "0"
        End If
    End Sub

    Private Sub chkPS3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPS3.CheckedChanged
        If chkPS3.Checked = True Then

            txtPS3.Enabled = True
            txtPS3.Text = " "
            txtPS3.Focus()
        End If

        If chkPS3.Checked = False Then
            txtPS3.Enabled = False
            txtPS3.Text = "0"
        End If
    End Sub

    Private Sub chkPS4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPS4.CheckedChanged
        If chkPS4.Checked = True Then

            txtPS4.Enabled = True
            txtPS4.Text = " "
            txtPS4.Focus()
        End If

        If chkPS4.Checked = False Then
            txtPS4.Enabled = False
            txtPS4.Text = "0"
        End If
    End Sub

    Private Sub chkNint_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkNint.CheckedChanged
        If chkNint.Checked = True Then

            txtNint.Enabled = True
            txtNint.Text = " "
            txtNint.Focus()
        End If

        If chkNint.Checked = False Then
            txtNint.Enabled = False
            txtNint.Text = "0"
        End If
    End Sub

    Private Sub EntrVal(sender As System.Object, e As System.EventArgs) Handles grpSoftware.MouseHover, grpItems_Software.MouseHover, grpItems_Hardware.MouseHover, grpItems_Consoles.MouseHover, grpItems.MouseHover, grpHrdware.MouseHover, grpConsl.MouseHover, GroupBox1.MouseHover, Me.MouseHover
        For Each txt In {txtAdPh, txtFLStd, txtKasLab, txtKeyBord, txtMonitor, txtMouse, txtMsO,
                        txtMsV, txtNint, txtNTBuk, txtPCBx, txtPS3, txtPS4, txtX360, txtXOne}

            If txt.Text = " " Then
                txt.Text = "0"

            End If
        Next
    End Sub

    Private Sub txtMonitor_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtMonitor.TextChanged
        If chkMonitor.Checked = True And txtMonitor.Text = "0" Then
            chkMonitor.Checked = False
            txtMonitor.Enabled = False
            chkMonitor.Enabled = False
        End If
    End Sub

    Private Sub txtKeyBord_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtKeyBord.TextChanged
        If chkKeybrd.Checked = True And txtKeyBord.Text = "0" Then
            chkKeybrd.Checked = False
            txtKeyBord.Enabled = False
            chkKeybrd.Enabled = False
        End If
    End Sub

    Private Sub txtMouse_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtMouse.TextChanged
        If chkMouse.Checked = True And txtMouse.Text = "0" Then
            chkMouse.Checked = False
            txtMouse.Enabled = False
            chkMouse.Enabled = False
        End If
    End Sub

    Private Sub txtNTBuk_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNTBuk.TextChanged
        If chkNotebook.Checked = True And txtNTBuk.Text = "0" Then
            chkNotebook.Checked = False
            txtNTBuk.Enabled = False
            chkNotebook.Enabled = False
        End If
    End Sub

    Private Sub txtPCBx_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPCBx.TextChanged
        If chkPCBox.Checked = True And txtPCBx.Text = "0" Then
            chkPCBox.Checked = False
            txtPCBx.Enabled = False
            chkPCBox.Enabled = False
        End If
    End Sub

    Private Sub txtKasLab_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtKasLab.TextChanged
        If chkKasLab.Checked = True And txtKasLab.Text = "0" Then
            chkKasLab.Checked = False
            txtKasLab.Enabled = False
            chkKasLab.Enabled = False
        End If
    End Sub

    Private Sub txtMsO_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtMsO.TextChanged
        If chkMSOff.Checked = True And txtMsO.Text = "0" Then
            chkMSOff.Checked = False
            txtMsO.Enabled = False
            chkMSOff.Enabled = False
        End If
    End Sub

    Private Sub txtAdPh_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAdPh.TextChanged
        If chkPhotoshop.Checked = True And txtAdPh.Text = "0" Then
            chkPhotoshop.Checked = False
            txtAdPh.Enabled = False
            chkPhotoshop.Enabled = False
        End If
    End Sub

    Private Sub txtMsV_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtMsV.TextChanged
        If chkVS.Checked = True And txtMsV.Text = "0" Then
            chkVS.Checked = False
            txtMsV.Enabled = False
            chkVS.Enabled = False
        End If
    End Sub

    Private Sub txtFLStd_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFLStd.TextChanged
        If chkFLStd.Checked = True And txtFLStd.Text = "0" Then
            chkFLStd.Checked = False
            txtFLStd.Enabled = False
            chkFLStd.Enabled = False
        End If
    End Sub

    Private Sub txtX360_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtX360.TextChanged
        If chkXbx360.Checked = True And txtX360.Text = "0" Then
            chkXbx360.Checked = False
            txtX360.Enabled = False
            chkXbx360.Enabled = False
        End If
    End Sub

    Private Sub txtXOne_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtXOne.TextChanged
        If chkXbx1.Checked = True And txtXOne.Text = "0" Then
            chkXbx1.Checked = False
            txtXOne.Enabled = False
            chkXbx1.Enabled = False
        End If
    End Sub

    Private Sub txtPS3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPS3.TextChanged
        If chkPS3.Checked = True And txtPS3.Text = "0" Then
            chkPS3.Checked = False
            txtPS3.Enabled = False
            chkPS3.Enabled = False
        End If
    End Sub

    Private Sub txtPS4_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPS4.TextChanged
        If chkPS4.Checked = True And txtPS4.Text = "0" Then
            chkPS4.Checked = False
            txtPS4.Enabled = False
            chkPS4.Enabled = False
        End If
    End Sub

    Private Sub txtNint_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNint.TextChanged
        If chkNint.Checked = True And txtNint.Text = "0" Then
            chkNint.Checked = False
            txtNint.Enabled = False
            chkNint.Enabled = False
        End If
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Are you sure you want to exit?", "Cashier System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()

        End If
    End Sub

   

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click

        InfoMonitor.Show()



    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        InfoKeyBoard.Show()

    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        InfoMouse.Show()

    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        InfoNotebook.Show()

    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        InfoPCBox.Show()

    End Sub

   
    Private Sub btnKasInfo_Click(sender As System.Object, e As System.EventArgs) Handles btnKasInfo.Click
        InfoKasLab.Show()

    End Sub

    Private Sub btnVS_Click(sender As System.Object, e As System.EventArgs) Handles btnVS.Click
        InfoMSVisualStudio.Show()

    End Sub

    Private Sub btnFLS_Click(sender As System.Object, e As System.EventArgs) Handles btnFLS.Click
        InfoFlStd.Show()

    End Sub

    Private Sub btnPhotoShop_Click(sender As System.Object, e As System.EventArgs) Handles btnPhotoShop.Click
        InfoPhotoshop.Show()

    End Sub

    Private Sub btnMSOf_Click(sender As System.Object, e As System.EventArgs) Handles btnMSOf.Click
        InfoMSOff.Show()

    End Sub

    Private Sub btnXB360_Click(sender As System.Object, e As System.EventArgs) Handles btnXB360.Click
        InfoXBox360.Show()

    End Sub

    Private Sub btnXB1_Click(sender As System.Object, e As System.EventArgs) Handles btnXB1.Click
        InfoXboxOne.Show()

    End Sub

    Private Sub btnPS3_Click(sender As System.Object, e As System.EventArgs) Handles btnPS3.Click
        InfoPS3.Show()

    End Sub

    Private Sub btnPS4_Click(sender As System.Object, e As System.EventArgs) Handles btnPS4.Click
        InfoPS4.Show()

    End Sub

    Private Sub btnNint_Click(sender As System.Object, e As System.EventArgs) Handles btnNint.Click
        InfoNintendo.Show()

    End Sub

    Private Sub BtnBack_Click(sender As System.Object, e As System.EventArgs) Handles BtnBack.Click
        Me.Close()
        Application.Restart()

    End Sub
End Class
