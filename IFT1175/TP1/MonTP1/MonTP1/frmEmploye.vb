'Auteur : François Corneau-Tremblay

Option Explicit On
Imports System.IO

Public Class frmEmploye

    'Indiquera le rang de l'employé
    'affiché sur la feuille.
    Dim RangEmpl As Short
	Dim AncienRangEmpl As Short

	Private Sub frmEmpl_Load( _
            ByVal eventSender As System.Object, _
            ByVal eventArgs As System.EventArgs) _
            Handles MyBase.Load

        Dim I, J As Short
        Dim Dejala As Boolean

		' On détermine si le contrôle «cboPoste» est protégé.
		cboPoste.Enabled = gPermis

		' On fait le plein de la liste des postes dans
		' la zone de liste déroulante.
		' On parcours le tableau et on ajoute les postes non présents.

		' On vide la liste
		cboPoste.Items.Clear()

        ' On place le premier poste dans la liste.

        cboPoste.Items.Add(gEmployes(1).Poste)

		'Le "premier" élément du tableau a déjà été ajouté. Et comme l'on s'est assuré que NbEmpl ne dépasse la dernière
		'adresse valide du tableau gEmployes, il n'est pas nécessaire de le décrémenter de 1
		For I = 2 To NbEmpl

			' Pour les autres postes, on vérifie d'abord s'ils y sont
			Dejala = False

			' Le numéro d'item commence à zéro !
			' Il y a donc «Count» éléments qui sont numérotés
			' de «0» à «Count -1»
			For J = 0 To cboPoste.Items.Count - 1
				If gEmployes(I).Poste = cboPoste.Items(J) Then
					Dejala = True
					Exit For
				End If
			Next J
			If Not Dejala Then cboPoste.Items.Add(gEmployes(I).Poste)
		Next I
		' On détermine (via gpermis) si les contrôles 
		' peuvent être modifiés
		lstDept.Enabled = gPermis
	End Sub

	Private Sub cmdPrem_Click( _
            ByVal eventSender As System.Object, _
            ByVal eventArgs As System.EventArgs) _
            Handles cmdPrem.Click
		'  Bouton de commande «Premier»
		EcrEmpl((RangEmpl))

		'Il faut mettre à jour la variable AncienRangEmpl pour la fonction d'inversion de rangs
		AncienRangEmpl = RangEmpl
		RangEmpl = 1

		LireEmpl((RangEmpl))

		'  Activation des autres contrôles au début
		'Par défaut, les options de comissions sont désactivées car un clique sur l'un deux
		'entraînerait l'appel de l'évènement optXXXComm_Click ce qui mènerait à une exception lorsque le total
		'tenterait de se mettre à jour puisque les textbox contenant les valeurs de salaires et de comissions
		'sont vides. Même principe pour les textbox de salaire et de comission
		If Not cmdSuiv.Enabled = True Then
			optComm.Enabled = gPermis
			optPasComm.Enabled = gPermis
			txtSalaire.ReadOnly = Not gPermis
			txtComm.ReadOnly = Not gPermis
			cmdSuiv.Enabled = True
			cmdPrec.Enabled = True
			cmdInver.Enabled = True
			cmdDern.Enabled = True
		End If
	End Sub

    Private Sub EcrEmpl( _
    ByVal RgEmpl As Short)

        'Transfert des données de la feuille vers le tableau
        '  Écriture des données
        If RgEmpl >= 1 And RgEmpl <= NbEmpl Then 'Simple précaution ...
            With gEmployes(RgEmpl)
                .Nom = txtNom.Text
                .Numero = txtNum.Text
                .Telephone = txtTelephone.Text
                .Poste = cboPoste.Text
                .DateEmbauche = CDate(txtDateEmb.Text)
                .NumDepartement = CShort(lstDept.Text)
                .Salaire = CShort(txtSalaire.Text)
                ' Attention : Sicom doit être numérique : 
                ' 0 ou 1 selon la valeur de optComm.Checked
                .SiComm = (optComm.Checked = 1)
                .MtCommission = CShort(txtComm.Text)
            End With             ' ... jusqu'ici.
        End If
    End Sub


    Private Sub LireEmpl( _
            ByVal RgEmpl As Short)
        Dim NbAns As Short
        Dim NoPatron As String
        Dim K As Short

        '  Transfert des données du tableau vers la feuille
        If RgEmpl >= 1 And RgEmpl <= NbEmpl Then
            With gEmployes(RgEmpl) ' Comme plus haut
                txtRang.Text = CStr(RgEmpl)
                txtNom.Text = .Nom
                txtNum.Text = .Numero
                txtTelephone.Text = .Telephone
                cboPoste.Text = .Poste
                txtDateEmb.Text = CStr(.DateEmbauche)
                lstDept.Text = CStr(.NumDepartement)
                txtSalaire.Text = CStr(.Salaire)
                optComm.Checked = (.SiComm = 1)
                optPasComm.Checked = Not optComm.Checked
                txtComm.Text = CStr(.MtCommission)

                'DateDiff(DateInterval.Year, ...) donne la différence
                'entre les années de deux dates. Today est ... la date du jour
                NbAns = DateDiff(DateInterval.Year, .DateEmbauche, Today)

				' Ajustement nécessaire pour respecter le jour d'embauche
				' On vérifie si le nombre d'années est «complet»
				If DateAdd(DateInterval.Year, NbAns, .DateEmbauche) > Today Then
					NbAns -= 1
				End If

				txtDate.Text = CStr(NbAns)

				lblRevenu.Text = 26 * CInt(txtSalaire.Text)
                'On ajoute la commission si ...
                If (optComm.Checked = True) Then lblRevenu.Text += Val(txtComm.Text)
                NoPatron = .NumPatron

                ' On veut afficher le nom du patron, donc on fouille la table.
                K = 1
				Do
					If gEmployes(K).Numero = NoPatron Then Exit Do
					K += 1
				Loop Until K = NbEmpl
				' On a trouvé ?
				If K <= NbEmpl Then
					txtPatron.Text = gEmployes(K).Nom
				Else
					txtPatron.Text = ""
                End If
            End With
        End If
    End Sub

	'Cette commande lira le dernier employé en changeant la valeur de RangEmpl à celle de NbEmpl, qui représente la quantité
	'd'employé qui ont été lu
	Private Sub cmdDern_Click( _
            ByVal eventSender As System.Object, _
            ByVal eventArgs As System.EventArgs) _
            Handles cmdDern.Click
		EcrEmpl((RangEmpl))

		'Il faut mettre à jour la variable AncienRangEmpl pour la fonction d'inversion de rangs
		AncienRangEmpl = RangEmpl
		RangEmpl = NbEmpl

		LireEmpl((RangEmpl))
    End Sub

    Private Sub cmdPrec_Click( _
            ByVal eventSender As System.Object, _
            ByVal eventArgs As System.EventArgs) _
            Handles cmdPrec.Click

        'Bouton de commande «Précédent».
        EcrEmpl((RangEmpl))

		'On ne doit pas reculer si on est au premier.
		'Il faut mettre à jour la variable AncienRangEmpl pour la fonction d'inversion de rangs
		AncienRangEmpl = RangEmpl
		RangEmpl = RangEmpl - 1

		'S'assure que RangEmpl ne descend pas sous la valeur minimum, si oui, le ramener à la valeur la plus basse permise
		If RangEmpl < 1 Then
			RangEmpl = 1
		End If
		
        LireEmpl((RangEmpl))
    End Sub

    Private Sub cmdSuiv_Click( _
            ByVal eventSender As System.Object, _
            ByVal eventArgs As System.EventArgs) _
            Handles cmdSuiv.Click

        ' Avant de quitter l'enregistrement courant, on le sauvegarde
        EcrEmpl((RangEmpl))

		' On ne doit pas avancer trop loin...
		'Il faut mettre à jour la variable AncienRangEmpl pour la fonction d'inversion de rangs
		AncienRangEmpl = RangEmpl
		RangEmpl += 1

		'S'assure que RangEmpl ne dépasse pas la taille du tableau d'employés ou qu'il n'accède pas à un emplacement comportant
		'un employé créé par défaut, donc vide. Le meilleur moyen de s'assurer de ceci est de vérifier que le Rang courant ne dépasse
		'le nombre d'employés ayant été lu dans le fichier. S'il est supérieur, simplement le ramener à la valeur maximale admise
		If RangEmpl > NbEmpl Then
			RangEmpl = NbEmpl
		End If

		LireEmpl((RangEmpl))
    End Sub

    Private Sub cmdQuit_Click( _
            ByVal eventSender As System.Object, _
            ByVal eventArgs As System.EventArgs) _
            Handles cmdQuit.Click
        Dim I As Short
        Dim UnWriter As StreamWriter

		' Avant de quitter, on met à jour l'employé courant.
		EcrEmpl((RangEmpl))

		'Création d'un nouveau stream de fichier afin de le passer à un streamreader ou un streamwriter. Le
		'FileMode.Create permettra de purger un ancien fichier qui existerait déjà
		Dim UnFich = New FileStream("EmplTP1Nouv.dta", FileMode.Create)
		'Création d'un streamwriter afin d'écrire les valeurs des employés dans le fichier précédemment ouvert
		UnWriter = New StreamWriter(UnFich)

		For I = 1 To NbEmpl
			With gEmployes(I)
				'Écriture des différentes valeurs des propriétés courantes des employés dans le nouveau fichier de données
				UnWriter.WriteLine(.Nom)
				UnWriter.WriteLine(.Numero)
				UnWriter.WriteLine(.Telephone)
				UnWriter.WriteLine(.Poste)
				UnWriter.WriteLine(.DateEmbauche)
				UnWriter.WriteLine(.NumDepartement)
				UnWriter.WriteLine(.Salaire)
				' Attention : Sicom doit être numérique : 
				' 0 ou 1 selon la valeur de optComm.Checked
				UnWriter.WriteLine(.SiComm)
				UnWriter.WriteLine(.MtCommission)
				UnWriter.WriteLine(.NumDepartement)
			End With
		Next
		UnWriter.Close()
        ' et c'est la fin.
        Me.Close()
    End Sub

    Private Sub optComm_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optComm.CheckedChanged
		'Appel d'une procédure pour recalculer le revenue de l'année sans se répéter
		CalculerTotalRevenue()
	End Sub

    Private Sub optPasComm_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optPasComm.CheckedChanged
		'Appel d'une procédure pour recalculer le revenue de l'année sans se répéter
		CalculerTotalRevenue()
	End Sub

	Private Sub txtComm_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtComm.TextChanged
		'Il faut s'assurer que les valeurs entrées dans la textbox de comission peuvent bien se traduire en nombre
		'et qu'elle puisse rentrer dans une variable de type Short
		Dim success As Boolean = Short.TryParse(txtComm.Text, success)

		If success = False Then
			MsgBox("Cette valeur de comission n'est pas valide")
			txtComm.Text = gEmployes(RangEmpl).MtCommission
		Else
			CalculerTotalRevenue()
		End If
	End Sub

	Private Sub txtSalaire_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSalaire.TextChanged
		'Il faut s'assurer que les valeurs entrées dans la textbox de salaire peuvent bien se traduire en nombre
		'et qu'elle puisse rentrer dans une variable de type Short
		Dim success As Boolean = Short.TryParse(txtSalaire.Text, success)

		If success = False Then
			MsgBox("Cette valeur de salaire n'est pas valide")
			txtSalaire.Text = gEmployes(RangEmpl).Salaire
		Else
			CalculerTotalRevenue()
		End If
	End Sub

	'Bouton de commande "Inverser"
	Private Sub cmdInver_Clicked(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdInver.Click
		EcrEmpl((RangEmpl))

		'Pour pouvoir inverser le rang des deux employés nous devons conserver une copie de l'employé au rang courant
		'puisqu'il sera écrasé par la copie
		Dim buffer As TypEmploye = gEmployes(RangEmpl)
		'Nous copions maintenant l'employé situé au dernier rang visité dans l'emplacement de l'employé au rang courant
		gEmployes(RangEmpl) = gEmployes(AncienRangEmpl)
		'Puis nous remettons l'employé qui a été supprimé à l'ancien emplacement de l'employé qui a pris sa place
		gEmployes(AncienRangEmpl) = buffer

		LireEmpl((RangEmpl))
	End Sub

	Private Sub CalculerTotalRevenue()
		lblRevenu.Text = 26 * CInt(txtSalaire.Text)

		'On ajoute la commission si ...
		If (optComm.Checked = True) Then
			lblRevenu.Text += Val(txtComm.Text)
		End If
	End Sub

End Class