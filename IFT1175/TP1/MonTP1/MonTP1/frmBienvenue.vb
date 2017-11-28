'
' Travail fait par Fran�ois Corneau-Tremblay
' Les lignes commen�ant par ' sont des commentaires
'''' Les lignes commen�ant par '''' sont des commandes � compl�ter
Option Explicit On
Imports System.IO

Public Class frmBienvenue

	Private Sub frmBienvenue_Load(
			ByVal eventSender As System.Object,
			ByVal eventArgs As System.EventArgs) _
			Handles MyBase.Load

		'Fichier � ouvrir et flux de le lecture pour ce fichier
		Dim UnFich As FileStream
		Dim UnLecteur As StreamReader
		UnFich = New FileStream("EmplTP1.dta", FileMode.OpenOrCreate)
		UnLecteur = New StreamReader(UnFich)
		NbEmpl = 0

		'Peek retourne -1 si il ne reste plus rien � faire. Il faut donc ex�cuter la boucle jusqu'� ce que Peek nous retourne cette valeur
		'De plus, le tableau des employ�s est de taille statique alors il faut s'assurer que le nombre d'employ� lu
		'ne d�passe pas la taille du tableau. Et puisque les tableaux commencent � l'index 0, l'acc�s m�moire tableau(tableau.Count) est 
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

		' On doit s'assurer ici que le label �lblMess� est invisible
		lblMess.Visible = False
	End Sub


	Private Sub tmrMotDePasse_Tick( _
            ByVal eventSender As System.Object, _
            ByVal eventArgs As System.EventArgs) _
            Handles tmrMotDePasse.Tick

		'On �d�branche� les horloges pour interrompre les
		' les appels aux deux proc�dures
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

		' On fait �clignoter� le label �lblMess�
		' en basculant sa propri�t� �Visible�
		' � l'inverse de sa valeur courante
		lblMess.Visible = Not lblMess.Visible
	End Sub

	Private Sub txtMotDePasse_TextChanged(
			ByVal eventSender As System.Object,
			ByVal eventArgs As System.EventArgs) _
			Handles txtMotDePasse.TextChanged

		' � chaque nouvelle valeur du contr�le, on v�rifie si
		' le mot entr� jusqu'ici est �Bidule� ou �Commun�        
		If txtMotDePasse.Text.ToUpper = "BIDULE" Or
		   txtMotDePasse.Text.ToUpper = "COMMUN" Then

			' On d�termine les intervalles (4  sec. et 0,4 sec)
			' en millisecondes
			tmrMotDePasse.Interval = 4400
			tmrMessage.Interval = 400

			'On lance les minuteries
			tmrMotDePasse.Start()
			tmrMessage.Start()

			' Puis on d�termine si �gPermis� doit �tre
			' mis � True ou � False
			'Par d�faut gPermis est False
			gPermis = False
			If txtMotDePasse.Text.ToUpper = "BIDULE" Then
				'Par contre, si le mot depasse est "BIDULE" il passe � True
				gPermis = True
			End If

		End If
	End Sub
End Class