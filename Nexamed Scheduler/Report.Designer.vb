<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report))
        Label3 = New Label()
        TextBox2 = New TextBox()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        Label2 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(371, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(131, 32)
        Label3.TabIndex = 3
        Label3.Text = "Doctor ID"
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.None
        TextBox2.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(569, 119)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(244, 38)
        TextBox2.TabIndex = 4
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.None
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = SystemColors.ControlLightLight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(194, 430)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(1338, 476)
        DataGridView1.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Comic Sans MS", 28.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(846, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(221, 68)
        Label1.TabIndex = 6
        Label1.Text = " Report "
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1587, 43)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(114, 108)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Anchor = AnchorStyles.None
        DateTimePicker1.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.Location = New Point(569, 229)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(291, 38)
        DateTimePicker1.TabIndex = 8
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Anchor = AnchorStyles.None
        DateTimePicker2.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker2.Location = New Point(938, 229)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(289, 38)
        DateTimePicker2.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(371, 235)
        Label2.Name = "Label2"
        Label2.Size = New Size(165, 32)
        Label2.TabIndex = 10
        Label2.Text = "Date Range"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(884, 235)
        Label4.Name = "Label4"
        Label4.Size = New Size(38, 32)
        Label4.TabIndex = 11
        Label4.Text = "to"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.None
        Button1.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(699, 322)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 61)
        Button1.TabIndex = 12
        Button1.Text = "Fetch"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.None
        Button2.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(862, 322)
        Button2.Name = "Button2"
        Button2.Size = New Size(113, 61)
        Button2.TabIndex = 13
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Report
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(39), CByte(52), CByte(68))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1732, 1033)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Report"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Report"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
