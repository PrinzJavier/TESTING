<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LandingPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LandingPage))
        LinkLabel1 = New LinkLabel()
        LinkLabel2 = New LinkLabel()
        Button1 = New Button()
        Username_TextBox = New TextBox()
        Password_TextBox = New TextBox()
        SuspendLayout()
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.DisabledLinkColor = Color.Transparent
        LinkLabel1.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.Location = New Point(550, 85)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(88, 13)
        LinkLabel1.TabIndex = 0
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Sign up for free"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.BackColor = Color.Transparent
        LinkLabel2.Location = New Point(522, 223)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(100, 15)
        LinkLabel2.TabIndex = 1
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Forgot password?"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(76))
        Button1.FlatStyle = FlatStyle.Popup
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(431, 248)
        Button1.Name = "Button1"
        Button1.Size = New Size(163, 44)
        Button1.TabIndex = 2
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Username_TextBox
        ' 
        Username_TextBox.BorderStyle = BorderStyle.None
        Username_TextBox.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Username_TextBox.Location = New Point(384, 122)
        Username_TextBox.Name = "Username_TextBox"
        Username_TextBox.PlaceholderText = "Username"
        Username_TextBox.Size = New Size(255, 36)
        Username_TextBox.TabIndex = 3
        Username_TextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Password_TextBox
        ' 
        Password_TextBox.BorderStyle = BorderStyle.None
        Password_TextBox.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Password_TextBox.Location = New Point(384, 171)
        Password_TextBox.Name = "Password_TextBox"
        Password_TextBox.PasswordChar = "*"c
        Password_TextBox.PlaceholderText = "Password"
        Password_TextBox.Size = New Size(255, 36)
        Password_TextBox.TabIndex = 4
        Password_TextBox.TextAlign = HorizontalAlignment.Center
        Password_TextBox.UseSystemPasswordChar = True
        ' 
        ' LandingPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(688, 375)
        Controls.Add(Password_TextBox)
        Controls.Add(Username_TextBox)
        Controls.Add(Button1)
        Controls.Add(LinkLabel2)
        Controls.Add(LinkLabel1)
        Name = "LandingPage"
        Text = "GlucoCheck 0.0"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents Username_TextBox As TextBox
    Friend WithEvents Password_TextBox As TextBox
End Class
