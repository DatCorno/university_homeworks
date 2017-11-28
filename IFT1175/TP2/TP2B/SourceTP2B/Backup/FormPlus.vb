Public Class FormPlus
    Dim WithEvents Ballon1, Ballon2, Ballon3 As clsBallon
    Dim MaColl As New Collection
    Dim MaColl2 As New Collection

    Private Sub Afficher(ByRef UnLabel As Label, _
                ByRef UnBallon As clsBallon, _
                ByVal UnStatut As String)

    End Sub
    Private Sub DefBallon(ByRef UnBallon As clsBallon, _
                ByRef UnLabel As Label, _
                ByRef UnBouton As Button)

    End Sub
    Private Sub btnLancer_Click(ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles btnLancer.Click

    End Sub

    Private Sub btnSouffler_Click( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles btnSouffler1.Click, btnSouffler2.Click, btnSouffler3.Click

    End Sub


    Private Sub Ball1_Vol() Handles Ballon1.Vole

    End Sub

    Private Sub Ball1_Change(ByVal Vol As Short) Handles Ballon1.Change

    End Sub

    Private Sub Ball1_Chute() Handles Ballon1.Chute

    End Sub

    Private Sub Ball1_Éclate(ByVal DuréeVol As Integer) Handles Ballon1.Éclate

    End Sub
    Private Sub Ball2_Vole() Handles Ballon2.Vole

    End Sub

    Private Sub Ball2_Change(ByVal Vol As Short) Handles Ballon2.Change

    End Sub

    Private Sub Ball2_Chute() Handles Ballon2.Chute

    End Sub

    Private Sub Ball2_Éclate(ByVal DuréeVol As Integer) Handles Ballon2.Éclate

    End Sub
    Private Sub Ball3_Vole() Handles Ballon3.Vole

    End Sub

    Private Sub Ball3_Change(ByVal Vol As Short) Handles Ballon3.Change

    End Sub

    Private Sub Ball3_Chute() Handles Ballon3.Chute

    End Sub

    Private Sub Ball3_Éclate(ByVal DuréeVol As Integer) Handles Ballon3.Éclate

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub btnQuitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitter.Click

    End Sub
End Class