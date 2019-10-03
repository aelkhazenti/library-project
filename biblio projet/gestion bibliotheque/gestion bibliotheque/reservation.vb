Imports MySql.Data.MySqlClient

Public Class reservation

    Dim cn As New MySqlConnection
    Dim idau As Integer
    Dim datread As MySqlDataReader
    Dim utilisateur As String
    Dim mdp As String

    Dim id_r As Integer
    Dim id_l As Integer


    Dim id_l_l As Integer
    Dim id_l_r As Integer


    Private Shared _instance As reservation
    Public Shared ReadOnly Property instance As reservation

        Get
            If _instance Is Nothing Then
                _instance = New reservation
            End If
            Return _instance
        End Get
    End Property

    Private Sub reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cn = New MySqlConnection
        cn.ConnectionString = "server= localhost;userid=root;password=;database=projet_bibliotheque"
        cn.Open()


        Dim req3 As New MySqlCommand
        Dim READER As MySqlDataReader

        Dim Query As String
        Query = "select * from livre WHERE reservation = 'non'"
        req3 = New MySqlCommand(Query, cn)
        READER = req3.ExecuteReader

        While READER.Read
            Dim atit = READER.GetString("titre_L")
            ComboBox1.Items.Add(atit)
        End While

        READER.Close()


        Query = "select * from rapport WHERE reservation = 'non' "
        req3 = New MySqlCommand(Query, cn)
        READER = req3.ExecuteReader

        While READER.Read
            Dim rtit = READER.GetString("titre_RA")
            ComboBox2.Items.Add(rtit)
        End While
        READER.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        ComboBox1.Show()
        ComboBox2.Hide()



    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        ComboBox2.Show()
        ComboBox1.Hide()




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click




        utilisateur = Form1.TextBox1.Text
        mdp = Form1.TextBox2.Text

        Dim caha As New MySqlCommand("SELECT * FROM `adderent` WHERE `mail_A`= @mai and `mdp_A`= @md ", cn)
        caha.Parameters.Add("@mai", MySqlDbType.VarChar).Value = utilisateur
        caha.Parameters.Add("@md", MySqlDbType.VarChar).Value = mdp

        caha.ExecuteNonQuery()
        datread = caha.ExecuteReader
        If datread.Read Then
            id_l_l = datread.GetValue(6)
            id_l_r = datread.GetValue(7)

        End If
        datread.Close()








        If RadioButton1.Checked Then
            Dim liv As New MySqlCommand("UPDATE `livre` SET `reservation`='non' WHERE  `ID_L`=@idliii", cn)
            liv.Parameters.Add("@idliii", MySqlDbType.Int16).Value = id_l_l
            liv.ExecuteNonQuery()

            Dim cah As New MySqlCommand("SELECT ID_L FROM `livre` WHERE `titre_L`= @titre ", cn)
            cah.Parameters.Add("@titre", MySqlDbType.VarChar).Value = ComboBox1.Text

            cah.ExecuteNonQuery()
            datread = cah.ExecuteReader
            If datread.Read Then
                id_l = datread.GetValue(0)


            End If
            datread.Close()




            Dim aute As New MySqlCommand("UPDATE `adderent` SET `ID_L`=@idl WHERE `mail_A`= @mai and `mdp_A`= @md ", cn)
            aute.Parameters.Add("@idl", MySqlDbType.Int16).Value = id_l
            aute.Parameters.Add("@mai", MySqlDbType.VarChar).Value = utilisateur
            aute.Parameters.Add("@md", MySqlDbType.VarChar).Value = mdp
            aute.ExecuteNonQuery()

            Dim mut As New MySqlCommand("UPDATE `livre` SET `date_retour_l`=@date,`reservation`='oui' WHERE `ID_L`= @idlivre ", cn)
            mut.Parameters.Add("@date", MySqlDbType.Date).Value = DateTimePicker1.Text
            mut.Parameters.Add("@idlivre", MySqlDbType.Int16).Value = id_l
            mut.ExecuteNonQuery()


        End If



        If RadioButton2.Checked Then
            Dim rap As New MySqlCommand("UPDATE `rapport` SET `reservation`='non' WHERE ID_RA=@idrrr ", cn)
            rap.Parameters.Add("@idrrr", MySqlDbType.Int16).Value = id_l_r
            rap.ExecuteNonQuery()

            Dim cah As New MySqlCommand("SELECT ID_RA FROM `rapport` WHERE `titre_RA`= @titre ", cn)
            cah.Parameters.Add("@titre", MySqlDbType.VarChar).Value = ComboBox2.Text

            cah.ExecuteNonQuery()
            datread = cah.ExecuteReader
            If datread.Read Then
                id_r = datread.GetValue(0)


            End If
            datread.Close()



            Dim aute As New MySqlCommand("UPDATE `adderent` SET `ID_RA`=@idra  WHERE `mail_A`= @mai and `mdp_A`= @md ", cn)
            aute.Parameters.Add("@idra", MySqlDbType.Int16).Value = id_r
            aute.Parameters.Add("@mai", MySqlDbType.VarChar).Value = utilisateur
            aute.Parameters.Add("@md", MySqlDbType.VarChar).Value = mdp
            aute.ExecuteNonQuery()



            Dim mut As New MySqlCommand("UPDATE `rapport` SET `date_retour_ra` = @date,`reservation`='oui' WHERE `ID_RA`= @idr ", cn)
            mut.Parameters.Add("@date", MySqlDbType.Date).Value = DateTimePicker1.Text
            mut.Parameters.Add("@idr", MySqlDbType.Int16).Value = id_r
            mut.ExecuteNonQuery()

        End If

        MsgBox("votre reservation est comfirmet")

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class
