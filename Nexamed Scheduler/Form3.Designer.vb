<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        DataGridView1 = New DataGridView()
        Label6 = New Label()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        TextBox2 = New TextBox()
        Label5 = New Label()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label2 = New Label()
        PictureBox3 = New PictureBox()
        Panel4 = New Panel()
        Label3 = New Label()
        PictureBox4 = New PictureBox()
        Button4 = New Button()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        PictureBox2 = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeight = 30
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridView1.Location = New Point(477, 674)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(1188, 421)
        DataGridView1.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BorderStyle = BorderStyle.Fixed3D
        Label6.Font = New Font("Century", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Transparent
        Label6.Location = New Point(903, 598)
        Label6.Name = "Label6"
        Label6.Size = New Size(225, 46)
        Label6.TabIndex = 7
        Label6.Text = "Admin List"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(1015, 460)
        Button3.Name = "Button3"
        Button3.Size = New Size(139, 57)
        Button3.TabIndex = 9
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(765, 460)
        Button2.Name = "Button2"
        Button2.Size = New Size(139, 57)
        Button2.TabIndex = 8
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(529, 460)
        Button1.Name = "Button1"
        Button1.Size = New Size(139, 57)
        Button1.TabIndex = 7
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(1069, 346)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(176, 43)
        TextBox2.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Century", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(1069, 272)
        Label5.Name = "Label5"
        Label5.Size = New Size(177, 40)
        Label5.TabIndex = 5
        Label5.Text = "Password"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(665, 346)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(176, 43)
        TextBox1.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(685, 272)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 40)
        Label1.TabIndex = 3
        Label1.Text = "UserId"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(39), CByte(52), CByte(68))
        Panel1.BackgroundImageLayout = ImageLayout.Center
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Panel4)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(345, 1033)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Location = New Point(3, 243)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(334, 196)
        Panel2.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.WhiteSmoke
        Label2.Location = New Point(200, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 40)
        Label2.TabIndex = 4
        Label2.Text = "Doctor"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(-3, 0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(197, 193)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(PictureBox4)
        Panel4.Location = New Point(3, 650)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(340, 218)
        Panel4.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(214, 85)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 35)
        Label3.TabIndex = 5
        Label3.Text = "Patient"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(-5, 2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(217, 216)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 3
        PictureBox4.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(1294, 460)
        Button4.Name = "Button4"
        Button4.Size = New Size(139, 57)
        Button4.TabIndex = 10
        Button4.Text = "Reset"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Transparent
        Label4.Location = New Point(650, 67)
        Label4.Name = "Label4"
        Label4.Size = New Size(200, 64)
        Label4.TabIndex = 6
        Label4.Text = "Admin"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(383, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(210, 172)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(39), CByte(52), CByte(68))
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Controls.Add(Label4)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(345, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1387, 212)
        Panel3.TabIndex = 2
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(1239, 46)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(106, 87)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(39), CByte(52), CByte(68))
        ClientSize = New Size(1732, 1033)
        Controls.Add(DataGridView1)
        Controls.Add(Label6)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(Label5)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Proifle Management"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
End Class
