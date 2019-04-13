Imports MySql.Data.MySqlClient

Public Class Registerform
    Dim MysqlConn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub insertBtn_Click(sender As Object, e As EventArgs) Handles insertBtn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=password;database=database"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query1 As String
            Query1 = " insert into database.registration_details (roll_number,username,password,email,address,phone_num) values ('" & TextBox_rollNo.Text & "','" & TextBox_name.Text & "','" & TextBox_Password.Text & "','" & TextBox_Email.Text & "','" & TextBox_Address.Text & "','" & TextBox_Phone.Text & "') "
            command = New MySqlCommand(Query1, MysqlConn)
            READER = command.ExecuteReader
            registerMessage.Show()
            Me.Hide()
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Registerform_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do You Really want to Exit the app?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        loginForm.Show()
        Me.Hide()

    End Sub
End Class