Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class form4

    Dim conn As New MySqlConnection("Data Source=localhost;database=nexamed;username=root;password=1234")

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ' Populate ComboBox1 with distinct doctor expertise
        PopulateDoctorExpertiseComboBox()
        PopulateTimeSlotsComboBox()
        ' Populate ComboBox4 with patient IDs
        PopulatePatientIDsComboBox()
        ' Update the DataGridView when the form loads
        UpdateDataGridView()
    End Sub
    Private Sub Form4_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' Update the DataGridView every time the form is activated
        UpdateDataGridView()
    End Sub
    Public Sub PopulateDoctorExpertiseComboBox()
        ComboBox1.Items.Clear()
        ' Populate ComboBox1 with distinct doctor expertise from the Doctor table
        Dim query As String = "SELECT DISTINCT Expertise FROM Doctor"
        Using connection As New MySqlConnection(conn.ConnectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                While reader.Read()
                    ComboBox1.Items.Add(reader.GetString("Expertise"))
                End While
            End Using
        End Using
    End Sub
    Public Sub PopulatePatientIDsComboBox()
        ComboBox4.Items.Clear()
        ' Populate ComboBox4 with patient IDs from the Patient table
        Dim query As String = "SELECT  PatientID FROM Patient"
        Using connection As New MySqlConnection(conn.ConnectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                While reader.Read()
                    ComboBox4.Items.Add(reader.GetInt32("PatientID").ToString())

                End While
            End Using
        End Using
    End Sub
    Private Sub PopulateTimeSlotsComboBox()
        ' Add predefined time slots to ComboBox3
        ComboBox3.Items.Clear() ' Clear existing items first
        ComboBox3.Items.Add("08:00 AM")
        ComboBox3.Items.Add("08:15 AM")
        ComboBox3.Items.Add("08:30 AM")
        ComboBox3.Items.Add("08:45 AM")
        ComboBox3.Items.Add("09:00 AM")
        ComboBox3.Items.Add("09:15 AM")
        ComboBox3.Items.Add("09:30 AM")
        ComboBox3.Items.Add("09:45 AM")
        ComboBox3.Items.Add("10:00 AM")
        ComboBox3.Items.Add("10:15 AM")
        ComboBox3.Items.Add("10:30 AM")
        ComboBox3.Items.Add("10:45 AM")
        ComboBox3.Items.Add("11:00 AM")
        ComboBox3.Items.Add("11:15 AM")
        ComboBox3.Items.Add("11:30 AM")
        ComboBox3.Items.Add("11:45 AM")
        ComboBox3.Items.Add("12:00 PM")
        ComboBox3.Items.Add("02:00 PM")
        ComboBox3.Items.Add("02:15 PM")
        ComboBox3.Items.Add("02:30 PM")
        ComboBox3.Items.Add("02:45 PM")
        ComboBox3.Items.Add("03:00 PM")
        ComboBox3.Items.Add("03:15 PM")
        ComboBox3.Items.Add("03:30 PM")
        ComboBox3.Items.Add("03:45 PM")
        ComboBox3.Items.Add("04:00 PM")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem IsNot Nothing Then
            ' When ComboBox1 selection changes, populate ComboBox2 with corresponding doctor names
            ComboBox2.Items.Clear() ' Clear existing items first

            Dim selectedExpertise As String = ComboBox1.SelectedItem.ToString()
            Dim query As String = "SELECT Name FROM Doctor WHERE Expertise = @Expertise"
            Using connection As New MySqlConnection(conn.ConnectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Expertise", selectedExpertise)
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        ComboBox2.Items.Add(reader.GetString("Name"))
                    End While
                End Using
            End Using
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not ValidateInput() Then
            Return
        End If
        If AppointmentIdExists(TextBox1.Text) Then
            MessageBox.Show("Appointment ID already exists. Please enter a unique Appointment ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            ' Get the selected doctor's ID
            Dim doctorId As Integer = GetDoctorId(ComboBox2.SelectedItem.ToString())

            ' Get the appointment ID from TextBox1
            Dim appointmentId As Integer = Integer.Parse(TextBox1.Text)

            ' Insert a new appointment record into the Appointment table
            Dim query As String = "INSERT INTO Appointment (AppointmentID, DoctorID, PatientID, AppointmentDate, AppointmentTime, Status, Ambulance) " &
                              "VALUES (@AppointmentID, @DoctorID, @PatientID, @AppointmentDate, @AppointmentTime, @Status, @Ambulance)"
            Using connection As New MySqlConnection(conn.ConnectionString)
                Using command As New MySqlCommand(query, connection)
                    connection.Open()

                    ' Set parameters
                    command.Parameters.AddWithValue("@AppointmentID", appointmentId)
                    command.Parameters.AddWithValue("@DoctorID", doctorId)
                    command.Parameters.AddWithValue("@PatientID", ComboBox4.Text) ' Change TextBox2 to ComboBox4
                    command.Parameters.AddWithValue("@AppointmentDate", DateTimePicker1.Value.Date)
                    command.Parameters.AddWithValue("@AppointmentTime", ComboBox3.SelectedItem.ToString())
                    command.Parameters.AddWithValue("@Status", "Confirmed")
                    command.Parameters.AddWithValue("@Ambulance", If(RadioButton1.Checked, "Yes", "No"))

                    ' Execute the query
                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Show success message
            MessageBox.Show("Appointment booked successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            history.LoadDataIntoDataGridView()
            resetform()
            ' Update the DataGridView
            UpdateDataGridView()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetDoctorId(doctorName As String) As Integer
        ' Retrieve the doctor's ID based on the selected doctor name
        Dim doctorId As Integer = 0
        Dim query As String = "SELECT DoctorID FROM Doctor WHERE Name = @Name"
        Using connection As New MySqlConnection(conn.ConnectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Name", doctorName)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    doctorId = reader.GetInt32("DoctorID")
                End If
            End Using
        End Using
        Return doctorId
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Reset all fields
        resetform()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Check if a row is selected in the DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Get the selected appointment ID
            Dim appointmentId = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("AppointmentID").Value)

            ' Confirm with the user before deleting the appointment
            Dim result = MessageBox.Show("Are you sure you want to delete this appointment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Try
                    ' Delete the appointment from the database
                    Dim query = "DELETE FROM Appointment WHERE AppointmentID = @AppointmentID"
                    Using connection As New MySqlConnection(conn.ConnectionString)
                        Using command As New MySqlCommand(query, connection)
                            command.Parameters.AddWithValue("@AppointmentID", appointmentId)
                            connection.Open()
                            command.ExecuteNonQuery()
                        End Using
                    End Using

                    ' Show success message
                    MessageBox.Show("Appointment deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    history.LoadDataIntoDataGridView()
                    ' Update the DataGridView
                    UpdateDataGridView()
                    resetform()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Please select an appointment to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Only allow numeric input for TextBox1
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Function ValidateInput() As Boolean
        ' Validate Appointment ID
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MessageBox.Show("Please enter the Appointment ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Validate Patient ID
        If ComboBox4.SelectedIndex = -1 Then ' Check if ComboBox4 has a selected item
            MessageBox.Show("Please select a Patient ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Validate Doctor selection
        If ComboBox1.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a Doctor Expertise.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If ComboBox2.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a Doctor Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Validate Time selection
        If ComboBox3.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an Appointment Time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Validate Ambulance selection
        If Not RadioButton1.Checked AndAlso Not RadioButton2.Checked Then
            MessageBox.Show("Please select if Ambulance is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ' Check if both doctor and date are selected
        If ComboBox2.SelectedItem IsNot Nothing AndAlso DateTimePicker1.Value >= DateTime.Today Then
            ' Get the selected doctor's ID
            Dim doctorId As Integer = GetDoctorId(ComboBox2.SelectedItem.ToString())

            ' Get the selected date
            Dim selectedDate As Date = DateTimePicker1.Value.Date

            ' Retrieve booked and canceled appointments for the selected doctor on the selected date
            Dim bookedAndCanceledTimeSlots As New List(Of String)()
            Dim query As String = "SELECT AppointmentTime FROM Appointment WHERE DoctorID = @DoctorID AND AppointmentDate = @AppointmentDate AND Status != 'Cancelled'"
            Using connection As New MySqlConnection(conn.ConnectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@DoctorID", doctorId)
                    command.Parameters.AddWithValue("@AppointmentDate", selectedDate)
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        bookedAndCanceledTimeSlots.Add(reader.GetString("AppointmentTime"))
                    End While
                End Using
            End Using

            ' Display available time slots based on existing appointments (both booked and canceled)
            DisplayAvailableTimeSlots(bookedAndCanceledTimeSlots)
        End If
    End Sub

    Private Function AppointmentIdExists(appointmentId As String) As Boolean
        ' Check if the specified Appointment ID exists in the Appointment table
        Dim query As String = "SELECT COUNT(*) FROM Appointment WHERE AppointmentID = @AppointmentID"
        Using connection As New MySqlConnection(conn.ConnectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@AppointmentID", appointmentId)
                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ' Check if the selected date is before today
        If DateTimePicker1.Value < DateTime.Today Then
            ' Reset DateTimePicker1 to today's date
            DateTimePicker1.Value = DateTime.Today
        Else
            ' Check if both doctor and date are selected
            If ComboBox2.SelectedItem IsNot Nothing Then
                ' Trigger the ComboBox2_SelectedIndexChanged event to update available time slots
                ComboBox2_SelectedIndexChanged(ComboBox2, EventArgs.Empty)
            End If
        End If
    End Sub
    Public Sub resetform()
        ' Reset all fields
        TextBox1.Clear()
        ComboBox4.SelectedIndex = -1 ' Clear the selected item in ComboBox4
        ComboBox1.SelectedIndex = -1
        ComboBox2.Items.Clear()
        DateTimePicker1.Value = Date.Today()
        ComboBox3.SelectedIndex = -1
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub
    Private Sub DisplayAvailableTimeSlots(bookedTimeSlots As List(Of String))
        ' Clear ComboBox3 items first
        ComboBox3.Items.Clear()

        ' Get predefined time slots for the day
        Dim predefinedTimeSlots = GetPredefinedTimeSlots()

        ' Get the selected date
        Dim selectedDate As Date = DateTimePicker1.Value.Date

        ' Check if the selected date is today
        If selectedDate = DateTime.Today Then
            ' Get the current system time
            Dim currentTime As TimeSpan = DateTime.Now.TimeOfDay

            ' Add available time slots to ComboBox3 after the current system time
            For Each timeSlot As String In predefinedTimeSlots
                ' Parse the time slot string to a DateTime object
                Dim timeSlotDateTime As DateTime = DateTime.ParseExact(timeSlot, "hh:mm tt", CultureInfo.InvariantCulture)

                ' Convert the DateTime to a TimeSpan
                Dim timeSlotTime As TimeSpan = timeSlotDateTime.TimeOfDay

                ' Check if the time slot is after the current system time and not booked or canceled
                If timeSlotTime > currentTime AndAlso Not bookedTimeSlots.Contains(timeSlot) Then
                    ComboBox3.Items.Add(timeSlot)
                End If
            Next
        Else
            ' Add all predefined time slots to ComboBox3 for other days
            For Each timeSlot As String In predefinedTimeSlots
                ' Check if the time slot is not booked or canceled
                If Not bookedTimeSlots.Contains(timeSlot) Then
                    ComboBox3.Items.Add(timeSlot)
                End If
            Next
        End If
    End Sub



    Private Function GetPredefinedTimeSlots() As List(Of String)
        ' Define and return predefined time slots for the day
        Dim timeSlots As New List(Of String)()
        timeSlots.Add("08:00 AM")
        timeSlots.Add("08:15 AM")
        timeSlots.Add("08:30 AM")
        timeSlots.Add("08:45 AM")
        timeSlots.Add("09:00 AM")
        timeSlots.Add("09:15 AM")
        timeSlots.Add("09:30 AM")
        timeSlots.Add("09:45 AM")
        timeSlots.Add("10:00 AM")
        timeSlots.Add("10:15 AM")
        timeSlots.Add("10:30 AM")
        timeSlots.Add("10:45 AM")
        timeSlots.Add("11:00 AM")
        timeSlots.Add("11:15 AM")
        timeSlots.Add("11:30 AM")
        timeSlots.Add("11:45 AM")
        timeSlots.Add("12:00 PM")
        timeSlots.Add("02:00 PM")
        timeSlots.Add("02:15 PM")
        timeSlots.Add("02:30 PM")
        timeSlots.Add("02:45 PM")
        timeSlots.Add("03:00 PM")
        timeSlots.Add("03:15 PM")
        timeSlots.Add("03:30 PM")
        timeSlots.Add("03:45 PM")
        timeSlots.Add("04:00 PM")

        Return timeSlots
    End Function
    Private Sub UpdateDataGridView()
        ' Update the DataGridView with the latest data from the Appointment table
        Dim query As String = "SELECT AppointmentID, Appointment.DoctorID, PatientID, AppointmentDate, AppointmentTime, Status, Ambulance, Doctor.Name AS DoctorName, Doctor.Expertise AS DoctorExpertise " &
                              "FROM Appointment " &
                              "INNER JOIN Doctor ON Appointment.DoctorID = Doctor.DoctorID"
        Dim dataTable As New DataTable()
        Using connection As New MySqlConnection(conn.ConnectionString)
            Using adapter As New MySqlDataAdapter(query, connection)
                connection.Open()
                adapter.Fill(dataTable)
            End Using
        End Using
        DataGridView1.DataSource = dataTable
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' When a cell is clicked in the DataGridView, display the data in the corresponding controls
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TextBox1.Text = selectedRow.Cells("AppointmentID").Value.ToString()
            ComboBox4.Text = selectedRow.Cells("PatientID").Value.ToString()
            ComboBox1.Text = selectedRow.Cells("DoctorExpertise").Value.ToString()
            ComboBox2.Text = selectedRow.Cells("DoctorName").Value.ToString()
            DateTimePicker1.Value = DateTime.Parse(selectedRow.Cells("AppointmentDate").Value.ToString())
            ComboBox3.Text = selectedRow.Cells("AppointmentTime").Value.ToString()
            If selectedRow.Cells("Ambulance").Value.ToString() = "Yes" Then
                RadioButton1.Checked = True
            Else
                RadioButton2.Checked = True
            End If
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
