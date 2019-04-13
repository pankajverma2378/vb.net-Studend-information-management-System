Imports MySql.Data.MySqlClient
Public Class loginForm
    Dim MysqlConn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub Loginbtn_Click(sender As Object, e As EventArgs) Handles Loginbtn.Click
        Dim obj As New Dashboard
        obj.stringPass = Textbox_un.Text
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=password;database=database"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from database.registration_details where Username='" & Textbox_un.Text & "' and Password='" & Textbox_p.Text & "' "
            command = New MySqlCommand(Query, MysqlConn)
            READER = command.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
            End While

            If count = 1 Then
                obj.Show()
                Me.Hide()

            ElseIf count > 1 Then
                MessageBox.Show("Dulicate")
            ElseIf Textbox_un.Text = "admin" And Textbox_p.Text = "admin" Then
                adminDashboard.Show()
                Me.Hide()
            Else
                noRecordFound.Show()
            End If

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub registerBtn_Click(sender As Object, e As EventArgs) Handles registerBtn.Click
        Registerform.Show()
        Me.Hide()


    End Sub

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub loginForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do You Really want to Exit the app?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub
End Class