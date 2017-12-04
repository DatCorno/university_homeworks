<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.BDataSet = New TP4.bDataSet()
		Me.ListeEtudiantsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.ListeEtudiantsTableAdapter = New TP4.bDataSetTableAdapters.ListeEtudiantsTableAdapter()
		Me.TableAdapterManager = New TP4.bDataSetTableAdapters.TableAdapterManager()
		Me.ListeEtudiantsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
		Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
		Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
		Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
		Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
		Me.ListeEtudiantsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
		Me.ListeEtudiantsDataGridView = New System.Windows.Forms.DataGridView()
		Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		CType(Me.BDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ListeEtudiantsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ListeEtudiantsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ListeEtudiantsBindingNavigator.SuspendLayout()
		CType(Me.ListeEtudiantsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'BDataSet
		'
		Me.BDataSet.DataSetName = "bDataSet"
		Me.BDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'ListeEtudiantsBindingSource
		'
		Me.ListeEtudiantsBindingSource.DataMember = "ListeEtudiants"
		Me.ListeEtudiantsBindingSource.DataSource = Me.BDataSet
		'
		'ListeEtudiantsTableAdapter
		'
		Me.ListeEtudiantsTableAdapter.ClearBeforeFill = True
		'
		'TableAdapterManager
		'
		Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
		Me.TableAdapterManager.ListeEtudiantsTableAdapter = Me.ListeEtudiantsTableAdapter
		Me.TableAdapterManager.UpdateOrder = TP4.bDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
		'
		'ListeEtudiantsBindingNavigator
		'
		Me.ListeEtudiantsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
		Me.ListeEtudiantsBindingNavigator.BindingSource = Me.ListeEtudiantsBindingSource
		Me.ListeEtudiantsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
		Me.ListeEtudiantsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
		Me.ListeEtudiantsBindingNavigator.ImageScalingSize = New System.Drawing.Size(40, 40)
		Me.ListeEtudiantsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ListeEtudiantsBindingNavigatorSaveItem})
		Me.ListeEtudiantsBindingNavigator.Location = New System.Drawing.Point(0, 0)
		Me.ListeEtudiantsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
		Me.ListeEtudiantsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
		Me.ListeEtudiantsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
		Me.ListeEtudiantsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
		Me.ListeEtudiantsBindingNavigator.Name = "ListeEtudiantsBindingNavigator"
		Me.ListeEtudiantsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
		Me.ListeEtudiantsBindingNavigator.Size = New System.Drawing.Size(1413, 47)
		Me.ListeEtudiantsBindingNavigator.TabIndex = 0
		Me.ListeEtudiantsBindingNavigator.Text = "BindingNavigator1"
		'
		'BindingNavigatorMoveFirstItem
		'
		Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
		Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(44, 22)
		Me.BindingNavigatorMoveFirstItem.Text = "Move first"
		'
		'BindingNavigatorMovePreviousItem
		'
		Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
		Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(44, 44)
		Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
		'
		'BindingNavigatorSeparator
		'
		Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
		Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 6)
		'
		'BindingNavigatorPositionItem
		'
		Me.BindingNavigatorPositionItem.AccessibleName = "Position"
		Me.BindingNavigatorPositionItem.AutoSize = False
		Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
		Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 47)
		Me.BindingNavigatorPositionItem.Text = "0"
		Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
		'
		'BindingNavigatorCountItem
		'
		Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
		Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(87, 41)
		Me.BindingNavigatorCountItem.Text = "of {0}"
		Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
		'
		'BindingNavigatorSeparator1
		'
		Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
		Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
		'
		'BindingNavigatorMoveNextItem
		'
		Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
		Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(44, 44)
		Me.BindingNavigatorMoveNextItem.Text = "Move next"
		'
		'BindingNavigatorMoveLastItem
		'
		Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
		Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(44, 44)
		Me.BindingNavigatorMoveLastItem.Text = "Move last"
		'
		'BindingNavigatorSeparator2
		'
		Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
		Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
		'
		'BindingNavigatorAddNewItem
		'
		Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
		Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(44, 44)
		Me.BindingNavigatorAddNewItem.Text = "Add new"
		'
		'BindingNavigatorDeleteItem
		'
		Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
		Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(44, 44)
		Me.BindingNavigatorDeleteItem.Text = "Delete"
		'
		'ListeEtudiantsBindingNavigatorSaveItem
		'
		Me.ListeEtudiantsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ListeEtudiantsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ListeEtudiantsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
		Me.ListeEtudiantsBindingNavigatorSaveItem.Name = "ListeEtudiantsBindingNavigatorSaveItem"
		Me.ListeEtudiantsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
		Me.ListeEtudiantsBindingNavigatorSaveItem.Text = "Save Data"
		'
		'ListeEtudiantsDataGridView
		'
		Me.ListeEtudiantsDataGridView.AutoGenerateColumns = False
		Me.ListeEtudiantsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.ListeEtudiantsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
		Me.ListeEtudiantsDataGridView.DataSource = Me.ListeEtudiantsBindingSource
		Me.ListeEtudiantsDataGridView.Location = New System.Drawing.Point(18, 86)
		Me.ListeEtudiantsDataGridView.Name = "ListeEtudiantsDataGridView"
		Me.ListeEtudiantsDataGridView.RowTemplate.Height = 40
		Me.ListeEtudiantsDataGridView.Size = New System.Drawing.Size(862, 569)
		Me.ListeEtudiantsDataGridView.TabIndex = 1
		'
		'DataGridViewTextBoxColumn1
		'
		Me.DataGridViewTextBoxColumn1.DataPropertyName = "Nom"
		Me.DataGridViewTextBoxColumn1.HeaderText = "Nom"
		Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
		'
		'DataGridViewTextBoxColumn2
		'
		Me.DataGridViewTextBoxColumn2.DataPropertyName = "code"
		Me.DataGridViewTextBoxColumn2.HeaderText = "code"
		Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
		'
		'DataGridViewTextBoxColumn3
		'
		Me.DataGridViewTextBoxColumn3.DataPropertyName = "Note"
		Me.DataGridViewTextBoxColumn3.HeaderText = "Note"
		Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
		'
		'DataGridViewTextBoxColumn4
		'
		Me.DataGridViewTextBoxColumn4.DataPropertyName = "Lettre"
		Me.DataGridViewTextBoxColumn4.HeaderText = "Lettre"
		Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1413, 991)
		Me.Controls.Add(Me.ListeEtudiantsDataGridView)
		Me.Controls.Add(Me.ListeEtudiantsBindingNavigator)
		Me.Name = "Form1"
		Me.Text = "Form1"
		CType(Me.BDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ListeEtudiantsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ListeEtudiantsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ListeEtudiantsBindingNavigator.ResumeLayout(False)
		Me.ListeEtudiantsBindingNavigator.PerformLayout()
		CType(Me.ListeEtudiantsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents BDataSet As bDataSet
	Friend WithEvents ListeEtudiantsBindingSource As BindingSource
	Friend WithEvents ListeEtudiantsTableAdapter As bDataSetTableAdapters.ListeEtudiantsTableAdapter
	Friend WithEvents TableAdapterManager As bDataSetTableAdapters.TableAdapterManager
	Friend WithEvents ListeEtudiantsBindingNavigator As BindingNavigator
	Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
	Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
	Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
	Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
	Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
	Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
	Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
	Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
	Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
	Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
	Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
	Friend WithEvents ListeEtudiantsBindingNavigatorSaveItem As ToolStripButton
	Friend WithEvents ListeEtudiantsDataGridView As DataGridView
	Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
