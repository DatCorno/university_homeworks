Public Class clsBallon
	Public Titre As String
	Private EnVol As Boolean = False
	Private TempsDep As New DateTime
	Private TempsEclate As New DateTime
	Private Duree As New TimeSpan

	Private mCouleur As Color
	Public Property Couleur() As Color
		Get
			Return mCouleur
		End Get
		Set(ByVal value As Color)
			'V�rifie que la couleur est valide
			If value <> Color.Blue And value <> Color.Red And value <> Color.Green And value <> Color.Yellow Then
				Exit Property
			End If

			mCouleur = value
		End Set
	End Property

	Public Event �clate(ByVal NbSecondes As Integer)
	Public Event Vole()
	Public Event Chute()
	Public Event Change(ByVal Vol As Short)

	Private mVolume_Min As Integer = 0
	Public ReadOnly Property VolumneMin() As Integer
		Get
			Return mVolume_Min
		End Get
	End Property

	Private varVolume As Integer = 0

	Private mVolume_Max As Integer = 0
	Public ReadOnly Property VolumeMax() As Integer
		Get
			Return mVolume_Max
		End Get
	End Property

	Public Sub New(min_vol As Integer, max_vol As Integer)
		'Si on d�passe le volume maximum alors, r�ajuster
		If max_vol > 1000 Then
			max_vol = 1000
		End If

		TempsDep = Date.Now 'Initialiser le temps de d�part du ballon
		mVolume_Max = max_vol
		mVolume_Min = min_vol
	End Sub

	Public Sub Gonfler(ByVal Valeur As Short)
		'On augmente le volume par la valeur pass�e en param�tre
		varVolume = varVolume + Valeur

		'Lorsque le volume d�passe le volume minimum pour voler, lever l'�v�nement Vole
		If varVolume >= mVolume_Min Then
			RaiseEvent Vole()
		End If

		'Lorsque le volume d�passe le volume maximum, le ballon �clate, donc il faut sauvegarder la date de ce moment, calculer
		'la dur�e du vol et lever l'�v�nement �clate
		If varVolume > mVolume_Max Then
			TempsEclate = Date.Now
			Duree = TempsEclate - TempsDep
			RaiseEvent �clate(Duree.Seconds)
		End If

		'Le volume a chang�, lever l'�v�nement Change
		RaiseEvent Change(varVolume)

	End Sub

	Public Sub Perte()
		'D�crementer le volume actuel
		varVolume = varVolume - 1

		'S'il devient n�gatif, r�ajuster � z�ro
		If varVolume < 0 Then
			varVolume = 0
		End If

		'Lorsqu'il descend en bas du volume minimum pour voler il faut lever l'�v�nement Chute
		If varVolume < mVolume_Min Then
			RaiseEvent Chute()
		End If

		'Le volume a chang�, lever l'�v�nement Change
		RaiseEvent Change(varVolume)
	End Sub
End Class
