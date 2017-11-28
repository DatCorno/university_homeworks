'Auteur : François Corneau-Tremblay
Module EmplMod1
    Public Structure TypEmploye
        Dim Nom As String
        Dim Numero As String
        Dim Telephone As String
        Dim Poste As String
        Dim NumPatron As String
        Dim DateEmbauche As Date
        Dim Salaire As Short
        Dim SiComm As Short ' 0 = Non, 1 = Oui.
        Dim MtCommission As Short
        Dim NumDepartement As Short
    End Structure

    Public gEmployes(50) As TypEmploye
	Public gPermis As Boolean
	Public NbEmpl As Short

	Sub main()
        frmBienvenue.ShowDialog()
    End Sub
End Module