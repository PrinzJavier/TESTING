<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotPassword))
        Enter_Button = New Button()
        TextBox_RetCode = New TextBox()
        TextBox_NewPass = New TextBox()
        TextBox_ConfPass = New TextBox()
        SuspendLayout()
        ' 
        ' Enter_Button
        ' 
        Enter_Button.AutoSize = True
        Enter_Button.BackColor = Color.FromArgb(CByte(56), CByte(41), CByte(97))
        Enter_Button.FlatStyle = FlatStyle.Popup
        Enter_Button.Font = New Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Enter_Button.ForeColor = Color.White
        Enter_Button.Location = New Point(250, 293)
        Enter_Button.Name = "Enter_Button"
        Enter_Button.Size = New Size(114, 25)
        Enter_Button.TabIndex = 0
        Enter_Button.Text = "Reset Password"
        Enter_Button.UseVisualStyleBackColor = False
        ' 
        ' TextBox_RetCode
        ' 
        TextBox_RetCode.ForeColor = Color.Gray
        TextBox_RetCode.Location = New Point(194, 194)
        TextBox_RetCode.Name = "TextBox_RetCode"
        TextBox_RetCode.Size = New Size(224, 23)
        TextBox_RetCode.TabIndex = 1
        TextBox_RetCode.Text = "Enter Retrieval Code"
        TextBox_RetCode.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox_NewPass
        ' 
        TextBox_NewPass.ForeColor = Color.Gray
        TextBox_NewPass.Location = New Point(194, 223)
        TextBox_NewPass.Name = "TextBox_NewPass"
        TextBox_NewPass.Size = New Size(224, 23)
        TextBox_NewPass.TabIndex = 2
        TextBox_NewPass.Text = "Enter New Password"
        TextBox_NewPass.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox_ConfPass
        ' 
        TextBox_ConfPass.ForeColor = Color.Gray
        TextBox_ConfPass.Location = New Point(194, 251)
        TextBox_ConfPass.Name = "TextBox_ConfPass"
        TextBox_ConfPass.Size = New Size(224, 23)
        TextBox_ConfPass.TabIndex = 3
        TextBox_ConfPass.Text = "Confirm Password"
        TextBox_ConfPass.TextAlign = HorizontalAlignment.Center
        ' 
        ' ForgotPassword
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(629, 418)
        Controls.Add(TextBox_ConfPass)
        Controls.Add(TextBox_NewPass)
        Controls.Add(TextBox_RetCode)
        Controls.Add(Enter_Button)
        DoubleBuffered = True
        Name = "ForgotPassword"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Enter_Button As Button
    Friend WithEvents TextBox_RetCode As TextBox
    Friend WithEvents TextBox_NewPass As TextBox
    Friend WithEvents TextBox_ConfPass As TextBox
End Class
