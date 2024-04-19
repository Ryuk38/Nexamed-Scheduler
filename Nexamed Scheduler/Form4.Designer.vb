<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Label1 = New Label()
        Panel1 = New Panel()
        ComboBox4 = New ComboBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        DateTimePicker1 = New DateTimePicker()
        Label2 = New Label()
        Label14 = New Label()
        ComboBox3 = New ComboBox()
        Label15 = New Label()
        ComboBox2 = New ComboBox()
        TextBox1 = New TextBox()
        Label10 = New Label()
        Label13 = New Label()
        ComboBox1 = New ComboBox()
        Label12 = New Label()
        Label11 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        PictureBox1 = New PictureBox()
        DataGridView1 = New DataGridView()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Segoe Print", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(628, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(585, 81)
        Label1.TabIndex = 0
        Label1.Text = "Appointment Scheduling"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(ComboBox4)
        Panel1.Controls.Add(RadioButton2)
        Panel1.Controls.Add(RadioButton1)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(ComboBox3)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(ComboBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label11)
        Panel1.Location = New Point(54, 223)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(754, 614)
        Panel1.TabIndex = 1
        ' 
        ' ComboBox4
        ' 
        ComboBox4.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(382, 113)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(232, 39)
        ComboBox4.TabIndex = 10
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton2.ForeColor = SystemColors.ButtonFace
        RadioButton2.Location = New Point(510, 487)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(71, 36)
        RadioButton2.TabIndex = 19
        RadioButton2.TabStop = True
        RadioButton2.Text = "No"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        RadioButton1.ForeColor = SystemColors.ButtonFace
        RadioButton1.Location = New Point(391, 487)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(84, 36)
        RadioButton1.TabIndex = 18
        RadioButton1.TabStop = True
        RadioButton1.Text = "Yes"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.Location = New Point(382, 320)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(296, 38)
        DateTimePicker1.TabIndex = 17
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Century", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Transparent
        Label2.Location = New Point(23, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(226, 35)
        Label2.TabIndex = 15
        Label2.Text = "AppointmentId"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Century", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.ForeColor = Color.Transparent
        Label14.Location = New Point(23, 487)
        Label14.Name = "Label14"
        Label14.Size = New Size(305, 35)
        Label14.TabIndex = 3
        Label14.Text = "Ambulance Required"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(382, 400)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(225, 39)
        ComboBox3.TabIndex = 11
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.Font = New Font("Century", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.ForeColor = Color.Transparent
        Label15.Location = New Point(23, 113)
        Label15.Name = "Label15"
        Label15.Size = New Size(147, 35)
        Label15.TabIndex = 14
        Label15.Text = "PatientId"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(382, 248)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(232, 39)
        ComboBox2.TabIndex = 10
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(382, 51)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(232, 38)
        TextBox1.TabIndex = 5
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.ForeColor = Color.Transparent
        Label10.Location = New Point(23, 185)
        Label10.Name = "Label10"
        Label10.Size = New Size(273, 35)
        Label10.TabIndex = 3
        Label10.Text = "Select Doctor Type"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.ForeColor = Color.Transparent
        Label13.Location = New Point(23, 402)
        Label13.Name = "Label13"
        Label13.Size = New Size(193, 35)
        Label13.TabIndex = 6
        Label13.Text = "Choose Time"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(382, 183)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(232, 39)
        ComboBox1.TabIndex = 4
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.ForeColor = Color.Transparent
        Label12.Location = New Point(23, 326)
        Label12.Name = "Label12"
        Label12.Size = New Size(189, 35)
        Label12.TabIndex = 5
        Label12.Text = "Choose Date"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.ForeColor = Color.Transparent
        Label11.Location = New Point(23, 248)
        Label11.Name = "Label11"
        Label11.Size = New Size(288, 35)
        Label11.TabIndex = 3
        Label11.Text = "Select Doctor Name"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Constantia", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(438, 914)
        Button1.Name = "Button1"
        Button1.Size = New Size(153, 68)
        Button1.TabIndex = 3
        Button1.Text = "Book"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Constantia", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(734, 914)
        Button2.Name = "Button2"
        Button2.Size = New Size(152, 68)
        Button2.TabIndex = 4
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Constantia", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(1015, 914)
        Button3.Name = "Button3"
        Button3.Size = New Size(142, 68)
        Button3.TabIndex = 6
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1584, 26)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(108, 84)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = SystemColors.ButtonFace
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(848, 223)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(872, 614)
        DataGridView1.TabIndex = 9
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(39), CByte(52), CByte(68))
        ClientSize = New Size(1732, 1033)
        Controls.Add(DataGridView1)
        Controls.Add(PictureBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Appointment Scheduling"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox4 As ComboBox
End Class
