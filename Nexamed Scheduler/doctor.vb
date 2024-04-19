Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class doctor
    Dim conn As New MySqlConnection("Data Source=localhost;database=nexamed;username=root;password=1234")

    Private Sub doctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        LoadDataIntoDataGridView()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Validate input fields before saving
        If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse
       Not IsNumeric(TextBox1.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox2.Text) OrElse
       ContainsNumeric(TextBox2.Text) OrElse
       (Not RadioButton1.Checked AndAlso Not RadioButton2.Checked) OrElse
       String.IsNullOrWhiteSpace(TextBox3.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox4.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox5.Text) OrElse
       Not IsNumeric(TextBox5.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox6.Text) OrElse
       Not IsNumeric(TextBox6.Text) OrElse
       TextBox6.Text.Length <> 10 Then
            MessageBox.Show("Please fill all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim doctorId As Integer
            Dim name As String = TextBox2.Text
            Dim gender As String = If(RadioButton1.Checked, "Male", "Female")
            Dim address As String = TextBox3.Text
            Dim expertise As String = TextBox4.Text
            Dim experience As Integer
            Dim contactNo As String = TextBox6.Text

            ' Validate if the entered values are valid
            If Integer.TryParse(TextBox1.Text, doctorId) AndAlso
           Integer.TryParse(TextBox5.Text, experience) Then

                ' Check if name, address, and expertise are not empty
                If Not String.IsNullOrEmpty(name) AndAlso
               Not String.IsNullOrEmpty(address) AndAlso
               Not String.IsNullOrEmpty(expertise) Then

                    ' Check for duplicate key before executing the query
                    If Not IsDuplicateKey(doctorId) Then
                        Dim insertQuery As String = "INSERT INTO doctor (doctorid, name, gender, address, expertise, experience, contactno) VALUES (@DoctorId, @Name, @Gender, @Address, @Expertise, @Experience, @ContactNo)"

                        Using cmd As New MySqlCommand(insertQuery, conn)
                            cmd.Parameters.AddWithValue("@DoctorId", doctorId)
                            cmd.Parameters.AddWithValue("@Name", name)
                            cmd.Parameters.AddWithValue("@Gender", gender)
                            cmd.Parameters.AddWithValue("@Address", address)
                            cmd.Parameters.AddWithValue("@Expertise", expertise)
                            cmd.Parameters.AddWithValue("@Experience", experience)
                            cmd.Parameters.AddWithValue("@ContactNo", contactNo)

                            cmd.ExecuteNonQuery()
                            MessageBox.Show("Record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Form4.PopulateDoctorExpertiseComboBox()
                            ' Load data into DataGridView
                            LoadDataIntoDataGridView()
                            ClearTextBoxes()
                        End Using
                    Else
                        MessageBox.Show("DoctorId already present. Please enter a different DoctorId.", "Duplicate Key Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Name, Address, and Expertise cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Invalid input for DoctorId, Experience, or ContactNo.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Function IsDuplicateKey(doctorId As Integer) As Boolean
        ' Check if the DoctorId already exists in the database
        Dim query As String = "SELECT COUNT(*) FROM doctor WHERE doctorid = @DoctorId"
        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@DoctorId", doctorId)
            Dim count As Integer = CInt(cmd.ExecuteScalar())
            Return count > 0
        End Using
    End Function

    Private Function DoctorExists(doctorId As Integer) As Boolean
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim query As String = "SELECT COUNT(*) FROM doctor WHERE doctorid = @DoctorId"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@DoctorId", doctorId)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ' Check if TextBox1.Text is a valid integer
            Dim doctorId As Integer
            If Not Integer.TryParse(TextBox1.Text, doctorId) Then
                MessageBox.Show("Please enter a valid Doctor ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If DoctorExists(doctorId) Then
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                Dim selectedRowIndex As Integer = DataGridView1.CurrentCell.RowIndex

                If selectedRowIndex >= 0 Then
                    ' Check if any field is modified
                    If TextBox2.Modified OrElse TextBox3.Modified OrElse TextBox4.Modified OrElse TextBox5.Modified OrElse TextBox6.Modified OrElse RadioButton1.Checked OrElse RadioButton2.Checked Then
                        Dim name As String = TextBox2.Text
                        Dim gender As String = If(RadioButton1.Checked, "Male", "Female")
                        Dim address As String = TextBox3.Text
                        Dim expertise As String = TextBox4.Text
                        Dim experience As Integer
                        Dim contactNo As String = TextBox6.Text

                        ' Check if all required fields are filled
                        If Not String.IsNullOrEmpty(name) AndAlso
                       Not String.IsNullOrEmpty(address) AndAlso
                       Not String.IsNullOrEmpty(expertise) AndAlso
                       Not String.IsNullOrEmpty(contactNo) Then

                            ' Validate if the entered values are valid
                            If Integer.TryParse(TextBox5.Text, experience) Then
                                Dim updateQuery As String = "UPDATE doctor SET name = @Name, gender = @Gender, address = @Address, expertise = @Expertise, experience = @Experience, contactno = @ContactNo WHERE doctorid = @DoctorId"

                                Using cmd As New MySqlCommand(updateQuery, conn)
                                    cmd.Parameters.AddWithValue("@DoctorId", doctorId)
                                    cmd.Parameters.AddWithValue("@Name", name)
                                    cmd.Parameters.AddWithValue("@Gender", gender)
                                    cmd.Parameters.AddWithValue("@Address", address)
                                    cmd.Parameters.AddWithValue("@Expertise", expertise)
                                    cmd.Parameters.AddWithValue("@Experience", experience)
                                    cmd.Parameters.AddWithValue("@ContactNo", contactNo)

                                    cmd.ExecuteNonQuery()
                                    MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Form4.PopulateDoctorExpertiseComboBox()
                                End Using

                                ' Load data into DataGridView
                                LoadDataIntoDataGridView()
                                ClearTextBoxes()

                            Else
                                MessageBox.Show("Invalid input for Experience.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Else
                            MessageBox.Show("All required fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("No changes were made.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Doctor ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            ' Check if TextBox1.Text is a valid integer
            Dim doctorId As Integer
            If Not Integer.TryParse(TextBox1.Text, doctorId) Then
                MessageBox.Show("Please enter a valid Doctor ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If DoctorExists(doctorId) Then
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                Dim selectedRowIndex As Integer = DataGridView1.CurrentCell.RowIndex

                If selectedRowIndex >= 0 Then
                    Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete this record?",
                                                                    "Confirm Delete",
                                                                    MessageBoxButtons.YesNo,
                                                                    MessageBoxIcon.Question)

                    If confirmResult = DialogResult.Yes Then
                        Dim deleteQuery As String = "DELETE FROM doctor WHERE doctorid = @DoctorId"

                        Using cmd As New MySqlCommand(deleteQuery, conn)
                            cmd.Parameters.AddWithValue("@DoctorId", doctorId)

                            cmd.ExecuteNonQuery()
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Form4.PopulateDoctorExpertiseComboBox()

                        End Using

                        ' Load data into DataGridView
                        LoadDataIntoDataGridView()
                        ClearTextBoxes()
                    End If
                Else
                    MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Doctor ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    ' Load data into DataGridView from the database
    Private Sub LoadDataIntoDataGridView()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim selectQuery As String = "SELECT * FROM doctor"

            Using cmd As New MySqlCommand(selectQuery, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    DataGridView1.DataSource = dataTable
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Clear TextBoxes
    Private Sub ClearTextBoxes()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ClearTextBoxes()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("doctorid").Value.ToString()
            TextBox2.Text = row.Cells("name").Value.ToString()
            Dim gender As String = row.Cells("gender").Value.ToString()
            If gender = "Male" Then
                RadioButton1.Checked = True
            ElseIf gender = "Female" Then
                RadioButton2.Checked = True
            End If
            TextBox3.Text = row.Cells("address").Value.ToString()
            TextBox4.Text = row.Cells("expertise").Value.ToString()
            TextBox5.Text = row.Cells("experience").Value.ToString()
            TextBox6.Text = row.Cells("contactno").Value.ToString()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Check if the entered key is not a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True ' Ignore the key input if it is not a digit or backspace
            MessageBox.Show("Doctor ID must be a numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        ' Allow letters, spaces, and backspace
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> Convert.ToChar(Keys.Back) AndAlso e.KeyChar <> " "c Then
            e.Handled = True ' Ignore the key input if it is not a letter, space, or backspace
            MessageBox.Show("Name must contain only alphabet characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        ' Allow letters, spaces, and backspace
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> Convert.ToChar(Keys.Back) AndAlso e.KeyChar <> " "c Then
            e.Handled = True ' Ignore the key input if it is not a letter, space, or backspace
            MessageBox.Show("Expertise must contain only alphabet characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        ' Check if the entered key is not a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True ' Ignore the key input if it is not a digit or backspace
            MessageBox.Show("Experience must be a numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        ' Check if the entered key is not a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True ' Ignore the key input if it is not a digit or backspace
            MessageBox.Show("Contact number must be a numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Check if the length of TextBox6 is already 10 (considering 0-based index)
        If TextBox6.Text.Length >= 10 And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True ' Ignore the key input if it would exceed 10 digits
            MessageBox.Show("Contact number must be a 10-digit integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Function ContainsNumeric(value As String) As Boolean
        For Each c As Char In value
            If Char.IsDigit(c) Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Form3.Show()
        Me.Hide()
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        patient.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        patient.Show()
        Me.Hide()
    End Sub
End Class
