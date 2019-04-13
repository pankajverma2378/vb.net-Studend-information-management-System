Imports MySql.Data.MySqlClient
Public Class Marks
    Dim MysqlConn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub Marks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=password;database=database"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from database.marks"
            command = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = command
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            marksGrid.DataSource = bSource
            SDA.Update(dbDataset)

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Marks_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do You Really want to Exit the app?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub
End Class