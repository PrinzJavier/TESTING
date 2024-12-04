Imports MySql.Data.MySqlClient

Public Class Dashboard
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader
    Public Property LoggedInUserID As Integer

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim connectionString As String = "server=localhost;userid=root;password='';database=glucocheck"
        conn = New MySqlConnection(connectionString)
        Dim sugarLevel As String = TextBox1.Text
        Dim reason As String = TextBox2.Text
        Dim selectedDateTime As DateTime = DateTimePicker1.Value

        If String.IsNullOrEmpty(sugarLevel) OrElse String.IsNullOrEmpty(reason) Then
            MessageBox.Show("Please enter both the sugar level and reason.")
            Exit Sub
        End If

        Try
            conn.Open()
            Dim query As String = "INSERT INTO bsrecords (DateTime, SugarLevel, Reason, ID) 
                               VALUES (@DateTime, @SugarLevel, @Reason, @ID)"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@DateTime", selectedDateTime)
                cmd.Parameters.AddWithValue("@SugarLevel", sugarLevel)
                cmd.Parameters.AddWithValue("@Reason", reason)
                cmd.Parameters.AddWithValue("@ID", LoggedInUserID)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Sugar level recorded successfully.")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        LandingPage.Show()
    End Sub

    Private Sub DisplaySugarSummaryPerWeek()
        Dim connectionString As String = "server=localhost;userid=root;password='';database=glucocheck"
        conn = New MySqlConnection(connectionString)
        Dim query As String = "SELECT DAYOFWEEK(DateTime) AS DayOfWeek, AVG(SugarLevel) AS AvgSugarLevel 
                           FROM bsrecords 
                           WHERE ID = @ID 
                           GROUP BY DAYOFWEEK(DateTime)
                           ORDER BY DAYOFWEEK(DateTime);"

        Try
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", LoggedInUserID)
                READER = cmd.ExecuteReader()

                Dim daysOfWeek As String() = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"}

                While READER.Read()
                    Dim dayOfWeek As Integer = READER("DayOfWeek")
                    Dim avgSugarLevel As Decimal = READER("AvgSugarLevel")
                    Chart1.Series("Blood Sugar Level Summary").Points.AddXY(daysOfWeek(dayOfWeek - 1), avgSugarLevel)
                End While

                MessageBox.Show("Blood sugar summary per week displayed successfully.")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

        Chart1.ChartAreas(0).AxisX.Enabled = DataVisualization.Charting.AxisEnabled.True
        Chart1.ChartAreas(0).AxisY.Title = "Blood Sugar Level"
        Chart1.ChartAreas(0).AxisY.Minimum = 0
        Chart1.ChartAreas(0).AxisY.Maximum = 300
    End Sub
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplaySugarSummaryPerWeek()
    End Sub
    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub
End Class
