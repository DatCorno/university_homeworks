'Auteur : Fran�ois Corneau-Tremblay

Option Explicit On
Imports System.IO

Public Class frmEmploye

    'Indiquera le rang de l'employ�
    'affich� sur la feuille.
    Dim RangEmpl As Short
	Dim AncienRangEmpl As Short

	Private Sub frmEmpl_Load( _
            ByVal eventSender As System.Object, _
            ByVal eventArgs As System.EventArgs) _
            Handles MyBase.Load

        Dim I, J As Short
        Dim Dejala As Boolean

		' On d�termine si le contr�le �cboPoste� est prot�g�.
		cboPoste.Enabled = gPermis

		' On fait le plein de la liste des postes dans
		' la zone de liste d�roulante.
		' On parcours le tableau et on ajoute les postes non pr�sents.

		' On vide la liste
		cboPoste.Items.Clear()

        ' On place le premier poste dans la liste.

        cboPoste.Items.Add(gEmployes(1).Poste)

		'Le "premier" �l�ment du tableau a d�j� �t� ajout�. Et comme l'on s'est assur� que NbEmpl ne d�passe la derni�re
		'adresse valide du tableau gEmployes, il n'est pas n�cessaire de le d�cr�menter de 1
		For I = 2 To NbEmpl

			' Pour les autres postes, on v�rifie d'abord s'ils y sont
			Dejala = False

			' Le num�ro d'item commence � z�ro !
			' Il y a donc �Count� �l�ments qui sont num�rot�s
			' de �0� � �Count -1�
			For J = 0 To cboPoste.Items.Count - 1
				If gEmployes(I).Poste = cboPoste.Items(J) Then
					Dejala = True
					Exit For
				End If
			Next J
			If Not Dejala Then cboPoste.Items.Add(gEmployes(I).Poste)
		Next I
		' On d�termine (via gpermis) si les contr�les 
		' peuvent �tre modifi�s
		lstDept.Enabled = gPermis
	End Sub

	Private Sub cmdPrem_Click( _
            ByVal eventSender As System.Object, _
            ByVal eventArgs As System.EventArgs) _
            Handles cmdPrem.Click
		'  Bouton de commande �Premier�
		EcrEmpl((RangEmpl))

		'Il faut mettre � jour la variable AncienRangEmpl pour la fonction d'inversion de rangs
		AncienRangEmpl = RangEmpl
		RangEmpl = 1

		LireEmpl((RangEmpl))

		'  Activation des autres contr�les au d�but
		'Par d�faut, les options de comissions sont d�sactiv�es car un clique sur l'un deux
		'entra�nerait l'appel de l'�v�nement optXXXComm_Click ce qui m�nerait � une exception lorsque le total
		'tenterait de se mettre � jour puisque les textbox contenant les valeurs de salaires et de comissions
		'sont vides. M�me principe pour les textbox de salaire et de comission
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

        'Transfert des donn�es de la feuille vers le tableau
        '  �criture des donn�es
        If RgEmpl >= 1 And RgEmpl <= NbEmpl Then 'Simple pr�caution ...
            With gEmployes(RgEmpl)
                .Nom = txtNom.Text
                .Numero = txtNum.Text
                .Telephone = txtTelephone.Text
                .Poste = cboPoste.Text
                .DateEmbauche = CDate(txtDateEmb.Text)
                .NumDepartement = CShort(lstDept.Text)
                .Salaire = CShort(txtSalaire.Text)
                ' Attention : Sicom doit �tre num�rique : 
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

        '  Transfert des donn�es du tableau vers la feuille
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

                'DateDiff(DateInterval.Year, ...) donne la diff�rence
                'entre les ann�es de deux dates. Today est ... la date du jour
                NbAns = DateDiff(DateInterval.Year, .DateEmbauche, Today)

				' Ajustement n�cessaire pour respecter le jour d'embauche
				' On v�rifie si le nombre d'ann�es est �complet�
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
				' On a trouv� ?
				If K <= NbEmpl Then
					txtPatron.Text = gEmployes(K).Nom
				Else
					txtPatron.Text = ""
                End If
            End With
        End If
    End Sub

	'Cette commande lira le dernier employ� en changeant la valeur de RangEmpl � celle de NbEmpl, qui repr�sente la quantit�
	'd'employ� qui ont �t� lu
	Private Sub cmdDern_Click( _
            ByVal eventSender As System.Object, _
            ByVal eventArgs As System.EventArgs) _
            Handles cmdDern.Click
		EcrEmpl((RangEmpl))

		'Il faut mettre � jour la variable AncienRangEmpl pour la fonction d'inversion de rangs
		AncienRangEmpl = RangEmpl
		RangEmpl = NbEmpl

		LireEmpl((RangEmpl))
    End Sub

    Private Sub cmdPrec_Click( _
            ByVal eventSender As System.Object, _
            ByVal eventArgs As System.EventArgs) _
            Handles cmdPrec.Click

        'Bouton de commande �Pr�c�dent�.
        EcrEmpl((RangEmpl))

		'On ne doit pas reculer si on est au premier.
		'Il faut mettre � jour la variable AncienRangEmpl pour la fonction d'inversion de rangs
		AncienRangEmpl = RangEmpl
		RangEmpl = RangEmpl - 1

		'S'assure que RangEmpl ne descend pas sous la valeur minimum, si oui, le ramener � la valeur la plus basse permise
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
		'Il faut mettre � jour la variable AncienRangEmpl pour la fonction d'inversion de rangs
		AncienRangEmpl = RangEmpl
		RangEmpl += 1

		'S'assure que RangEmpl ne d�passe pas la taille du tableau d'employ�s ou qu'il n'acc�de pas � un emplacement comportant
		'un employ� cr�� par d�faut, donc vide. Le meilleur moyen de s'assurer de ceci est de v�rifier que le Rang courant ne d�passe
		'le nombre d'employ�s ayant �t� lu dans le fichier. S'il est sup�rieur, simplement le ramener � la valeur maximale admise
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

		' Avant de quitter, on met � jour l'employ� courant.
		EcrEmpl((RangEmpl))

		'Cr�ation d'un nouveau stream de fichier afin de le passer � un streamreader ou un streamwriter. Le
		'FileMode.Create permettra de purger un ancien fichier qui existerait d�j�
		Dim UnFich = New FileStream("EmplTP1Nouv.dta", FileMode.Create)
		'Cr�ation d'un streamwriter afin d'�crire les valeurs des employ�s dans le fichier pr�c�demment ouvert
		UnWriter = New StreamWriter(UnFich)

		For I = 1 To NbEmpl
			With gEmployes(I)
				'�criture des diff�rentes valeurs des propri�t�s courantes des employ�s dans le nouveau fichier de donn�es
				UnWriter.WriteLine(.Nom)
				UnWriter.WriteLine(.Numero)
				UnWriter.WriteLine(.Telephone)
				UnWriter.WriteLine(.Poste)
				UnWriter.WriteLine(.DateEmbauche)
				UnWriter.WriteLine(.NumDepartement)
				UnWriter.WriteLine(.Salaire)
				' Attention : Sicom doit �tre num�rique : 
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
		'Appel d'une proc�dure pour recalculer le revenue de l'ann�e sans se r�p�ter
		CalculerTotalRevenue()
	End Sub

    Private Sub optPasComm_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optPasComm.CheckedChanged
		'Appel d'une proc�dure pour recalculer le revenue de l'ann�e sans se r�p�ter
		CalculerTotalRevenue()
	End Sub

	Private Sub txtComm_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtComm.TextChanged
		'Il faut s'assurer que les valeurs entr�es dans la textbox de comission peuvent bien se traduire en nombre
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
		'Il faut s'assurer que les valeurs entr�es dans la textbox de salaire peuvent bien se traduire en nombre
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

		'Pour pouvoir inverser le rang des deux employ�s nous devons conserver une copie de l'employ� au rang courant
		'puisqu'il sera �cras� par la copie
		Dim buffer As TypEmploye = gEmployes(RangEmpl)
		'Nous copions maintenant l'employ� situ� au dernier rang visit� dans l'emplacement de l'employ� au rang courant
		gEmployes(RangEmpl) = gEmployes(AncienRangEmpl)
		'Puis nous remettons l'employ� qui a �t� supprim� � l'ancien emplacement de l'employ� qui a pris sa place
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