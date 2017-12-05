Public Class Form1
	Private Sub ListeEtudiantsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
		Me.Validate()
		Me.ListeEtudiantsBindingSource.EndEdit()
		Me.TableAdapterManager.UpdateAll(Me.BDataSet)

	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'TODO: This line of code loads data into the 'BDataSet.ListeEtudiants' table. You can move, or remove it, as needed.
		Me.ListeEtudiantsTableAdapter.Fill(Me.BDataSet.ListeEtudiants)

	End Sub
End Class
