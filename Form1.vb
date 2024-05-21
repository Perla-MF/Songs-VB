Public Class Form1
    Dim query As String
    Public SelectedArtist As String

    Public Sub LoadD()
        Try
            query = "SELECT * FROM VW_b"
            DataGVsongs.DataSource = Connection.SelectQuery(query)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub

    Public Sub LlenarArtista()
        query = "SELECT id, [Name] FROM Artist"
        cbArtist.DataSource = Connection.SelectQuery(query)
        cbArtist.DisplayMember = "Name"
        cbArtist.ValueMember = "id"
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "SELECT * FROM VW_b"
        DataGVsongs.DataSource = Connection.SelectQuery(query)
        LlenarArtista()
    End Sub

    Private Sub cbArtist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbArtist.SelectedIndexChanged
        SelectedArtist = cbArtist.Text
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        query = "SELECT * FROM VW_b WHERE [Artista] = '" & SelectedArtist.Replace("'", "''") & "'" 
        DataGVsongs.DataSource = Connection.SelectQuery(query)
    End Sub
End Class
