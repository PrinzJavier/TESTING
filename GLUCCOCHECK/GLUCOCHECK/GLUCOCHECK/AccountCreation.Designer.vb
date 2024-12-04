<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountCreation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountCreation))
        TextBox_Name = New TextBox()
        TextBox_Username = New TextBox()
        TextBox_Email = New TextBox()
        TextBox_Password = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        TextBox_Height = New TextBox()
        TextBox_Weight = New TextBox()
        Button1 = New Button()
        RadioButton_Type2 = New RadioButton()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        SuspendLayout()
        ' 
        ' TextBox_Name
        ' 
        TextBox_Name.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_Name.Location = New Point(76, 159)
        TextBox_Name.Name = "TextBox_Name"
        TextBox_Name.PlaceholderText = "Enter Full Name"
        TextBox_Name.Size = New Size(211, 23)
        TextBox_Name.TabIndex = 0
        TextBox_Name.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox_Username
        ' 
        TextBox_Username.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_Username.Location = New Point(76, 226)
        TextBox_Username.Name = "TextBox_Username"
        TextBox_Username.PlaceholderText = "Enter Username"
        TextBox_Username.Size = New Size(211, 23)
        TextBox_Username.TabIndex = 1
        TextBox_Username.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox_Email
        ' 
        TextBox_Email.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_Email.Location = New Point(75, 296)
        TextBox_Email.Name = "TextBox_Email"
        TextBox_Email.PlaceholderText = "Enter Email"
        TextBox_Email.Size = New Size(211, 23)
        TextBox_Email.TabIndex = 2
        TextBox_Email.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox_Password
        ' 
        TextBox_Password.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_Password.Location = New Point(76, 367)
        TextBox_Password.Name = "TextBox_Password"
        TextBox_Password.PlaceholderText = "Enter Password"
        TextBox_Password.Size = New Size(211, 23)
        TextBox_Password.TabIndex = 3
        TextBox_Password.TextAlign = HorizontalAlignment.Center
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(74, 437)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(213, 23)
        DateTimePicker1.TabIndex = 5
        ' 
        ' TextBox_Height
        ' 
        TextBox_Height.Font = New Font("Segoe UI", 9F)
        TextBox_Height.Location = New Point(416, 226)
        TextBox_Height.Name = "TextBox_Height"
        TextBox_Height.PlaceholderText = "Height in cm"
        TextBox_Height.Size = New Size(97, 23)
        TextBox_Height.TabIndex = 8
        TextBox_Height.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox_Weight
        ' 
        TextBox_Weight.Font = New Font("Segoe UI", 9F)
        TextBox_Weight.Location = New Point(528, 226)
        TextBox_Weight.Name = "TextBox_Weight"
        TextBox_Weight.PlaceholderText = "Weight in kg"
        TextBox_Weight.Size = New Size(100, 23)
        TextBox_Weight.TabIndex = 9
        TextBox_Weight.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.MidnightBlue
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(413, 356)
        Button1.Name = "Button1"
        Button1.Size = New Size(236, 70)
        Button1.TabIndex = 12
        Button1.Text = "CREATE ACCOUNT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' RadioButton_Type2
        ' 
        RadioButton_Type2.AutoSize = True
        RadioButton_Type2.BackColor = Color.Transparent
        RadioButton_Type2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RadioButton_Type2.ForeColor = Color.DarkBlue
        RadioButton_Type2.Location = New Point(528, 356)
        RadioButton_Type2.Name = "RadioButton_Type2"
        RadioButton_Type2.RightToLeft = RightToLeft.Yes
        RadioButton_Type2.Size = New Size(76, 25)
        RadioButton_Type2.TabIndex = 11
        RadioButton_Type2.TabStop = True
        RadioButton_Type2.Text = "Type 2"
        RadioButton_Type2.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Type 1", "Type 2"})
        ComboBox1.Location = New Point(416, 296)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(212, 23)
        ComboBox1.TabIndex = 14
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Male", "Female", "Prefer not to say"})
        ComboBox2.Location = New Point(416, 157)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(212, 23)
        ComboBox2.TabIndex = 15
        ' 
        ' AccountCreation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(738, 492)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Button1)
        Controls.Add(RadioButton_Type2)
        Controls.Add(TextBox_Weight)
        Controls.Add(TextBox_Height)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox_Password)
        Controls.Add(TextBox_Email)
        Controls.Add(TextBox_Username)
        Controls.Add(TextBox_Name)
        Name = "AccountCreation"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox_Name As TextBox
    Friend WithEvents TextBox_Username As TextBox
    Friend WithEvents TextBox_Email As TextBox
    Friend WithEvents TextBox_Password As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox_Height As TextBox
    Friend WithEvents TextBox_Weight As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton_Type2 As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
End Class
