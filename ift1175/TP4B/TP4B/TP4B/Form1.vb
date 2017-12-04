Imports System.Data.OleDb

Public Class Form1

	Private clients As New DataTable
	Private connection_string As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=clients.mdb"
	Private current_row As DataRow
	Private query As String
	Private current_row_index As Integer

	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
	End Sub

	Private Sub Form1_OnLoad(sender As Object, e As EventArgs) Handles Me.Load
		ConstructQuery()

		Using connection As New OleDbConnection(connection_string)
			Dim command As New OleDbCommand(query, connection)
			Dim data_adapter As New OleDbDataAdapter(command)

			Dim data_set As New DataSet
			data_adapter.Fill(data_set, "clients")
			clients = data_set.Tables("clients")
		End Using

		current_row_index = 0

		If clients.Rows.Count = 0 Then
			MessageBox.Show("Aucun enregistrement trouvé", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Exit Sub
		End If

		UpdateValues()
	End Sub

	'For scalable purposes, the query is constructed inside its own function
	Private Sub ConstructQuery()
		query = "SELECT * FROM clients" + CreateWhereStatement()
		query = query + " ORDER BY imc ASC"
	End Sub

	Private Function CreateWhereStatement() As String
		Dim where_statement = ""
		Dim chosen_sexe As String
		Dim chosen_imc As String

		Dim sexe_where = ""
		Dim imc_where = ""

		chosen_sexe = InputBox("Choisir le sexe : ")

		If Not {"M", "F"}.Contains(chosen_sexe) Then
			MessageBox.Show("Choix invalide, la valeur ne sera pas prise en compte", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Else
			where_statement = where_statement + "sexe='" + chosen_sexe + "' "
		End If

		Dim result As Double
		chosen_imc = InputBox("Entrez l'imc souhaité")
		If Not Double.TryParse(chosen_imc, result) Then
			MessageBox.Show("Choix d'imc invalide, la valeur ne sera pas prise en compte", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Else
			If Not String.IsNullOrWhiteSpace(where_statement) Then
				where_statement = where_statement + " AND "
			End If

			chosen_imc = chosen_imc.Replace(",", ".")
			where_statement = where_statement + "imc<" + chosen_imc
		End If

		Return If(String.IsNullOrWhiteSpace(where_statement), "", " WHERE " + where_statement)
	End Function

	Private Sub UpdateValues()
		current_row = clients.Rows(current_row_index)

		UpdateButtons()

		txtClientNo.Text = current_row("numéro")
		txtHeight.Text = current_row("taille")
		txtIMC.Text = current_row("imc")
		txtWeight.Text = current_row("poids")

		lblLowerBound.Text = (current_row_index + 1).ToString()
		lblUpperBound.Text = clients.Rows.Count

		If current_row("sexe") = "F" Then
			rdbIsWoman.Checked = True
		Else
			rdbIsMan.Checked = True
		End If

		If current_row("fumeur") = "O" Then
			rdbIsSmoker.Checked = True
		Else
			rdbIsNotSmoker.Checked = True
		End If
	End Sub

	Private Sub UpdateButtons()
		btnPrevious.Enabled = True
		btnNext.Enabled = True
		btnFirst.Enabled = True
		btnLast.Enabled = True

		If current_row_index = 0 Then
			btnPrevious.Enabled = False
			btnFirst.Enabled = False
		ElseIf current_row_index = clients.Rows.Count - 1 Then
			btnLast.Enabled = False
			btnNext.Enabled = False
		End If
	End Sub

	Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
		current_row_index = 0
		UpdateValues()
	End Sub

	Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
		If current_row_index > 0 Then
			current_row_index = current_row_index - 1
			UpdateValues()
		End If
	End Sub

	Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
		If current_row_index < clients.Rows.Count Then
			current_row_index = current_row_index + 1
			UpdateValues()
		End If
	End Sub

	Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
		current_row_index = clients.Rows.Count - 1
		UpdateValues()
	End Sub

	Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
		Dim response As DialogResult = MessageBox.Show("Êtes-vous sure?", "Quitter", MessageBoxButtons.YesNo)

		If response = DialogResult.Yes Then
			Me.Close()
		End If
	End Sub
End Class
