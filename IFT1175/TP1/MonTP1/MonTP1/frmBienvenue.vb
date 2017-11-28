'
' Travail fait par François Corneau-Tremblay
' Les lignes commençant par ' sont des commentaires
'''' Les lignes commençant par '''' sont des commandes à compléter
Option Explicit On
Imports System.IO

Public Class frmBienvenue

	Private Sub frmBienvenue_Load(
			ByVal eventSender As System.Object,
			ByVal eventArgs As System.EventArgs) _
			Handles MyBase.Load

		'Fichier à ouvrir et flux de le lecture pour ce fichier
		Dim UnFich As FileStream
		Dim UnLecteur As StreamReader
		UnFich = New FileStream("EmplTP1.dta", FileMode.OpenOrCreate)
		UnLecteur = New StreamReader(UnFich)
		NbEmpl = 0

		'Peek retourne -1 si il ne reste plus rien à faire. Il faut donc exécuter la boucle jusqu'à ce que Peek nous retourne cette valeur
		'De plus, le tableau des employés est de taille statique alors il faut s'assurer que le nombre d'employé lu
		'ne dépasse pas la taille du tableau. Et puisque les tableaux commencent à l'index 0, l'accès mémoire tableau(tableau.Count) est 
		'invalide, il faut donc prendre la valeur juste avant
		Do While UnLecteur.Peek <> -1 Or NbEmpl = gEmployes.Count - 1
			NbEmpl += 1
			With gEmployes(NbEmpl)
				.Nom = UnLecteur.ReadLine()
				.Numero = UnLecteur.ReadLine()
				.Telephone = UnLecteur.ReadLine()
				.Poste = UnLecteur.ReadLine()
				.NumPatron = UnLecteur.ReadLine()
				.DateEmbauche = CDate(UnLecteur.ReadLine())
				.Salaire = UnLecteur.ReadLine()
				.SiComm = UnLecteur.ReadLine()
				.MtCommission = UnLecteur.ReadLine()
				.NumDepartement = UnLecteur.ReadLine()
			End With
		Loop
		' On ferme le fichier
		UnLecteur.Close()
		UnFich = Nothing

		' On doit s'assurer ici que le label «lblMess» est invisible
		lblMess.Visible = False
	End Sub


	Private Sub tmrMotDePasse_Tick( _
            ByVal eventSender As System.Object, _
            ByVal eventArgs As System.EventArgs) _
            Handles tmrMotDePasse.Tick

		'On «débranche» les horloges pour interrompre les
		' les appels aux deux procédures
		tmrMessage.Enabled = False
		tmrMotDePasse.Enabled = False
		' On se cache : me.hide
		Me.Hide()
		'On affiche la nouvelle feuille ...
		frmEmploye.Enabled = True
		frmEmploye.ShowDialog()
	End Sub

	Private Sub tmrMessage_Tick( _
            ByVal eventSender As System.Object, _
            ByVal eventArgs As System.EventArgs) _
            Handles tmrMessage.Tick

		' On fait «clignoter» le label «lblMess»
		' en basculant sa propriété «Visible»
		' à l'inverse de sa valeur courante
		lblMess.Visible = Not lblMess.Visible
	End Sub

	Private Sub txtMotDePasse_TextChanged(
			ByVal eventSender As System.Object,
			ByVal eventArgs As System.EventArgs) _
			Handles txtMotDePasse.TextChanged

		' À chaque nouvelle valeur du contrôle, on vérifie si
		' le mot entré jusqu'ici est «Bidule» ou «Commun»        
		If txtMotDePasse.Text.ToUpper = "BIDULE" Or
		   txtMotDePasse.Text.ToUpper = "COMMUN" Then

			' On détermine les intervalles (4  sec. et 0,4 sec)
			' en millisecondes
			tmrMotDePasse.Interval = 4400
			tmrMessage.Interval = 400

			'On lance les minuteries
			tmrMotDePasse.Start()
			tmrMessage.Start()

			' Puis on détermine si «gPermis» doit être
			' mis à True ou à False
			'Par défaut gPermis est False
			gPermis = False
			If txtMotDePasse.Text.ToUpper = "BIDULE" Then
				'Par contre, si le mot depasse est "BIDULE" il passe à True
				gPermis = True
			End If

		End If
	End Sub
End Class