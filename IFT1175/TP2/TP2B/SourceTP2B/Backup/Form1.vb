Public Class Form1

    Dim WithEvents Ballon1 As clsBallon
    Dim MaColl As New Collection
    Dim MaColl2 As New Collection

    Private Sub Afficher()

    End Sub
    Private Sub DefBallon()

    End Sub
    Private Sub btnLancer_Click(ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles btnLancer.Click

    End Sub

    Private Sub btnSouffler_Click( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles btnSouffler1.Click

    End Sub


    Private Sub Ball1_Vol() Handles Ballon1.Vole

    End Sub

    Private Sub Ball1_Change(ByVal Vol As Short) Handles Ballon1.Change

    End Sub

    Private Sub Ball1_Chute() Handles Ballon1.Chute

    End Sub

    Private Sub Ball1_Éclate(ByVal DuréeVol As Integer) Handles Ballon1.Éclate

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, _
                ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub btnQuitter_Click(ByVal sender As System.Object, _
                ByVal e As System.EventArgs) Handles btnQuitter.Click

    End Sub
End Class