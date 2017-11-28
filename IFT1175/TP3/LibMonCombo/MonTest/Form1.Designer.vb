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
		Me.Analyseur1 = New LibMonCombo.Analyseur()
		Me.SuspendLayout()
		'
		'Analyseur1
		'
		Me.Analyseur1.FormattingEnabled = True
		Me.Analyseur1.Location = New System.Drawing.Point(12, 12)
		Me.Analyseur1.Name = "Analyseur1"
		Me.Analyseur1.Size = New System.Drawing.Size(1395, 39)
		Me.Analyseur1.Sorted = True
		Me.Analyseur1.TabIndex = 0
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1419, 229)
		Me.Controls.Add(Me.Analyseur1)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Analyseur1 As LibMonCombo.Analyseur
End Class
