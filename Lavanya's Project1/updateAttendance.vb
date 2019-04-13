Imports MySql.Data.MySqlClient

Public Class updateAttendance
    Dim MysqlConn As MySqlConnection
    Dim command As MySqlCommand
    Dim command2 As MySqlCommand
    Private Sub updateAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            READER = command.ExecuteReader
            While READER.Read
                Dim fname = READER.GetString("username")
                sname.Items.Add(fname)
            End While
            READER.Close()

            READER2 = command2.ExecuteReader
            While READER2.Read
                Dim subject = READER2.GetString("subject")
                subjectBox.Items.Add(subject)
            End While

            MysqlConn.Close()
            READER2.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub subjectBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles subjectBox.SelectedIndexChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=password;database=database"
        Dim READER2 As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query2 As String
            Query2 = "select * from database.attendence where subject='" & subjectBox.Text & "' "
            command2 = New MySqlCommand(Query2, MysqlConn)
            READER2 = command2.ExecuteReader
            While READER2.Read
                TextBox_CA.Text = READER2.GetInt32("Attendance")
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
            Query = "update database.attendence set Attendance='" & TextBox_UA.Text & "' where subject='" & subjectBox.Text & "' "
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        adminDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub updateAttendance_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do You Really want to Exit the app?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub
End Class