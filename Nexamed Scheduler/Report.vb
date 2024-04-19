Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Report

    Dim conn As New MySqlConnection("Data Source=localhost;database=nexamed;username=root;password=1234")

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        ' Check if the entered key is not a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True ' Ignore the key input if it is not a digit or backspace
            MessageBox.Show("Doctor ID must be a numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Validate input fields before displaying in the DataGridView
        If TextBox2.Text.Trim() = "" Then
            MessageBox.Show("Please enter a value for Doctor ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Not DateTimePicker1.Checked OrElse Not DateTimePicker2.Checked Then
            MessageBox.Show("Please select valid start and end dates.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If DateTimePicker2.Value.Date < DateTimePicker1.Value.Date Then
            MessageBox.Show("End date cannot be less than start date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTimePicker1.Value = Date.Today
            DateTimePicker2.Value = Date.Today
            Return
        End If
        ' Fetch data from the database and populate the DataGridView
        Try
            Dim doctorId = Integer.Parse(TextBox2.Text)
            Dim startDate = DateTimePicker1.Value
            Dim endDate = DateTimePicker2.Value
            Dim selectedDate = DateTimePicker1.Value.Date ' Get the selected date from DateTimePicker1

            Dim query = "SELECT Doctor.DoctorID, Doctor.Name AS DoctorName, COUNT(Appointment.AppointmentID) AS TotalAppointments, GROUP_CONCAT(CONCAT(Patient.Name, ' - ', DATE_FORMAT(Appointment.AppointmentDate, '%Y-%m-%d')) SEPARATOR ', ') AS PatientInfo " &
            "FROM Appointment " &
            "INNER JOIN Doctor ON Appointment.DoctorID = Doctor.DoctorID " &
            "INNER JOIN Patient ON Appointment.PatientID = Patient.PatientID " &
            "WHERE Appointment.DoctorID = @DoctorID AND (DATE(Appointment.AppointmentDate) BETWEEN @StartDate AND @EndDate OR DATE(Appointment.AppointmentDate) = @SelectedDate) " &
            "GROUP BY Doctor.DoctorID, Doctor.Name"

            Using connection As New MySqlConnection(conn.ConnectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@DoctorID", doctorId)
                    command.Parameters.AddWithValue("@StartDate", startDate)
                    command.Parameters.AddWithValue("@EndDate", endDate)
                    command.Parameters.AddWithValue("@SelectedDate", selectedDate)
                    connection.Open()
                    Dim reader = command.ExecuteReader

                    If Not reader.HasRows Then
                        MessageBox.Show("No bookings found for the specified doctor and date range.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If

                    Dim dataTable As New DataTable
                    dataTable.Load(reader)
                    DataGridView1.DataSource = dataTable
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Reset TextBox
        TextBox2.Clear()

        ' Reset DateTimePickers to today's date
        DateTimePicker1.Value = Date.Today
        DateTimePicker2.Value = Date.Today

        ' Clear DataGridView
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class
