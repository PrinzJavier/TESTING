Imports MySql.Data.MySqlClient

Public Class LandingPage
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=glucocheck"

        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT ID FROM accounts WHERE Username = @Username AND Password = @Password"

            COMMAND = New MySqlCommand(Query, conn)
            COMMAND.Parameters.AddWithValue("@Username", Username_TextBox.Text)
            COMMAND.Parameters.AddWithValue("@Password", Password_TextBox.Text)
            READER = COMMAND.ExecuteReader()

            Dim userID As Integer = -1

            If READER.Read() Then
                userID = READER.GetInt32("ID") ' Retrieve the user ID
            End If

            If userID <> -1 Then
                ' Pass the user ID to the Dashboard
                Dim dashboard As New Dashboard()
                dashboard.LoggedInUserID = userID
                dashboard.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password.")
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        AccountCreation.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        ForgotPassword.Show()
        Me.Hide()
    End Sub
End Class
