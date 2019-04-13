<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registerform
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
        Me.roll_number = New System.Windows.Forms.Label()
        Me.name = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.Label()
        Me.address = New System.Windows.Forms.Label()
        Me.phone_Num = New System.Windows.Forms.Label()
        Me.TextBox_rollNo = New System.Windows.Forms.TextBox()
        Me.TextBox_name = New System.Windows.Forms.TextBox()
        Me.TextBox_Password = New System.Windows.Forms.TextBox()
        Me.TextBox_Email = New System.Windows.Forms.TextBox()
        Me.TextBox_Address = New System.Windows.Forms.TextBox()
        Me.TextBox_Phone = New System.Windows.Forms.TextBox()
        Me.insertBtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(94, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please Register "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(43, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fill Details :"
        '
        'roll_number
        '
        Me.roll_number.AutoSize = True
        Me.roll_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roll_number.ForeColor = System.Drawing.Color.White
        Me.roll_number.Location = New System.Drawing.Point(43, 127)
        Me.roll_number.Name = "roll_number"
        Me.roll_number.Size = New System.Drawing.Size(107, 20)
        Me.roll_number.TabIndex = 2
        Me.roll_number.Text = "Roll Number"
        '
        'name
        '
        Me.name.AutoSize = True
        Me.name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name.ForeColor = System.Drawing.Color.White
        Me.name.Location = New System.Drawing.Point(43, 168)
        Me.name.Name = "name"
        Me.name.Size = New System.Drawing.Size(55, 20)
        Me.name.TabIndex = 3
        Me.name.Text = "Name"
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.ForeColor = System.Drawing.Color.White
        Me.password.Location = New System.Drawing.Point(43, 214)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(86, 20)
        Me.password.TabIndex = 4
        Me.password.Text = "Password"
        '
        'email
        '
        Me.email.AutoSize = True
        Me.email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.ForeColor = System.Drawing.Color.White
        Me.email.Location = New System.Drawing.Point(43, 254)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(53, 20)
        Me.email.TabIndex = 5
        Me.email.Text = "Email"
        '
        'address
        '
        Me.address.AutoSize = True
        Me.address.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.ForeColor = System.Drawing.Color.White
        Me.address.Location = New System.Drawing.Point(43, 292)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(75, 20)
        Me.address.TabIndex = 6
        Me.address.Text = "Address"
        '
        'phone_Num
        '
        Me.phone_Num.AutoSize = True
        Me.phone_Num.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phone_Num.ForeColor = System.Drawing.Color.White
        Me.phone_Num.Location = New System.Drawing.Point(43, 334)
        Me.phone_Num.Name = "phone_Num"
        Me.phone_Num.Size = New System.Drawing.Size(127, 20)
        Me.phone_Num.TabIndex = 7
        Me.phone_Num.Text = "Phone Number"
        '
        'TextBox_rollNo
        '
        Me.TextBox_rollNo.Location = New System.Drawing.Point(248, 127)
        Me.TextBox_rollNo.Name = "TextBox_rollNo"
        Me.TextBox_rollNo.Size = New System.Drawing.Size(154, 20)
        Me.TextBox_rollNo.TabIndex = 8
        '
        'TextBox_name
        '
        Me.TextBox_name.Location = New System.Drawing.Point(248, 168)
        Me.TextBox_name.Name = "TextBox_name"
        Me.TextBox_name.Size = New System.Drawing.Size(154, 20)
        Me.TextBox_name.TabIndex = 9
        '
        'TextBox_Password
        '
        Me.TextBox_Password.Location = New System.Drawing.Point(248, 207)
        Me.TextBox_Password.Name = "TextBox_Password"
        Me.TextBox_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_Password.Size = New System.Drawing.Size(154, 20)
        Me.TextBox_Password.TabIndex = 10
        '
        'TextBox_Email
        '
        Me.TextBox_Email.Location = New System.Drawing.Point(248, 247)
        Me.TextBox_Email.Name = "TextBox_Email"
        Me.TextBox_Email.Size = New System.Drawing.Size(154, 20)
        Me.TextBox_Email.TabIndex = 11
        '
        'TextBox_Address
        '
        Me.TextBox_Address.Location = New System.Drawing.Point(248, 292)
        Me.TextBox_Address.Name = "TextBox_Address"
        Me.TextBox_Address.Size = New System.Drawing.Size(154, 20)
        Me.TextBox_Address.TabIndex = 12
        '
        'TextBox_Phone
        '
        Me.TextBox_Phone.Location = New System.Drawing.Point(248, 334)
        Me.TextBox_Phone.Name = "TextBox_Phone"
        Me.TextBox_Phone.Size = New System.Drawing.Size(154, 20)
        Me.TextBox_Phone.TabIndex = 13
        '
        'insertBtn
        '
        Me.insertBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insertBtn.Location = New System.Drawing.Point(48, 391)
        Me.insertBtn.Name = "insertBtn"
        Me.insertBtn.Size = New System.Drawing.Size(354, 33)
        Me.insertBtn.TabIndex = 14
        Me.insertBtn.Text = "Register"
        Me.insertBtn.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Lavanya_s_Project1.My.Resources.Resources.Screenshot__56_
        Me.PictureBox2.Location = New System.Drawing.Point(383, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(47, 47)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Lavanya_s_Project1.My.Resources.Resources.Back_Button
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Registerform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(442, 450)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.insertBtn)
        Me.Controls.Add(Me.TextBox_Phone)
        Me.Controls.Add(Me.TextBox_Address)
        Me.Controls.Add(Me.TextBox_Email)
        Me.Controls.Add(Me.TextBox_Password)
        Me.Controls.Add(Me.TextBox_name)
        Me.Controls.Add(Me.TextBox_rollNo)
        Me.Controls.Add(Me.phone_Num)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.name)
        Me.Controls.Add(Me.roll_number)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Dim name2 As String
        name2 = "Registerform"
        Me.Text = "Registerform"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents roll_number As Label
    Friend WithEvents name As Label
    Friend WithEvents password As Label
    Friend WithEvents email As Label
    Friend WithEvents address As Label
    Friend WithEvents phone_Num As Label
    Friend WithEvents TextBox_rollNo As TextBox
    Friend WithEvents TextBox_name As TextBox
    Friend WithEvents TextBox_Password As TextBox
    Friend WithEvents TextBox_Email As TextBox
    Friend WithEvents TextBox_Address As TextBox
    Friend WithEvents TextBox_Phone As TextBox
    Friend WithEvents insertBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
