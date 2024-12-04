Imports MySql.Data.MySqlClient

Public Class AccountCreation
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=glucocheck"

        Dim Gender As String
        Dim Type As String

        'Gender
        If ComboBox2.Text = "Male" Then
            Gender = "Male"
        ElseIf ComboBox2.Text = "Female" Then
            Gender = "Female"
        ElseIf ComboBox2.Text = "Prefer not to say" Then
            Gender = "Prefer not to say"
        Else
            MessageBox.Show("Please select a gender.")
            Exit Sub
        End If

        'Type
        If ComboBox1.Text = "Type 1" Then
            Type = "1"
        ElseIf ComboBox1.Text = "Type 2" Then
            Type = "2"
        Else
            MessageBox.Show("Please select a type.")
            Exit Sub
        End If

        Try
            conn.Open()

            ' Age Calculation
            Dim BirthDate As Date = DateTimePicker1.Value
            Dim Today As Date = DateTime.Now
            Dim Age As Integer = Today.Year - BirthDate.Year
            If Today < BirthDate.AddYears(Age) Then
                Age -= 1
            End If

            ' Retrieval Code
            Dim random As New Random()
            Dim RetrievalCode As String = random.Next(1000, 10000).ToString()
            Dim Query As String = "INSERT INTO accounts (Username, Password, Name, Age, DOB, Gender, Height, Weight, Email, RetrievalCode, Type) " &
                                  "VALUES (@Username, @Password, @Name, @Age, @DOB, @Gender, @Height, @Weight, @Email, @RetrievalCode, @Type)"

            COMMAND = New MySqlCommand(Query, conn)
            COMMAND.Parameters.AddWithValue("@Username", TextBox_Username.Text)
            COMMAND.Parameters.AddWithValue("@Password", TextBox_Password.Text)
            COMMAND.Parameters.AddWithValue("@Name", TextBox_Name.Text)
            COMMAND.Parameters.AddWithValue("@Age", Age)
            COMMAND.Parameters.AddWithValue("@DOB", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
            COMMAND.Parameters.AddWithValue("@Gender", Gender)
            COMMAND.Parameters.AddWithValue("@Height", TextBox_Height.Text)
            COMMAND.Parameters.AddWithValue("@Weight", TextBox_Weight.Text)
            COMMAND.Parameters.AddWithValue("@Email", TextBox_Email.Text)
            COMMAND.Parameters.AddWithValue("@RetrievalCode", RetrievalCode)
            COMMAND.Parameters.AddWithValue("@Type", Type)

            COMMAND.ExecuteNonQuery()
            MessageBox.Show("Account Created. Your Retrieval Code is: " & RetrievalCode)
            LandingPage.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
End Class
