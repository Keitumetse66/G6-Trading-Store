Public Class frmLogin

    Private Sub lblLogin_Click(sender As System.Object, e As System.EventArgs) Handles lblLogin.Click
        


        If String.IsNullOrEmpty(txtUserName.Text) Then
            MessageBox.Show("Username cannot be left blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUserName.Focus()
        ElseIf String.IsNullOrEmpty(txtPassword.Text) Then
            MessageBox.Show("Password cannot be left blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
        Else
            If Len(txtPassword.Text) < 8 Then
                MessageBox.Show("Password Too Short!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Focus()

            Else
                If txtPassword.Text = txtConPassword.Text = False Then

                    MessageBox.Show("Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


                Else
                    MessageBox.Show("Welcome! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.SendToBack()

                    Form1.Show()
                End If

            End If
        End If
    End Sub



   
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Are you sure you want to exit", "CAshier System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()

        End If
    End Sub

   
    Private Sub btnClr_Click(sender As System.Object, e As System.EventArgs) Handles btnClr.Click
        txtUserName.Text = " "
        txtPassword.Text = " "
        txtConPassword.Text = " "
        txtUserName.Focus()

    End Sub
End Class