<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        TextBox1 = New TextBox()
        Button4 = New Button()
        Chart1 = New DataVisualization.Charting.Chart()
        DateTimePicker1 = New DateTimePicker()
        TextBox2 = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(31, 171)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(47, 41)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(84, 197)
        Label1.Name = "Label1"
        Label1.Size = New Size(169, 15)
        Label1.TabIndex = 1
        Label1.Text = "Welcome to Dashboard, Name"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button1.FlatStyle = FlatStyle.Popup
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(31, 230)
        Button1.Name = "Button1"
        Button1.RightToLeft = RightToLeft.Yes
        Button1.Size = New Size(182, 37)
        Button1.TabIndex = 2
        Button1.Text = "Profile"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button2.FlatStyle = FlatStyle.Popup
        Button2.ForeColor = SystemColors.Control
        Button2.Location = New Point(31, 273)
        Button2.Name = "Button2"
        Button2.RightToLeft = RightToLeft.Yes
        Button2.Size = New Size(182, 37)
        Button2.TabIndex = 3
        Button2.Text = "Records"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button3.FlatStyle = FlatStyle.Popup
        Button3.ForeColor = SystemColors.Control
        Button3.Location = New Point(31, 316)
        Button3.Name = "Button3"
        Button3.RightToLeft = RightToLeft.Yes
        Button3.Size = New Size(182, 37)
        Button3.TabIndex = 4
        Button3.Text = "Signout"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(403, 242)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Enter a Number"
        TextBox1.Size = New Size(198, 23)
        TextBox1.TabIndex = 5
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button4.FlatStyle = FlatStyle.Popup
        Button4.ForeColor = SystemColors.Control
        Button4.Location = New Point(456, 326)
        Button4.Name = "Button4"
        Button4.RightToLeft = RightToLeft.Yes
        Button4.Size = New Size(84, 27)
        Button4.TabIndex = 6
        Button4.Text = "Enter"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Chart1
        ' 
        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)
        Chart1.Location = New Point(12, 14)
        Chart1.Name = "Chart1"
        Chart1.Palette = DataVisualization.Charting.ChartColorPalette.Bright
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Blood Sugar Level Summary"
        Chart1.Series.Add(Series1)
        Chart1.Size = New Size(616, 151)
        Chart1.TabIndex = 7
        Chart1.Text = "Chart1"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(403, 269)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(198, 23)
        DateTimePicker1.TabIndex = 8
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(403, 296)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(198, 23)
        TextBox2.TabIndex = 9
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(640, 369)
        Controls.Add(TextBox2)
        Controls.Add(DateTimePicker1)
        Controls.Add(Chart1)
        Controls.Add(Button4)
        Controls.Add(TextBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Dashboard"
        Text = "Form5"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox2 As TextBox
End Class
