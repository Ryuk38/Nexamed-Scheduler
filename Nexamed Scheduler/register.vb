Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient
Public Class Register

    Private connectionString As String = "Data Source=localhost;database=nexamed;username=root;password=1234"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Validate input fields
        If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse Not IsNumeric(TextBox1.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MessageBox.Show("Both fields must be filled. Please enter valid data.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Register the user
        Dim userId As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        ' Register the user directly within the event handler
        Dim query As String = "INSERT INTO ADMIN (AdminId, Password) VALUES (@UserId, @Password)"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@UserId", userId)
                command.Parameters.AddWithValue("@Password", password)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Clear TextBoxes after successful registration
                    TextBox1.Clear()
                    TextBox2.Clear()
                Catch ex As MySqlException
                    ' Handle duplicate entry exception
                    If ex.Number = 1062 Then
                        MessageBox.Show("The AdminID is already in use. Please choose a different AdminID.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        MessageBox.Show("Registration failed. Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Reset TextBoxes
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Check if the entered key is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True ' Ignore the key input if it is not a digit or backspace
            MessageBox.Show("User ID must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint, Panel1.Paint

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If
    End Sub
End Class
