Imports System.DirectoryServices

Public Class Form1
    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPassword.Click


        If txtUsername.Text = "Roman38" And txtPassword.Text = "qwerty" Then
            GroupBox1.Visible = False

        Else
            MessageBox.Show("Вы ввели неправильные данные для входа", "Неверные Данные", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)

            txtPassword.Clear()
            txtUsername.Clear()
            txtUsername.Focus()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtPassword.Clear()
        txtUsername.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Dim result = MessageBox.Show("Вы уверены, что хотите выйти?", "Закрытие Программы", MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question)

        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class

