Public Class Analyseur
	Public Overloads Property Sorted() As Boolean
		Get
			Return MyBase.Sorted
		End Get
		Set(value As Boolean)
			MyBase.Sorted = True
		End Set
	End Property

	Public Event AnalyseFaite()

	Private Sub Analyseur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
		Dim mot As String
		Dim mots_decortiques As New Collection

		If Asc(e.KeyChar) = Keys.Return Then
			MyBase.Items.Clear()
			subAnalyser(MyBase.Text, mots_decortiques)

			For Each mot In mots_decortiques
				MyBase.Items.Add(mot.ToLower())
			Next

			RaiseEvent AnalyseFaite()
			mots_decortiques = Nothing
			e.Handled = True
		End If
	End Sub

	Public Sub Analyser()
		Dim stMot As String, MaColl As Collection = New Collection
		MyBase.Items.Clear()             ' On vide la liste
		subAnalyser(MyBase.Text, MaColl)

		' On place les mots de la collection dans le combobox
		For Each stMot In MaColl
			MyBase.Items.Add(stMot.ToLower)
		Next
		RaiseEvent AnalyseFaite()

		MaColl = Nothing
	End Sub

	Private Sub subAnalyser(ByVal LeTexte As String,
						   ByVal UneColl As Collection)
		Dim stMot As String
		'On vide la liste des mots
		For Each stMot In UneColl
			UneColl.Remove(1)
		Next
		'    On extrait un mot de la chaîne «LeTexte»
		'    jusqu'à ce que il soit vide.
		Do While LeTexte <> ""
			Extraire(LeTexte, stMot)
			If stMot <> "" Then
				UneColl.Add(stMot)
			End If
		Loop
	End Sub

	Private Sub Extraire(ByRef untexte As String, ByRef UnMot As String)
		Dim UnCar As Char
		UnMot = ""

		'Si UnTexte est vide, on place une chaine vide dans
		'UnMot et on sort de la fonction.
		If untexte = "" Then
			Exit Sub
		End If

		'On écarte tout caractère qui n'est pas une lettre
		Do While untexte.Length > 0 ' (non vide)
			UnCar = untexte.Substring(0, 1) ' premier caract.
			If SiLettre(UnCar) Then
				Exit Do 'on arrête
			Else ' n'est pas une lettre : on écarte
				' On supprime le premier caractère du texte
				untexte = untexte.Substring(1)
			End If
		Loop
		' UnTexte commence par une lettre
		' On copie les lettres successives dans UnMot
		Do While untexte.Length > 0 ' (non vide)
			UnCar = untexte.Substring(0, 1) ' premier caract.
			untexte = untexte.Substring(1)
			If SiLettre(UnCar) Then
				UnMot = UnMot & UnCar
			Else ' n'est pas une lettre : on écarte
				' On supprime le premier caractère du texte
				Exit Do
			End If
		Loop

	End Sub


	Private Function SiLettre(ByVal unKar As Char) As Boolean
		'On détermine si le caractère analysé
		'a un code Ascii entre le "a" et le "z"
		If Char.ToUpper(unKar) >= "A" And
		 Char.ToUpper(unKar) <= "Z" Then Return True
		'On vérifie pour les caractères accentués
		Select Case unKar
			Case "à", "À", "â", "Â"
				Return True
			Case "ç", "Ç"
				Return True
			Case "è", "È", "ê", "Ê", "é", "É"
				Return True
			Case "î", "Î"
				Return True
			Case "ô", "Ô"
				Return True
			Case "ù", "Ù", "û", "Û"
				Return True
		End Select
		' Sinon ...
		Return False
	End Function

End Class
