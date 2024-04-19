<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        CheckBox2 = New CheckBox()
        Label5 = New Label()
        PictureBox5 = New PictureBox()
        Button2 = New Button()
        Button1 = New Button()
        Panel3 = New Panel()
        TextBox2 = New TextBox()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        Panel2 = New Panel()
        TextBox1 = New TextBox()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox4 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(39), CByte(52), CByte(68))
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.Controls.Add(CheckBox2)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(1261, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(471, 1055)
        Panel1.TabIndex = 0
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.ForeColor = Color.Transparent
        CheckBox2.Location = New Point(92, 676)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(132, 24)
        CheckBox2.TabIndex = 2
        CheckBox2.Text = "Show Password"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label5.ForeColor = Color.Transparent
        Label5.Location = New Point(77, 861)
        Label5.Name = "Label5"
        Label5.Size = New Size(303, 28)
        Label5.TabIndex = 2
        Label5.Text = "New user click here to register"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), Image)
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Location = New Point(37, 29)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(402, 267)
        PictureBox5.TabIndex = 7
        PictureBox5.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(82), CByte(8), CByte(255))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.Transparent
        Button2.Location = New Point(244, 739)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 41)
        Button2.TabIndex = 6
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(82), CByte(8), CByte(255))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(114, 739)
        Button1.Name = "Button1"
        Button1.Size = New Size(101, 41)
        Button1.TabIndex = 1
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(30), CByte(40), CByte(52))
        Panel3.Controls.Add(TextBox2)
        Panel3.Controls.Add(PictureBox2)
        Panel3.Location = New Point(87, 616)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(266, 28)
        Panel3.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(30), CByte(40), CByte(52))
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TextBox2.Location = New Point(27, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(215, 20)
        TextBox2.TabIndex = 6
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(5, 6)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(17, 17)
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Silver
        Label4.Location = New Point(87, 582)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 25)
        Label4.TabIndex = 4
        Label4.Text = "Password"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(30), CByte(40), CByte(52))
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(87, 515)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(266, 28)
        Panel2.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(30), CByte(40), CByte(52))
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TextBox1.Location = New Point(28, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(214, 20)
        TextBox1.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(5, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(17, 17)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Silver
        Label3.Location = New Point(87, 476)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 25)
        Label3.TabIndex = 2
        Label3.Text = "UserId"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Silver
        Label2.Location = New Point(77, 402)
        Label2.Name = "Label2"
        Label2.Size = New Size(342, 25)
        Label2.TabIndex = 1
        Label2.Text = "Sign in your account to continue"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Location = New Point(77, 347)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 36)
        Label1.TabIndex = 0
        Label1.Text = "Login"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.BorderStyle = BorderStyle.Fixed3D
        PictureBox4.Dock = DockStyle.Left
        PictureBox4.Location = New Point(0, 0)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(1309, 1055)
        PictureBox4.TabIndex = 1
        PictureBox4.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(31), CByte(45), CByte(61))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1732, 1055)
        Controls.Add(Panel1)
        Controls.Add(PictureBox4)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
End Class
