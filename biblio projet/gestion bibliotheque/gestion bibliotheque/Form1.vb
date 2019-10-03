Imports MySql.Data.MySqlClient


Public Class Form1
    Dim cn As New MySqlConnection


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

        'pour affiche le mot de passe

        If TextBox2.UseSystemPasswordChar = True Then

            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim type As String

        cn = New MySqlConnection

        Dim req3 As New MySqlCommand
        Dim READER As MySqlDataReader

        cn.ConnectionString = "server= localhost;userid=root;password=;database=projet_bibliotheque"
        cn.Open()





        Dim Query As String
        Query = "select * from adderent where mail_A='" & TextBox1.Text & "' and mdp_A='" & TextBox2.Text & "' "
        req3 = New MySqlCommand(Query, cn)
        READER = req3.ExecuteReader
        Dim count As Integer
        count = 0

        ' on ajoute un compteur pour varifier si le nom d'utilisateur et le mot de passe
        ' existe ou pas et il accepte seulement si le compteur = 1 

        While READER.Read
            count = count + 1
            type = READER.GetValue(8)

        End While

        If count = 1 Then

            Me.Hide()
            Form2.Show()

            ' Form2.Label3.Text = Me.TextBox1.Text()

        Else
            MsgBox("le mote de passe ou le nom d'utilisateur et incorect")

        End If

        If type = "utilisateur" Then
            Form2.Button2.Hide()
            Form2.Button3.Hide()
            Form2.Button8.Hide()
        Else
            Form2.Button2.Show()
            Form2.Button3.Show()
            Form2.Button8.Show()
        End If



    End Sub
End Class
