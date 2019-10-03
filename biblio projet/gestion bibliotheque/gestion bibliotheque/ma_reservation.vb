Imports MySql.Data.MySqlClient

Public Class ma_reservation
    Dim cn As New MySqlConnection
    Dim id_L As Integer
    Dim id_ra As Integer
    Dim datread As MySqlDataReader

    Dim utilisateur As String
    Dim mdp As String

    Dim testliv As String
    Dim testrap As String

    Private Shared _instance As ma_reservation
    Public Shared ReadOnly Property instance As ma_reservation

        Get
            If _instance Is Nothing Then
                _instance = New ma_reservation
            End If
            Return _instance
        End Get
    End Property


    Private Sub ma_reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New MySqlConnection
        cn.ConnectionString = "server= localhost;userid=root;password=;database=projet_bibliotheque"
        cn.Open()


        Dim rdvv As New MySqlCommand("SELECT * FROM `adderent` WHERE `mail_A`= @mai and `mdp_A`= @md ", cn)
        rdvv.Parameters.Add("@mai", MySqlDbType.VarChar).Value = Form1.TextBox1.Text
        rdvv.Parameters.Add("@md", MySqlDbType.VarChar).Value = Form1.TextBox2.Text
        rdvv.ExecuteNonQuery()
        datread = rdvv.ExecuteReader
        If datread.Read Then
            id_L = datread.GetValue(6)
            id_ra = datread.GetValue(7)

        End If
        MsgBox(id_L & " " & id_ra)

        datread.Close()


        Dim rdv As New MySqlCommand("SELECT * FROM `livre` WHERE `ID_L`= @idl ", cn)
        rdv.Parameters.Add("@idl", MySqlDbType.Int16).Value = id_L
        rdv.ExecuteNonQuery()
        datread = rdv.ExecuteReader
        If datread.Read Then
            If datread.GetValue(6) = "oui" Then
                TextBox1.Text = datread.GetValue(2)
                TextBox2.Text = datread.GetValue(7)
            Else
                TextBox1.Clear()
                TextBox2.Clear()
                MsgBox("vous avez aucun reservation de livre  ")
            End If

        End If

        datread.Close()


        Dim rd As New MySqlCommand("SELECT * FROM `rapport` WHERE `ID_RA`= @idr ", cn)
        rd.Parameters.Add("@idr", MySqlDbType.Int16).Value = id_ra
        rd.ExecuteNonQuery()
        datread = rd.ExecuteReader
        If datread.Read Then
            If datread.GetValue(4) = "oui" Then
                TextBox3.Text = datread.GetValue(1)
                TextBox4.Text = datread.GetValue(5)

            Else
                TextBox3.Clear()
                TextBox4.Clear()
                MsgBox("vous avez aucun reservation de rapport  ")
            End If
        End If


        datread.Close()

        If testliv = "non" Then


        End If

        If testrap = "non" Then


        End If


    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim rdvv As New MySqlCommand("SELECT * FROM `adderent` WHERE `mail_A`= @mai and `mdp_A`= @md ", cn)
        rdvv.Parameters.Add("@mai", MySqlDbType.VarChar).Value = Form1.TextBox1.Text
        rdvv.Parameters.Add("@md", MySqlDbType.VarChar).Value = Form1.TextBox2.Text
        rdvv.ExecuteNonQuery()
        datread = rdvv.ExecuteReader
        If datread.Read Then
            id_L = datread.GetValue(6)
            id_ra = datread.GetValue(7)

        End If
        ' MsgBox(id_L & " " & id_ra)

        datread.Close()


        Dim rdv As New MySqlCommand("SELECT * FROM `livre` WHERE `ID_L`= @idl ", cn)
        rdv.Parameters.Add("@idl", MySqlDbType.Int16).Value = id_L
        rdv.ExecuteNonQuery()
        datread = rdv.ExecuteReader
        If datread.Read Then
            If datread.GetValue(6) = "oui" Then
                TextBox1.Text = datread.GetValue(2)
                TextBox2.Text = datread.GetValue(7)
            Else
                TextBox1.Clear()
                TextBox2.Clear()
                MsgBox("vous avez aucun reservation de livre  ")
            End If

        End If

            datread.Close()


        Dim rd As New MySqlCommand("SELECT * FROM `rapport` WHERE `ID_RA`= @idr ", cn)
        rd.Parameters.Add("@idr", MySqlDbType.Int16).Value = id_ra
        rd.ExecuteNonQuery()
        datread = rd.ExecuteReader
        If datread.Read Then
            If datread.GetValue(4) = "oui" Then
                TextBox3.Text = datread.GetValue(1)
                TextBox4.Text = datread.GetValue(5)
            Else
                TextBox3.Clear()
                TextBox4.Clear()
                MsgBox("vous avez aucun reservation de rapport  ")
            End If
        End If
            datread.Close()




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Dim liv As New MySqlCommand("UPDATE `livre` SET `reservation`='non' WHERE `ID_L`=@idliii", cn)
        liv.Parameters.Add("@idliii", MySqlDbType.Int16).Value = id_L
        liv.ExecuteNonQuery()

        If testliv = "non" Then
            TextBox1.Clear()
            TextBox2.Clear()
            MsgBox("vous avez aucun reservation de livre  ")

        End If





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim rap As New MySqlCommand("UPDATE `rapport` SET `reservation`='non' WHERE ID_RA=@idrrr ", cn)
        rap.Parameters.Add("@idrrr", MySqlDbType.Int16).Value = id_ra
        rap.ExecuteNonQuery()


        If testrap = "non" Then
            TextBox3.Clear()
            TextBox4.Clear()
            MsgBox("vous avez aucun reservation de rapport  ")

        End If

    End Sub
End Class
