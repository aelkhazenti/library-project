Imports MySql.Data.MySqlClient

Public Class rapport
    Dim cn As New MySqlConnection

    Dim datread As MySqlDataReader
    Private Shared _instance As rapport
    Public Shared ReadOnly Property instance As rapport

        Get
            If _instance Is Nothing Then
                _instance = New rapport
            End If
            Return _instance
        End Get
    End Property

    Private Sub rapport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New MySqlConnection
        cn.ConnectionString = "server= localhost;userid=root;password=;database=projet_bibliotheque"
        cn.Open()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rapp As New MySqlCommand("INSERT INTO `rapport`(`titre_RA`, `anne_RA`, `type_RA`,`reservation`) VALUES (@tit,@ann,@typ,@res)", cn)
        rapp.Parameters.Add("@tit", MySqlDbType.VarChar).Value = TextBox2.Text
        rapp.Parameters.Add("@ann", MySqlDbType.Int16).Value = TextBox3.Text
        rapp.Parameters.Add("@typ", MySqlDbType.VarChar).Value = ComboBox1.Text
        rapp.Parameters.Add("@res", MySqlDbType.VarChar).Value = "non"
        rapp.ExecuteNonQuery()

        MsgBox("vous avez ajouté votre livre avec succès ")

        TextBox2.Clear()
        TextBox3.Clear()
    End Sub
End Class
