Imports MySql.Data.MySqlClient

Public Class patient
    Dim conn As New MySqlConnection("Data Source=localhost;database=nexamed;username=root;password=1234")
    Private Sub patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        LoadDataIntoDataGridView()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Validate input fields
        If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse
       Not IsNumeric(TextBox1.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox2.Text) OrElse
       ContainsNumeric(TextBox2.Text) OrElse
       DateTimePicker1.Value > DateTime.Now OrElse
       String.IsNullOrWhiteSpace(TextBox5.Text) OrElse
       Not IsNumeric(TextBox6.Text) OrElse
       TextBox6.Text.Length <> 10 OrElse
       ContainsNumeric(TextBox7.Text) OrElse
       (Not RadioButton1.Checked AndAlso Not RadioButton2.Checked) Then
            MessageBox.Show("Please fill all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim patientId As Integer
            Dim name As String = TextBox2.Text
            Dim dob As Date = DateTimePicker1.Value
            Dim gender As String = If(RadioButton1.Checked, "Male", "Female")
            Dim address As String = TextBox5.Text
            Dim contactNo As String = TextBox6.Text
            Dim medicalHistory As String = TextBox7.Text

            ' Validate if the entered values are valid
            If Integer.TryParse(TextBox1.Text, patientId) Then
                ' Check if name, address, and medical history are not empty
                If Not String.IsNullOrEmpty(name) AndAlso
               Not String.IsNullOrEmpty(address) AndAlso
               Not String.IsNullOrEmpty(medicalHistory) Then

                    Dim insertQuery As String = "INSERT INTO patient (patientid, name, dob, gender, address, contactno, medicalhistory) VALUES (@PatientId, @Name, @Dob, @Gender, @Address, @ContactNo, @MedicalHistory)"

                    ' Check for duplicate key before executing the query
                    If Not IsDuplicateKey(patientId) Then
                        Using cmd As New MySqlCommand(insertQuery, conn)
                            cmd.Parameters.AddWithValue("@PatientId", patientId)
                            cmd.Parameters.AddWithValue("@Name", name)
                            cmd.Parameters.AddWithValue("@Dob", dob)
                            cmd.Parameters.AddWithValue("@Gender", gender)
                            cmd.Parameters.AddWithValue("@Address", address)
                            cmd.Parameters.AddWithValue("@ContactNo", contactNo)
                            cmd.Parameters.AddWithValue("@MedicalHistory", medicalHistory)

                            cmd.ExecuteNonQuery()
                            MessageBox.Show("Record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Form4.PopulatePatientIDsComboBox()
                            ' Load data into DataGridView
                            LoadDataIntoDataGridView()
                            ClearTextBoxes()
                        End Using
                    Else
                        MessageBox.Show("PatientId already present. Please enter a different PatientId.", "Duplicate Key Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Name, Address, and Medical History cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Invalid input for PatientId.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Function PatientExists(patientId As Integer) As Boolean
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim query As String = "SELECT COUNT(*) FROM patient WHERE patientid = @PatientId"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@PatientId", patientId)

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
            Dim patientId As Integer
            If Not Integer.TryParse(TextBox1.Text, patientId) Then
                MessageBox.Show("Please enter a valid Patient ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If PatientExists(patientId) Then
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                Dim selectedRowIndex As Integer = DataGridView1.CurrentCell.RowIndex

                If selectedRowIndex >= 0 Then
                    ' Check if any field is modified
                    If TextBox2.Modified OrElse TextBox5.Modified OrElse TextBox6.Modified OrElse TextBox7.Modified OrElse RadioButton1.Checked OrElse RadioButton2.Checked Then
                        Dim name As String = TextBox2.Text
                        Dim dob As Date = DateTimePicker1.Value
                        Dim gender As String = If(RadioButton1.Checked, "Male", "Female")
                        Dim address As String = TextBox5.Text
                        Dim contactNo As String = TextBox6.Text
                        Dim medicalHistory As String = TextBox7.Text

                        ' Check if all required fields are filled
                        If Not String.IsNullOrEmpty(name) AndAlso
                       Not String.IsNullOrEmpty(address) AndAlso
                       Not String.IsNullOrEmpty(contactNo) AndAlso
                       Not String.IsNullOrEmpty(medicalHistory) Then

                            Dim updateQuery As String = "UPDATE patient SET name = @Name, dob = @Dob, gender = @Gender, address = @Address, contactno = @ContactNo, medicalhistory = @MedicalHistory WHERE patientid = @PatientId"

                            Using cmd As New MySqlCommand(updateQuery, conn)
                                cmd.Parameters.AddWithValue("@PatientId", patientId)
                                cmd.Parameters.AddWithValue("@Name", name)
                                cmd.Parameters.AddWithValue("@Dob", dob)
                                cmd.Parameters.AddWithValue("@Gender", gender)
                                cmd.Parameters.AddWithValue("@Address", address)
                                cmd.Parameters.AddWithValue("@ContactNo", contactNo)
                                cmd.Parameters.AddWithValue("@MedicalHistory", medicalHistory)

                                cmd.ExecuteNonQuery()
                                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Form4.PopulatePatientIDsComboBox()
                            End Using

                            ' Load data into DataGridView
                            LoadDataIntoDataGridView()
                            ClearTextBoxes()

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
                MessageBox.Show("Patient ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            Dim patientId As Integer = Convert.ToInt32(TextBox1.Text)

            If PatientExists(patientId) Then
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                Dim selectedRowIndex As Integer = DataGridView1.CurrentCell.RowIndex

                If selectedRowIndex >= 0 Then
                    ' Ask for confirmation before deleting
                    Dim confirmationResult As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If confirmationResult = DialogResult.Yes Then
                        Dim deleteQuery As String = "DELETE FROM patient WHERE patientid = @PatientId"

                        Using cmd As New MySqlCommand(deleteQuery, conn)
                            cmd.Parameters.AddWithValue("@PatientId", patientId)

                            cmd.ExecuteNonQuery()
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Form4.PopulatePatientIDsComboBox()

                        End Using

                        ' Load data into DataGridView
                        LoadDataIntoDataGridView()
                        ClearTextBoxes()
                    End If
                Else
                    MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Patient ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ClearTextBoxes()
    End Sub

    Private Sub LoadDataIntoDataGridView()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim selectQuery As String = "SELECT * FROM patient"

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

    Private Sub ClearTextBoxes()
        TextBox1.Clear()
        TextBox2.Clear()
        DateTimePicker1.Value = DateTime.Now
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("patientid").Value.ToString()
            TextBox2.Text = row.Cells("name").Value.ToString()
            DateTimePicker1.Value = Convert.ToDateTime(row.Cells("dob").Value)
            Dim gender As String = row.Cells("gender").Value.ToString()
            If gender = "Male" Then
                RadioButton1.Checked = True
            ElseIf gender = "Female" Then
                RadioButton2.Checked = True
            End If
            TextBox5.Text = row.Cells("address").Value.ToString()
            TextBox6.Text = row.Cells("contactno").Value.ToString()
            TextBox7.Text = row.Cells("medicalhistory").Value.ToString()
        End If
    End Sub


    Private Function IsDuplicateKey(patientId As Integer) As Boolean
        ' Check if the PatientId already exists in the database
        Dim query As String = "SELECT COUNT(*) FROM patient WHERE patientid = @PatientId"
        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@PatientId", patientId)
            Dim count As Integer = CInt(cmd.ExecuteScalar())
            Return count > 0
        End Using
    End Function


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Check if the entered key is not a digit or backspace
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True ' Ignore the key input if it is not a digit or backspace
            MessageBox.Show("Patient ID must be a numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        ' Check if the entered key is not an alphabet, space, or backspace
        If Not Char.IsLetter(e.KeyChar) And e.KeyChar <> Convert.ToChar(Keys.Back) And e.KeyChar <> " "c Then
            e.Handled = True ' Ignore the key input if it is not an alphabet, space, or backspace
            MessageBox.Show("Name must contain only alphabet characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        ' Check if the entered key is not a digit or backspace
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True ' Ignore the key input if it is not a digit or backspace
            MessageBox.Show("Contact number must be a numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Check if the length of TextBox6 is already 10 (considering 0-based index)
        If TextBox6.Text.Length >= 10 And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True ' Ignore the key input if it would exceed 10 digits
            MessageBox.Show("Contact number must be a 10-digit integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        ' Check if the entered key is not a digit or backspace
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Ignore the key input if it is a digit
            MessageBox.Show("Additional Information must contain only text.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        doctor.Show()
        Me.Hide()
    End Sub
    Private Sub DateTimePicker1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DateTimePicker1.Validating
        ' Check if the selected date is after today
        If DateTimePicker1.Value > DateTime.Now Then
            MessageBox.Show("Please select  date of birth on or before today.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Cancel the event to keep focus on the DateTimePicker
            e.Cancel = True
            DateTimePicker1.Value = DateTime.Now
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        doctor.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class
