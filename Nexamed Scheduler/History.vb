Imports MySql.Data.MySqlClient
Public Class history
    Dim conn As New MySqlConnection("Data Source=localhost;database=nexamed;username=root;password=1234")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if any of the textboxes is empty
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Appointment ID must be filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' Validate and fetch data for the given AppointmentID
            Dim appointmentId As Integer

            If Integer.TryParse(TextBox1.Text, appointmentId) Then
                ' Check if the entered AppointmentID exists in the database
                Dim checkIDQuery As String = "SELECT COUNT(*) FROM appointment WHERE AppointmentID = @AppointmentID"

                Using cmd As New MySqlCommand(checkIDQuery, conn)
                    cmd.Parameters.AddWithValue("@AppointmentID", appointmentId)

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count > 0 Then
                        ' Fetch data for the given AppointmentID
                        Dim selectQuery As String = "SELECT * FROM appointment WHERE AppointmentID = @AppointmentID ORDER BY AppointmentDate DESC"

                        Using cmdSelect As New MySqlCommand(selectQuery, conn)
                            cmdSelect.Parameters.AddWithValue("@AppointmentID", appointmentId)

                            Using adapter As New MySqlDataAdapter(cmdSelect)
                                Dim dataTable As New DataTable()
                                adapter.Fill(dataTable)

                                ' Display the result in the DataGridView
                                DataGridView1.DataSource = dataTable
                            End Using
                        End Using
                    Else
                        MessageBox.Show("AppointmentID not found in the database.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Else
                MessageBox.Show("Invalid Appointment ID. Please enter a valid ID.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Reset TextBox and DataGridView
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        LoadDataIntoDataGridView()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Check if any of the textboxes is empty
        If String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MessageBox.Show("Doctor ID must be filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' Validate and fetch data for the given DoctorID
            Dim doctorId As Integer

            If Integer.TryParse(TextBox2.Text, doctorId) Then
                ' Check if the entered DoctorID exists in the database
                Dim checkIDQuery As String = "SELECT COUNT(*) FROM appointment WHERE DoctorID = @DoctorID"

                Using cmd As New MySqlCommand(checkIDQuery, conn)
                    cmd.Parameters.AddWithValue("@DoctorID", doctorId)

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count > 0 Then
                        ' Fetch data for the given DoctorID
                        Dim selectQuery As String = "SELECT * FROM appointment WHERE DoctorID = @DoctorID ORDER BY AppointmentDate DESC"

                        Using cmdSelect As New MySqlCommand(selectQuery, conn)
                            cmdSelect.Parameters.AddWithValue("@DoctorID", doctorId)

                            Using adapter As New MySqlDataAdapter(cmdSelect)
                                Dim dataTable As New DataTable()
                                adapter.Fill(dataTable)

                                ' Display the result in the DataGridView
                                DataGridView1.DataSource = dataTable
                            End Using
                        End Using
                    Else
                        MessageBox.Show("DoctorID not found in the database.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Else
                MessageBox.Show("Invalid Doctor ID. Please enter a valid ID.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Check if any of the textboxes is empty
        If String.IsNullOrWhiteSpace(TextBox3.Text) Then
            MessageBox.Show("Patient ID must be filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' Validate and fetch data for the given PatientID
            Dim patientId As Integer

            If Integer.TryParse(TextBox3.Text, patientId) Then
                ' Check if the entered PatientID exists in the database
                Dim checkIDQuery As String = "SELECT COUNT(*) FROM appointment WHERE PatientID = @PatientID"

                Using cmd As New MySqlCommand(checkIDQuery, conn)
                    cmd.Parameters.AddWithValue("@PatientID", patientId)

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count > 0 Then
                        ' Fetch data for the given PatientID
                        Dim selectQuery As String = "SELECT * FROM appointment WHERE PatientID = @PatientID ORDER BY AppointmentDate DESC"

                        Using cmdSelect As New MySqlCommand(selectQuery, conn)
                            cmdSelect.Parameters.AddWithValue("@PatientID", patientId)

                            Using adapter As New MySqlDataAdapter(cmdSelect)
                                Dim dataTable As New DataTable()
                                adapter.Fill(dataTable)

                                ' Display the result in the DataGridView
                                DataGridView1.DataSource = dataTable
                            End Using
                        End Using
                    Else
                        MessageBox.Show("PatientID not found in the database.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Else
                MessageBox.Show("Invalid Patient ID. Please enter a valid ID.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Check if a row is selected in the DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                ' Get the selected AppointmentID from the DataGridView
                Dim selectedAppointmentID As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("AppointmentID").Value)

                ' Update the status to 'Cancelled' in the booking table
                Dim updateBookingQuery As String = "UPDATE appointment SET Status = 'Cancelled' WHERE AppointmentID = @AppointmentID"

                Using cmd As New MySqlCommand(updateBookingQuery, conn)
                    cmd.Parameters.AddWithValue("@AppointmentID", selectedAppointmentID)

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Appointment Cancelled successfully.")
                ' Refresh DataGridView after cancellation
                RefreshDataGridView()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        Else
            MessageBox.Show("Please select an appointment from the DataGridView to cancel.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Check if the entered key is not a digit or backspace
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True ' Ignore the key input if it is not a digit or backspace
            MessageBox.Show("Appointment ID must be a numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        ' Check if the entered key is not a digit or backspace
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True ' Ignore the key input if it is not a digit or backspace
            MessageBox.Show("Doctor ID must be a numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        ' Check if the entered key is not a digit or backspace
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True ' Ignore the key input if it is not a digit or backspace
            MessageBox.Show("Patient ID must be a numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub history_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data into DataGridView when the form is loaded
        Me.WindowState = FormWindowState.Maximized
        LoadDataIntoDataGridView()
    End Sub

    ' Load data into DataGridView from the database
    Public Sub LoadDataIntoDataGridView()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' Fetch all appointments from the database
            Dim selectQuery As String = "SELECT * FROM appointment"

            Using cmd As New MySqlCommand(selectQuery, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    ' Display the result in the DataGridView
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
    ' Refresh DataGridView
    Private Sub RefreshDataGridView()
        ' Clear the current data in DataGridView
        DataGridView1.DataSource = Nothing
        ' Reload data into DataGridView
        LoadDataIntoDataGridView()
    End Sub

End Class
