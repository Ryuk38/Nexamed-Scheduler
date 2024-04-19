<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(history))
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        Button2 = New Button()
        Label3 = New Label()
        Label4 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        PictureBox1 = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Segoe Print", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(663, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(499, 81)
        Label1.TabIndex = 0
        Label1.Text = "Appointment Details"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Transparent
        Label2.Location = New Point(309, 239)
        Label2.Name = "Label2"
        Label2.Size = New Size(350, 54)
        Label2.TabIndex = 1
        Label2.Text = "Enter AppointmentId"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(697, 245)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(280, 41)
        TextBox1.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(1055, 240)
        Button1.Name = "Button1"
        Button1.Size = New Size(107, 46)
        Button1.TabIndex = 3
        Button1.Text = "Fetch"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
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
        DataGridView1.Location = New Point(185, 511)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(1388, 510)
        DataGridView1.TabIndex = 36
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(1245, 266)
        Button2.Name = "Button2"
        Button2.Size = New Size(99, 41)
        Button2.TabIndex = 37
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Transparent
        Label3.Location = New Point(309, 308)
        Label3.Name = "Label3"
        Label3.Size = New Size(251, 54)
        Label3.TabIndex = 38
        Label3.Text = "Enter DoctorId"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Transparent
        Label4.Location = New Point(309, 381)
        Label4.Name = "Label4"
        Label4.Size = New Size(261, 54)
        Label4.TabIndex = 39
        Label4.Text = "Enter PatientId"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(697, 315)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(280, 41)
        TextBox2.TabIndex = 40
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(697, 394)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(280, 41)
        TextBox3.TabIndex = 41
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(1055, 315)
        Button3.Name = "Button3"
        Button3.Size = New Size(107, 41)
        Button3.TabIndex = 42
        Button3.Text = "Fetch"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(1055, 394)
        Button4.Name = "Button4"
        Button4.Size = New Size(107, 41)
        Button4.TabIndex = 43
        Button4.Text = "Fetch"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.Location = New Point(1245, 350)
        Button5.Name = "Button5"
        Button5.Size = New Size(99, 41)
        Button5.TabIndex = 45
        Button5.Text = "Cancel"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1589, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(115, 90)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 46
        PictureBox1.TabStop = False
        ' 
        ' history
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(39), CByte(52), CByte(68))
        ClientSize = New Size(1732, 1033)
        Controls.Add(PictureBox1)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Button2)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "history"
        StartPosition = FormStartPosition.CenterScreen
        Text = "History"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
