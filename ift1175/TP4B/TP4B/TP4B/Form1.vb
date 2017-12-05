'Author François Corneau-Tremblay
Imports System.Data.OleDb

Public Class Form1

	Private clients As New DataTable
	Private current_row As DataRow
	Private current_row_index As Integer

	Private connection_string As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=clients.mdb"
	Private query As String

	Private Sub Form1_OnLoad(sender As Object, e As EventArgs) Handles Me.Load
		ConstructQuery()

		'With using statement the "Dispose" function of the given object is always call
		'So we don't need to remember to close the connection once we're done
		Using connection As New OleDbConnection(connection_string)
			connection.Open()
			'Create OleDb command and adapter to fill the DataTable
			Dim command As New OleDbCommand(query, connection)
			Dim data_adapter As New OleDbDataAdapter(command)

			'Middleman DataSet
			Dim data_set As New DataSet
			data_adapter.Fill(data_set, "clients")
			clients = data_set.Tables("clients")
		End Using

		'If no rows have been selected from the database, show an error message then quit
		If clients.Rows.Count = 0 Then
			MessageBox.Show("Aucun enregistrement trouvé", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
			btnFirst.Enabled = False
			btnLast.Enabled = False
			btnNext.Enabled = False
			btnPrevious.Enabled = False
			Exit Sub
		End If

		'Initialize the first row we want to look at
		current_row_index = 0
		UpdateValues()
	End Sub

	'For scalable purposes, the query is constructed inside its own function
	Private Sub ConstructQuery()
		query = "SELECT * FROM clients" + CreateWhereStatement()
		query = query + " ORDER BY imc ASC"
	End Sub

	Private Function CreateWhereStatement() As String
		Dim where_statement = ""
		'This will collect the inputbox values
		Dim chosen_sexe As String
		Dim chosen_lower_imc As String
		Dim chosen_upper_imc As String

		chosen_sexe = InputBox("Choisir le sexe : ")

		'Create an anonymous array of possible values and check if it contains the user's input
		If Not {"M", "F"}.Contains(chosen_sexe) Then
			'In case the user has not entered "M" or "F" we tell him is input will be ignored
			MessageBox.Show("Choix invalide, la valeur ne sera pas prise en compte", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Else
			where_statement = where_statement + "sexe='" + chosen_sexe + "' "
		End If

		Dim result As Double
		chosen_lower_imc = InputBox("Entrez l'imc minimum souhaité")
		If Not Double.TryParse(chosen_lower_imc, result) Then
			'If the imc is not parsable, we did not encountered a number
			MessageBox.Show("Choix d'imc invalide, la valeur ne sera pas prise en compte", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Else
			'If the where_statement is not empty, it means the user has entered a valid sexe and we now need to add an "AND" operator
			If Not String.IsNullOrWhiteSpace(where_statement) Then
				where_statement = where_statement + " AND "
			End If

			'Create the statement from the given input. The TryParse has taken care of the "." and "," validation for us
			where_statement = where_statement + "imc>" + result.ToString()
		End If

		chosen_upper_imc = InputBox("Entrez l'imc maximum souhaité")
		If Not Double.TryParse(chosen_upper_imc, result) Then
			'If the imc is not parsable, we did not encountered a number
			MessageBox.Show("Choix d'imc invalide, la valeur ne sera pas prise en compte", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Else
			'If the where_statement is not empty, it means the user has entered a valid sexe and we now need to add an "AND" operator
			If Not String.IsNullOrWhiteSpace(where_statement) Then
				where_statement = where_statement + " AND "
			End If

			'Create the statement from the given input. The TryParse has taken care of the "." and "," validation for us
			where_statement = where_statement + "imc<" + result.ToString()
		End If

		'If the string is empty, return an empty string, else, return the where statement
		Return If(String.IsNullOrWhiteSpace(where_statement), "", " WHERE " + where_statement)
	End Function

	Private Sub UpdateValues()
		'We update the data we're currently looking at
		current_row = clients.Rows(current_row_index)

		'We reset the buttons enabled values regarding our current position
		UpdateButtons()

		'We update the textbox with the data inside datarow
		txtClientNo.Text = current_row("numéro")
		txtHeight.Text = current_row("taille")
		txtIMC.Text = current_row("imc")
		txtWeight.Text = current_row("poids")

		'We update the lower bound while making sure we display it using the 1-index arrays notation
		lblLowerBound.Text = (current_row_index + 1).ToString()
		lblUpperBound.Text = clients.Rows.Count

		'Make sure we check the right buttons for Male/Female | Smoler/Non-Smoker
		'Since the radiobuttons are inside GroupBox, we don't need to handle checking one if the other is not true etc.
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
