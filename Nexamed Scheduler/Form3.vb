Imports MySql.Data.MySqlClient

Public Class Form3
    Dim conn As New MySqlConnection("Data Source=localhost;database=nexamed;username=root;password=1234")

    Private Sub AdminProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        LoadData()
    End Sub
    Private Sub LoadData()
        Try
            conn.Open()
            Dim query As String = "SELECT Adminid, Password FROM admin"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ' Handle the CellFormatting event to display asterisks for the Password column
            AddHandler DataGridView1.CellFormatting, AddressOf DataGridView1_CellFormatting

            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        If e.ColumnIndex = 1 AndAlso e.Value IsNot Nothing Then ' Check if the column is Password column
            ' Replace the password value with asterisks
            e.Value = New String("*"c, e.Value.ToString().Length)
        End If
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("Adminid").Value.ToString()
            TextBox2.Text = row.Cells("Password").Value.ToString()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Add button
        If ValidateInput() Then
            Try
                conn.Open()

                ' Check for duplicate key entry
                If Not IsDuplicateKey(TextBox1.Text.Trim()) Then
                    Dim query As String = "INSERT INTO admin (Adminid, Password) VALUES (@Adminid, @Password)"
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Adminid", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@Password", TextBox2.Text)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Adminid already present. Please enter a different id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try

            LoadData()
            ClearTextboxes()
        End If
    End Sub

    Private Function IsDuplicateKey(adminId As String) As Boolean
        ' Check if the given Adminid already exists in the database
        Dim query As String = "SELECT COUNT(*) FROM admin WHERE Adminid = @Adminid"
        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Adminid", adminId)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        End Using
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Update button
        If Not AdminExists(TextBox1.Text) Then
            MessageBox.Show("Admin ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate if both Adminid and Password are filled
        If ValidateInput() Then
            Try
                conn.Open()

                Dim query As String = "UPDATE admin SET Password = @Password WHERE Adminid = @Adminid"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Adminid", TextBox1.Text)
                cmd.Parameters.AddWithValue("@Password", TextBox2.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try

            LoadData()
            ClearTextboxes()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Delete button
        If Not AdminExists(TextBox1.Text) Then
            MessageBox.Show("Admin ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Not String.IsNullOrEmpty(TextBox1.Text.Trim()) Then
            If MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    conn.Open()

                    Dim query As String = "DELETE FROM admin WHERE Adminid = @Adminid"
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Adminid", TextBox1.Text)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                End Try

                LoadData()
                ClearTextboxes()
            End If
        Else
            MessageBox.Show("Please select a record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Function AdminExists(adminId As String) As Boolean
        Try
            conn.Open()
            Dim query As String = "SELECT COUNT(*) FROM admin WHERE Adminid = @Adminid"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Adminid", adminId)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Function

    Private Function ValidateInput() As Boolean
        If String.IsNullOrEmpty(TextBox1.Text.Trim()) OrElse String.IsNullOrEmpty(TextBox2.Text.Trim()) Then
            MessageBox.Show("Please enter both Adminid and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Add more specific validation if needed

        Return True
    End Function
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Reset button
        ClearTextboxes()
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Allow only numeric input for TextBox1
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearTextboxes()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        doctor.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        doctor.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        patient.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        patient.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
