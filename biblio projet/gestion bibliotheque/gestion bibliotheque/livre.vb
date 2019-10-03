Imports MySql.Data.MySqlClient


Public Class livre
    Dim cn As New MySqlConnection
    Dim idau As Integer
    Dim datread As MySqlDataReader
    Private Shared _instance As livre
    Public Shared ReadOnly Property instance As livre

        Get
            If _instance Is Nothing Then
                _instance = New livre
            End If
            Return _instance
        End Get
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim req3 As New MySqlCommand
        Dim READER As MySqlDataReader

        Dim Query As String
        Query = "select * from auteur where nom_AU='" & TextBox4.Text & "' and prenom_Au='" & TextBox5.Text & "' "
        req3 = New MySqlCommand(Query, cn)
        READER = req3.ExecuteReader

        Dim count As Integer
        count = 0

        While READER.Read
            count = count + 1

        End While

        If count >= 1 Then

            idau = READER.GetValue(0)

            '  MsgBox(idau)
        Else
            READER.Close()
            Dim aute As New MySqlCommand("INSERT INTO `auteur`(`nom_AU`, `prenom_AU`) VALUES (@nom,@pren)", cn)
            aute.Parameters.Add("@nom", MySqlDbType.VarChar).Value = TextBox4.Text
            aute.Parameters.Add("@pren", MySqlDbType.VarChar).Value = TextBox5.Text
            aute.ExecuteNonQuery()


            Query = "select * from auteur where nom_AU='" & TextBox4.Text & "' and prenom_Au='" & TextBox5.Text & "' "
            req3 = New MySqlCommand(Query, cn)
            READER = req3.ExecuteReader
            If READER.Read Then
                idau = READER.GetValue(0)
            End If
            ' MsgBox(idau)

        End If
        READER.Close()
        Dim liv As New MySqlCommand("INSERT INTO `livre`(`code_L`, `titre_L`, `nbr_de_page`, `nbr_de_copie`,`ID_AU`,`reservation`) VALUES (@cod,@tit,@nbrpag,@nbrcop,@idau,@res)", cn)
        liv.Parameters.Add("@cod", MySqlDbType.VarChar).Value = TextBox1.Text
        liv.Parameters.Add("@tit", MySqlDbType.VarChar).Value = TextBox2.Text
        liv.Parameters.Add("@nbrpag", MySqlDbType.Int16).Value = TextBox3.Text
        liv.Parameters.Add("@nbrcop", MySqlDbType.Int16).Value = TextBox6.Text
        liv.Parameters.Add("@idau", MySqlDbType.Int16).Value = idau
        liv.Parameters.Add("@res", MySqlDbType.VarChar).Value = "non"
        liv.ExecuteNonQuery()



        MsgBox("vous avez ajouté votre livre avec succès ")
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()


    End Sub




    Private Sub livre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New MySqlConnection
        cn.ConnectionString = "server= localhost;userid=root;password=;database=projet_bibliotheque"
        cn.Open()



    End Sub
End Class
