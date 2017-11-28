

Public Class clsBallon
    Public Titre As String
    Private EnVol As Boolean = False
    Private TempsDep As New DateTime
    Private TempsEclate As New DateTime
    Private Duree As New TimeSpan
    Private mCouleur As String
    Public Event Éclate(ByVal NbSecondes As Integer)
    Public Event Vole()
    Public Event Chute()
    Public Event Change(ByVal Vol As Short)



    Private mVolume_Min As Integer = 0




    Private mVolume_Max As Integer = 0



    Public Sub Gonfler(ByVal Valeur As Short)

    End Sub



    Public Sub Perte()

    End Sub
End Class
