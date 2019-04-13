<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Textbox_un = New System.Windows.Forms.TextBox()
        Me.Textbox_p = New System.Windows.Forms.TextBox()
        Me.Loginbtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.registerBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(30, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Textbox_un
        '
        Me.Textbox_un.Location = New System.Drawing.Point(146, 59)
        Me.Textbox_un.Name = "Textbox_un"
        Me.Textbox_un.Size = New System.Drawing.Size(134, 20)
        Me.Textbox_un.TabIndex = 2
        '
        'Textbox_p
        '
        Me.Textbox_p.Location = New System.Drawing.Point(146, 122)
        Me.Textbox_p.Name = "Textbox_p"
        Me.Textbox_p.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Textbox_p.Size = New System.Drawing.Size(134, 20)
        Me.Textbox_p.TabIndex = 3
        '
        'Loginbtn
        '
        Me.Loginbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Loginbtn.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Loginbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loginbtn.Location = New System.Drawing.Point(34, 181)
        Me.Loginbtn.Name = "Loginbtn"
        Me.Loginbtn.Size = New System.Drawing.Size(246, 32)
        Me.Loginbtn.TabIndex = 4
        Me.Loginbtn.Text = "Login"
        Me.Loginbtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(36, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(244, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Not a  user ? Please Register"
        '
        'registerBtn
        '
        Me.registerBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.registerBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerBtn.Location = New System.Drawing.Point(34, 270)
        Me.registerBtn.Name = "registerBtn"
        Me.registerBtn.Size = New System.Drawing.Size(246, 32)
        Me.registerBtn.TabIndex = 7
        Me.registerBtn.Text = "Register"
        Me.registerBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(45, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(488, 29)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Student Information Management System"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Lavanya_s_Project1.My.Resources.Resources.stu
        Me.PictureBox1.Location = New System.Drawing.Point(352, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 243)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(571, 323)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.registerBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Loginbtn)
        Me.Controls.Add(Me.Textbox_p)
        Me.Controls.Add(Me.Textbox_un)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "loginForm"
        Me.Text = "loginForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Textbox_un As TextBox
    Friend WithEvents Textbox_p As TextBox
    Friend WithEvents Loginbtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents registerBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
End Class
