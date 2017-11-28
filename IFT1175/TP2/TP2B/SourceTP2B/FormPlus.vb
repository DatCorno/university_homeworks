Public Class FormPlus
    Dim WithEvents Ballon1, Ballon2, Ballon3 As clsBallon
    Dim MaColl As New Collection
	Dim MaColl2 As New Collection

	'Variables indiquant l'�tat actuel de chaque ballon
	Dim ballon1_etat As String = "Au sol"
	Dim ballon2_etat As String = "Au sol"
	Dim ballon3_etat As String = "Au sol"

	'Stocke des donn�es relatives aux r�sultats des ballons pour pouvoir cr�er une collection qui peut �tre ordonn�e
	'facilement et affich�e tout aussi facilement
	Private Class StockageBallon
		Public Property Title() As String
		Public Property Duree() As Integer

		Public Sub New(_title As String, _duree As Integer)
			Title = _title
			Duree = _duree
		End Sub
	End Class

	'Change le texte du label pass� en param�tre pour une nouvelle cha�ne contenant le titre du ballon,
	'son volume minimum et maximum et son �tat actuel. Puis change le texte du label de volume pass� en param�tre
	'par le volume pass� en param�tre
	Private Sub Afficher(ByRef UnLabel As Label,
				ByRef UnBallon As clsBallon,
				ByVal UnStatut As String,
						 UnVolume As Integer,
						 UnLabelVolume As Label)
		UnLabel.Text = String.Format("{0}" + vbNewLine + "Entre {1} et {2}" + vbNewLine + "{3}", UnBallon.Titre, UnBallon.VolumneMin, UnBallon.VolumeMax, UnStatut)
		UnLabel.BackColor = UnBallon.Couleur

		UnLabelVolume.Text = "Volume : " + UnVolume.ToString()
	End Sub

	Private Sub DefBallon(ByRef UnBallon As clsBallon, _
                ByRef UnLabel As Label, _
                ByRef UnBouton As Button)

    End Sub
	Private Sub btnLancer_Click(ByVal sender As System.Object,
			ByVal e As System.EventArgs) _
			Handles btnLancer.Click

		'R�cup�re un titre, un volume minimal et un volume maximal
		Dim title As String = InputBox("Titre du ballon")
		Dim min_vol As String = InputBox("Volume minimal du ballon", "", "20")
		Dim max_vol As String = InputBox("Volume maximal du ballon", "", "50")

		Dim min_vol_value As Integer
		Dim max_vol_value As Integer

		'S'assure que les donn�es sont valides, sinon assigne des valeurs par d�faut au minimum et maximum
		If Not Integer.TryParse(min_vol, min_vol_value) Or min_vol_value <= 0 Then
			min_vol_value = 20
		End If

		If Not Integer.TryParse(max_vol, max_vol_value) Or max_vol_value < min_vol_value Then
			max_vol_value = min_vol_value + 20
		End If

		'Si le Ballon1 est pr�sentement null alors on cr�e un nouvea ballon � son emplacement
		'De m�me pour ballon2 et ballon3
		If Ballon1 Is Nothing Then
			Ballon1 = New clsBallon(min_vol_value, max_vol_value)
			Ballon1.Titre = title
			Ballon1.Couleur = If(lstCouleurs.SelectedItem Is Nothing, Color.Blue, GetColorFromName(lstCouleurs.SelectedItem))
			Afficher(lblBallon1, Ballon1, ballon1_etat, 0, Aff1)
			btnSouffler1.Enabled = True
		ElseIf Ballon2 Is Nothing Then
			Ballon2 = New clsBallon(min_vol_value, max_vol_value)
			Ballon2.Titre = title
			Ballon2.Couleur = If(lstCouleurs.SelectedItem Is Nothing, Color.Blue, GetColorFromName(lstCouleurs.SelectedItem))
			Afficher(lblBallon2, Ballon2, ballon2_etat, 0, Aff2)
			btnSouffler2.Enabled = True
		ElseIf Ballon3 Is Nothing Then
			Ballon3 = New clsBallon(min_vol_value, max_vol_value)
			Ballon3.Titre = title
			Ballon3.Couleur = If(lstCouleurs.SelectedItem Is Nothing, Color.Blue, GetColorFromName(lstCouleurs.SelectedItem))
			Afficher(lblBallon3, Ballon3, ballon3_etat, 0, Aff2)
			btnSouffler3.Enabled = True
		End If

		'On change l'interval du timer pour 3 secondes et on le lance
		Timer1.Interval = 3000
		Timer1.Start()

	End Sub

	Private Sub btnSouffler_Click( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) _
            Handles btnSouffler1.Click, btnSouffler2.Click, btnSouffler3.Click

		'On r�cup�re le bouton qui a lanc� l'�v�nement
		Dim bouton As Button = CType(sender, Button)

		'Si le bouton est du ballon1 et qu'il existe un ballon1, on gonfle le ballon1
		'De m�me pour le ballon2 et ballon3
		If bouton.Name = btnSouffler1.Name AndAlso Ballon1 IsNot Nothing Then
			Ballon1.Gonfler(scrQuant1.Value)

		ElseIf bouton.Name = btnSouffler2.Name AndAlso Ballon2 IsNot Nothing Then
			Ballon2.Gonfler(scrQuant2.Value)

		ElseIf bouton.Name = btnSouffler3.Name AndAlso Ballon3 IsNot Nothing Then
			Ballon3.Gonfler(scrQuant3.Value)
		End If
	End Sub

	'Ces fonctions changents les �tats des ballons selon les �v�nements re�us
	Private Sub Ball1_Vol() Handles Ballon1.Vole
		ballon1_etat = "En vol"
	End Sub

	Private Sub Ball1_Change(ByVal Vol As Short) Handles Ballon1.Change
		Afficher(lblBallon1, Ballon1, ballon1_etat, Vol, Aff1)
	End Sub

	Private Sub Ball1_Chute() Handles Ballon1.Chute
		ballon1_etat = "Au sol"
	End Sub

	'Lorsqu'un ballon �clate, on change son �tat puis on ajoute ses 'statistiques' de dur�e et son titre, puis on l'ajoute
	'� la collection et on le supprime
	Private Sub Ball1_�clate(ByVal Dur�eVol As Integer) Handles Ballon1.�clate
		ballon1_etat = "BOOM!"
		Afficher(lblBallon1, Ballon1, ballon1_etat, Ballon1.VolumeMax, Aff1)

		MaColl.Add(New StockageBallon(Ballon1.Titre, Dur�eVol))

		btnSouffler1.Enabled = False
		Ballon1 = Nothing
	End Sub

	Private Sub Ball2_Vol() Handles Ballon2.Vole
		ballon2_etat = "En vol"
	End Sub

	Private Sub Ball2_Change(ByVal Vol As Short) Handles Ballon2.Change
		Afficher(lblBallon2, Ballon2, ballon2_etat, Vol, Aff2)
	End Sub

	Private Sub Ball2_Chute() Handles Ballon2.Chute
		ballon2_etat = "Au sol"
	End Sub

	Private Sub Ball2_�clate(ByVal Dur�eVol As Integer) Handles Ballon2.�clate
		ballon2_etat = "BOOM!"
		Afficher(lblBallon2, Ballon2, ballon2_etat, Ballon2.VolumeMax, Aff2)

		MaColl.Add(New StockageBallon(Ballon2.Titre, Dur�eVol))

		btnSouffler2.Enabled = False
		Ballon2 = Nothing
	End Sub

	Private Sub Ball3_Vol() Handles Ballon3.Vole
		ballon3_etat = "En vol"
	End Sub

	Private Sub Ball3_Change(ByVal Vol As Short) Handles Ballon3.Change
		Afficher(lblBallon3, Ballon3, ballon3_etat, Vol, Aff3)
	End Sub

	Private Sub Ball3_Chute() Handles Ballon3.Chute
		ballon3_etat = "Au sol"
	End Sub

	Private Sub Ball3_�clate(ByVal Dur�eVol As Integer) Handles Ballon3.�clate
		ballon3_etat = "BOOM!"
		Afficher(lblBallon3, Ballon3, ballon3_etat, Ballon3.VolumeMax, Aff3)

		MaColl.Add(New StockageBallon(Ballon3.Titre, Dur�eVol))

		btnSouffler3.Enabled = False
		Ballon1 = Nothing
	End Sub

	'Pour chaque ballon existant on appelle la fonction Perte
	Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
		If Ballon1 IsNot Nothing Then
			Ballon1.Perte()
		ElseIf Ballon2 IsNot Nothing Then
			Ballon2.Perte()
		ElseIf Ballon3 IsNot Nothing Then
			Ballon3.Perte()
		End If
	End Sub

	Private Sub btnQuitter_Click(ByVal sender As System.Object,
				ByVal e As System.EventArgs) Handles btnQuitter.Click
		'On ordonne la collection contenant les 'statistiques' des ballons
		SortCollection()

		'S'il n'y a aucun ballon dans la collection, on affiche "Aucun r�sultat"
		If MaColl.Count = 0 Then
			txtResult.Text = "Aucun r�sultat"
		Else
			'Sinon on boucle sur la collection ordonn�e et on affiche les statistiques de chaque ballon
			txtResult.Text = ""
			For Each obj As StockageBallon In MaColl
				txtResult.Text = txtResult.Text + String.Format("Le ballon {0} a dur� {1} secondes" + vbNewLine, obj.Title, obj.Duree)
			Next
		End If

		txtResult.Visible = True

		If MessageBox.Show("Appuyez sur OK pour quitter", "", MessageBoxButtons.OK) = DialogResult.OK Then
			Me.Close()
		End If
	End Sub

	'Retourne un objet Color selon le nom pass�
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

	'Ordonne la collection "MaColl"
	Private Sub SortCollection()
		For i As Integer = 1 To MaColl.Count - 1 ' Puisque les collections commencent � l'index 1 on boucle du premier �l�ment � l'avant dernier
			For j As Integer = i + 1 To MaColl.Count ' Puis on boucle de l'�l�ment imm�diatement apr�s jusqu'au dernier �l�ment
				If MaColl(i).Duree < MaColl(j).Duree Then 'Si la dur�e du premier �l�ment est inf�rieur � celle du deuxi�me �l�ment, on �change leur place
					Dim _stockage As StockageBallon = MaColl(j) 'Donc tous les �l�ments les plus longs sont au d�but de la collection
					MaColl.Remove(j)
					MaColl.Add(_stockage, Nothing, i)
				End If
			Next
		Next
	End Sub
End Class