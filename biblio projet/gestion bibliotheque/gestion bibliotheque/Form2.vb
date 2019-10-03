Imports MySql.Data.MySqlClient

Public Class Form2
    Dim daterapp As Date
    Dim dateliv As Date
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not Panel2.Controls.Contains(livre.instance) Then
            Panel2.Controls.Add(livre.instance)
            livre.instance.Dock = DockStyle.Fill
            livre.instance.BringToFront()
            livre.instance.Visible = True

        End If
        livre.instance.BringToFront()
        livre.instance.Visible = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not Panel2.Controls.Contains(rapport.instance) Then
            Panel2.Controls.Add(rapport.instance)
            rapport.instance.Dock = DockStyle.Fill
            rapport.instance.BringToFront()
            rapport.instance.Visible = True

        End If
        rapport.instance.BringToFront()
        rapport.instance.Visible = True

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Not Panel2.Controls.Contains(reservation.instance) Then
            Panel2.Controls.Add(reservation.instance)
            reservation.instance.Dock = DockStyle.Fill
            reservation.instance.BringToFront()
            reservation.instance.Visible = True

        End If
        reservation.instance.BringToFront()
        reservation.instance.Visible = True



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Not Panel2.Controls.Contains(ma_reservation.instance) Then
            Panel2.Controls.Add(ma_reservation.instance)
            ma_reservation.instance.Dock = DockStyle.Fill
            ma_reservation.instance.BringToFront()
            ma_reservation.instance.Visible = True

        End If
        ma_reservation.instance.BringToFront()
        ma_reservation.instance.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MsgBox("votre reservation est expire")


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button7.Hide()
        Button1.PerformClick()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cn As New MySqlConnection
        Dim datread As MySqlDataReader

        Dim id_ra As Integer
        Dim id_L As Integer

        Dim titreliv As String
        Dim titrerap As String



        Dim testliv As String
        Dim testrap As String

        Button7.Hide()

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
        datread.Close()

        Dim rdv As New MySqlCommand("SELECT * FROM `livre` WHERE `ID_L`= @idl ", cn)
        rdv.Parameters.Add("@idl", MySqlDbType.Int16).Value = id_L
        rdv.ExecuteNonQuery()
        datread = rdv.ExecuteReader
        If datread.Read Then

            dateliv = datread.GetValue(7)
            testliv = datread.GetValue(6)
            titreliv = datread.GetValue(2)



        End If
        datread.Close()

        Dim rd As New MySqlCommand("SELECT * FROM `rapport` WHERE `ID_RA`= @idr ", cn)
        rd.Parameters.Add("@idr", MySqlDbType.Int16).Value = id_ra
        rd.ExecuteNonQuery()
        datread = rd.ExecuteReader
        If datread.Read Then

            testrap = datread.GetValue(4)
            daterapp = datread.GetValue(5)
            titrerap = datread.GetValue(1)

        End If
        datread.Close()
        Dim today = Date.Now

        If today > daterapp And testrap = "oui" Then
            Button7.Show()
            MsgBox("votre reservation de rapport " & titrerap & "a  expire")
        End If

        If today > dateliv And testliv = "oui" Then
            Button7.Show()
            MsgBox("votre reservation de livre" & titreliv & " a  expire")
        End If

        ' MsgBox(dateliv & " " & daterapp)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub
End Class