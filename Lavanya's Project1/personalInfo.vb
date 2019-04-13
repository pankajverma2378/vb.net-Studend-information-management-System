Imports MySql.Data.MySqlClient
Public Class personalInfo
    Dim MysqlConn As MySqlConnection
    Dim command As MySqlCommand
    Dim command1 As MySqlCommand
    Private Sub personalInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=password;database=database"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query1 As String
            Query1 = "select * from database.registration_details"
            command1 = New MySqlCommand(Query1, MysqlConn)

            READER = command1.ExecuteReader
            While READER.Read
                Dim fname = READER.GetString("username")
                sname.Items.Add(fname)
            End While
            READER.Close()
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=password;database=database"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select Roll_number,Username,Email,Address,Phone_num from database.registration_details where username = '" & sname.Text & "'"
            command = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = command
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            personalInfoGrid.DataSource = bSource
            SDA.Update(dbDataset)

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub personalInfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do You Really want to Exit the app?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub
End Class