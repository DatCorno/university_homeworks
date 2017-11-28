Public Class Form1

	Private Class StockageBallon
		Public Property Title() As String
		Public Property Duree() As Integer

		Public Sub New(_title As String, _duree As Integer)
			Title = _title
			Duree = _duree
		End Sub
	End Class

	Dim WithEvents Ballon1 As clsBallon
    Dim MaColl As New Collection
	Dim MaColl2 As New Collection

	Dim ballon1_etat As String = "Au sol"

	Private Sub Afficher(current_vol As Integer)
		lblBallon1.Text = String.Format("{0}" + vbNewLine + "Entre {1} et {2}" + vbNewLine + "{3}", Ballon1.Titre, Ballon1.VolumneMin, Ballon1.VolumeMax, ballon1_etat)
		lblBallon1.BackColor = Ballon1.Couleur
		Aff1.Text = "Volume : " + current_vol.ToString()
	End Sub

	Private Sub DefBallon()

    End Sub
    Private Sub btnLancer_Click(ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles btnLancer.Click

		Dim title As String = InputBox("Titre du ballon")
		Dim min_vol As String = InputBox("Volume minimal du ballon", "", "20")
		Dim max_vol As String = InputBox("Volume maximal du ballon", "", "50")

		Dim min_vol_value As Integer
		Dim max_vol_value As Integer

		If Not Integer.TryParse(min_vol, min_vol_value) Or min_vol_value <= 0 Then
			min_vol_value = 20
		End If

		If Not Integer.TryParse(max_vol, max_vol_value) Or max_vol_value < min_vol_value Then
			max_vol_value = min_vol_value + 20
		End If

		If Ballon1 Is Nothing Then
			Ballon1 = New clsBallon(min_vol_value, max_vol_value)
			Ballon1.Titre = title
			Ballon1.Couleur = If(lstCouleurs.SelectedItem Is Nothing, Color.Blue, GetColorFromName(lstCouleurs.SelectedItem))
			Afficher(0)
		End If

		Timer1.Interval = 3000
		Timer1.Start()

		btnSouffler1.Enabled = True
	End Sub

	Private Sub btnSouffler_Click(
			ByVal sender As System.Object,
			ByVal e As System.EventArgs) _
			Handles btnSouffler1.Click

		Ballon1.Gonfler(scrQuant1.Value)

	End Sub

	Private Sub Ball1_Vol() Handles Ballon1.Vole
		ballon1_etat = "En vol"
	End Sub

	Private Sub Ball1_Change(ByVal Vol As Short) Handles Ballon1.Change
		Afficher(Vol)
	End Sub

    Private Sub Ball1_Chute() Handles Ballon1.Chute
		ballon1_etat = "Au sol"
	End Sub

	Private Sub Ball1_Éclate(ByVal DuréeVol As Integer) Handles Ballon1.Éclate
		ballon1_etat = "BOOM!"
		Afficher(Ballon1.VolumeMax)

		MaColl.Add(New StockageBallon(Ballon1.Titre, DuréeVol))

		btnSouffler1.Enabled = False
		Ballon1 = Nothing
	End Sub

	Private Sub Timer1_Tick(ByVal sender As System.Object,
				ByVal e As System.EventArgs) Handles Timer1.Tick

		If Ballon1 IsNot Nothing Then
			Ballon1.Perte()
		End If
	End Sub

	Private Sub btnQuitter_Click(ByVal sender As System.Object,
				ByVal e As System.EventArgs) Handles btnQuitter.Click
		SortCollection()

		If MaColl.Count = 0 Then
			txtResult.Text = "Aucun résultat"
		Else
			txtResult.Text = ""
			For Each obj As StockageBallon In MaColl
				txtResult.Text = txtResult.Text + String.Format("Le ballon {0} a duré {1} secondes" + vbNewLine, obj.Title, obj.Duree)
			Next
		End If

		txtResult.Visible = True

		If MessageBox.Show("Appuyez sur OK pour quitter", "", MessageBoxButtons.OK) = DialogResult.OK Then
			Me.Close()
		End If
	End Sub

	Private Function GetColorFromName(name As String) As Color
		If name.ToUpper() = "ROUGE" Then
			Return Color.Red
		ElseIf name.ToUpper() = "BLEU" Then
			Return Color.Blue
		ElseIf name.ToUpper() = "JAUNE" Then
			Return Color.Yellow
		ElseIf name.ToUpper() = "VERT" Then
			Return Color.Green
		Else
			Return Nothing
		End If
	End Function

	Private Sub SortCollection()
		For i As Integer = 1 To MaColl.Count - 1
			For j As Integer = i + 1 To MaColl.Count
				If MaColl(i).Duree > MaColl(j).Duree Then
					Dim _stockage As StockageBallon = MaColl(j)
					MaColl.Remove(j)
					MaColl.Add(_stockage, Nothing, i)
				End If
			Next
		Next
	End Sub
End Class