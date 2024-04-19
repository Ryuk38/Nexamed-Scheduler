<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class doctor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(doctor))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        Button4 = New Button()
        Panel2 = New Panel()
        Label2 = New Label()
        PictureBox3 = New PictureBox()
        Panel3 = New Panel()
        PictureBox2 = New PictureBox()
        DataGridView1 = New DataGridView()
        Label6 = New Label()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel4 = New Panel()
        Label3 = New Label()
        PictureBox4 = New PictureBox()
        Label5 = New Label()
        Label7 = New Label()
        TextBox2 = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(426, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(201, 179)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Transparent
        Label4.Location = New Point(656, 59)
        Label4.Name = "Label4"
        Label4.Size = New Size(198, 64)
        Label4.TabIndex = 6
        Label4.Text = "Doctor"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(1439, 550)
        Button4.Name = "Button4"
        Button4.Size = New Size(134, 56)
        Button4.TabIndex = 22
        Button4.Text = "Reset"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Location = New Point(3, 243)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(338, 199)
        Panel2.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.WhiteSmoke
        Label2.Location = New Point(208, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 40)
        Label2.TabIndex = 4
        Label2.Text = "Admin"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(-3, 0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(205, 196)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(39), CByte(52), CByte(68))
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Controls.Add(Label4)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(343, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1389, 189)
        Panel3.TabIndex = 13
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(1239, 46)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(106, 87)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
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
        DataGridView1.Location = New Point(462, 715)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(1187, 398)
        DataGridView1.TabIndex = 23
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Transparent
        Label6.Location = New Point(960, 659)
        Label6.Name = "Label6"
        Label6.Size = New Size(203, 40)
        Label6.TabIndex = 18
        Label6.Text = "Doctor List"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(1122, 550)
        Button3.Name = "Button3"
        Button3.Size = New Size(134, 56)
        Button3.TabIndex = 21
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(830, 550)
        Button2.Name = "Button2"
        Button2.Size = New Size(134, 56)
        Button2.TabIndex = 20
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(544, 550)
        Button1.Name = "Button1"
        Button1.Size = New Size(134, 56)
        Button1.TabIndex = 19
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(718, 238)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(223, 38)
        TextBox1.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(551, 238)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 32)
        Label1.TabIndex = 14
        Label1.Text = "Doctor Id"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(39), CByte(52), CByte(68))
        Panel1.BackgroundImageLayout = ImageLayout.Center
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(343, 1055)
        Panel1.TabIndex = 12
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(PictureBox4)
        Panel4.Location = New Point(3, 650)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(340, 218)
        Panel4.TabIndex = 8
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
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(556, 306)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 32)
        Label5.TabIndex = 24
        Label5.Text = "Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.Control
        Label7.Location = New Point(551, 370)
        Label7.Name = "Label7"
        Label7.Size = New Size(109, 32)
        Label7.TabIndex = 25
        Label7.Text = "Gender"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(718, 306)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(223, 38)
        TextBox2.TabIndex = 26
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.Control
        Label8.Location = New Point(556, 424)
        Label8.Name = "Label8"
        Label8.Size = New Size(118, 32)
        Label8.TabIndex = 28
        Label8.Text = "Address"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = SystemColors.Control
        Label9.Location = New Point(1120, 244)
        Label9.Name = "Label9"
        Label9.Size = New Size(133, 32)
        Label9.TabIndex = 30
        Label9.Text = "Expertice"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.ForeColor = SystemColors.Control
        Label10.Location = New Point(1120, 317)
        Label10.Name = "Label10"
        Label10.Size = New Size(157, 32)
        Label10.TabIndex = 31
        Label10.Text = "Experience"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.ForeColor = SystemColors.Control
        Label11.Location = New Point(1120, 386)
        Label11.Name = "Label11"
        Label11.Size = New Size(163, 32)
        Label11.TabIndex = 32
        Label11.Text = "Contact No."
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton1.ForeColor = Color.Transparent
        RadioButton1.Location = New Point(718, 367)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(97, 36)
        RadioButton1.TabIndex = 36
        RadioButton1.TabStop = True
        RadioButton1.Text = "Male"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton2.ForeColor = Color.Transparent
        RadioButton2.Location = New Point(828, 367)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(130, 36)
        RadioButton2.TabIndex = 37
        RadioButton2.TabStop = True
        RadioButton2.Text = "Female"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(718, 426)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(223, 38)
        TextBox3.TabIndex = 38
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox4.Location = New Point(1301, 241)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(203, 38)
        TextBox4.TabIndex = 39
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox5.Location = New Point(1301, 311)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(203, 38)
        TextBox5.TabIndex = 40
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox6.Location = New Point(1301, 380)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(203, 38)
        TextBox6.TabIndex = 41
        ' 
        ' doctor
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(39), CByte(52), CByte(68))
        ClientSize = New Size(1732, 1055)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(TextBox2)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Button4)
        Controls.Add(Panel3)
        Controls.Add(DataGridView1)
        Controls.Add(Label6)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "doctor"
        StartPosition = FormStartPosition.CenterScreen
        Text = "doctor"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox4 As PictureBox
End Class
