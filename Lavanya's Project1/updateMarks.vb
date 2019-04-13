Imports MySql.Data.MySqlClient
Public Class updateMarks
    Dim MysqlConn As MySqlConnection
    Dim command As MySqlCommand
    Dim command2 As MySqlCommand

    Private Sub updateMarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=password;database=database"
        Dim READER As MySqlDataReader
        Dim READER2 As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from database.registration_details"
            Dim Query2 As String
            Query2 = "select * from database.attendence"

            command = New MySqlCommand(Query, MysqlConn)
            command2 = New MySqlCommand(Query2, MysqlConn)

            READER = Command.ExecuteReader
            While READER.Read
                Dim fname = READER.GetString("username")
                snamebox.Items.Add(fname)
            End While
            READER.Close()

            READER2 = command2.ExecuteReader
            While READER2.Read
                Dim subject = READER2.GetString("subject")
                subjectBox2.Items.Add(subject)
            End While
            READER2.Close()

            MysqlConn.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub subjectBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles subjectBox2.SelectedIndexChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=password;database=database"
        Dim READER2 As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query2 As String
            Query2 = "select * from database.marks where subject='" & subjectBox2.Text & "' "
            command2 = New MySqlCommand(Query2, MysqlConn)
            READER2 = command2.ExecuteReader
            While READER2.Read
                TextBox_CM.Text = READER2.GetInt32("sem_5")

            End While

            MysqlConn.Close()
            READER2.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=password;database=database"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "update database.marks set sem_5='" & TextBox_UM.Text & "' where subject='" & subjectBox2.Text & "' "
            command = New MySqlCommand(Query, MysqlConn)
            READER = command.ExecuteReader

            MessageBox.Show("Updated Successfully")
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub TextBox_UM_TextChanged(sender As Object, e As EventArgs) Handles TextBox_UM.TextChanged

    End Sub

    Private Sub TextBox_CM_TextChanged(sender As Object, e As EventArgs) Handles TextBox_CM.TextChanged

    End Sub

    Private Sub snamebox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles snamebox.SelectedIndexChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        adminDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub updateMarks_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do You Really want to Exit the app?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub
End Class