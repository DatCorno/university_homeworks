<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.btnQuitter = New System.Windows.Forms.Button()
		Me.txtResult = New System.Windows.Forms.TextBox()
		Me.Aff1 = New System.Windows.Forms.Label()
		Me.lblBallon1 = New System.Windows.Forms.Label()
		Me.lstCouleurs = New System.Windows.Forms.ListBox()
		Me.scrQuant1 = New System.Windows.Forms.HScrollBar()
		Me.btnSouffler1 = New System.Windows.Forms.Button()
		Me.btnLancer = New System.Windows.Forms.Button()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.SuspendLayout()
		'
		'btnQuitter
		'
		Me.btnQuitter.Location = New System.Drawing.Point(1576, 1116)
		Me.btnQuitter.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
		Me.btnQuitter.Name = "btnQuitter"
		Me.btnQuitter.Size = New System.Drawing.Size(200, 55)
		Me.btnQuitter.TabIndex = 31
		Me.btnQuitter.Text = "Quitter"
		'
		'txtResult
		'
		Me.txtResult.Location = New System.Drawing.Point(93, 179)
		Me.txtResult.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
		Me.txtResult.Multiline = True
		Me.txtResult.Name = "txtResult"
		Me.txtResult.Size = New System.Drawing.Size(1593, 281)
		Me.txtResult.TabIndex = 30
		Me.txtResult.Text = "Aucun résultat"
		Me.txtResult.Visible = False
		'
		'Aff1
		'
		Me.Aff1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Aff1.Location = New System.Drawing.Point(659, 67)
		Me.Aff1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
		Me.Aff1.Name = "Aff1"
		Me.Aff1.Size = New System.Drawing.Size(423, 35)
		Me.Aff1.TabIndex = 29
		Me.Aff1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'lblBallon1
		'
		Me.lblBallon1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.lblBallon1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBallon1.Location = New System.Drawing.Point(637, 525)
		Me.lblBallon1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
		Me.lblBallon1.Name = "lblBallon1"
		Me.lblBallon1.Size = New System.Drawing.Size(427, 153)
		Me.lblBallon1.TabIndex = 28
		Me.lblBallon1.Text = "Label1"
		Me.lblBallon1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lstCouleurs
		'
		Me.lstCouleurs.BackColor = System.Drawing.SystemColors.InactiveBorder
		Me.lstCouleurs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstCouleurs.ItemHeight = 31
		Me.lstCouleurs.Items.AddRange(New Object() {"Bleu", "Rouge", "Jaune", "Vert"})
		Me.lstCouleurs.Location = New System.Drawing.Point(936, 1021)
		Me.lstCouleurs.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
		Me.lstCouleurs.Name = "lstCouleurs"
		Me.lstCouleurs.Size = New System.Drawing.Size(313, 128)
		Me.lstCouleurs.TabIndex = 27
		'
		'scrQuant1
		'
		Me.scrQuant1.LargeChange = 1
		Me.scrQuant1.Location = New System.Drawing.Point(701, 773)
		Me.scrQuant1.Maximum = 5
		Me.scrQuant1.Minimum = 1
		Me.scrQuant1.Name = "scrQuant1"
		Me.scrQuant1.Size = New System.Drawing.Size(256, 17)
		Me.scrQuant1.TabIndex = 26
		Me.scrQuant1.Tag = "1"
		Me.scrQuant1.Value = 3
		'
		'btnSouffler1
		'
		Me.btnSouffler1.Enabled = False
		Me.btnSouffler1.Location = New System.Drawing.Point(723, 715)
		Me.btnSouffler1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
		Me.btnSouffler1.Name = "btnSouffler1"
		Me.btnSouffler1.Size = New System.Drawing.Size(213, 55)
		Me.btnSouffler1.TabIndex = 25
		Me.btnSouffler1.Tag = "1"
		Me.btnSouffler1.Text = "Souffler"
		'
		'btnLancer
		'
		Me.btnLancer.Location = New System.Drawing.Point(595, 1021)
		Me.btnLancer.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
		Me.btnLancer.Name = "btnLancer"
		Me.btnLancer.Size = New System.Drawing.Size(341, 55)
		Me.btnLancer.TabIndex = 24
		Me.btnLancer.Text = "Lancer un ballon"
		'
		'Timer1
		'
		Me.Timer1.Enabled = True
		Me.Timer1.Interval = 5000
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1869, 1238)
		Me.Controls.Add(Me.btnQuitter)
		Me.Controls.Add(Me.txtResult)
		Me.Controls.Add(Me.Aff1)
		Me.Controls.Add(Me.lblBallon1)
		Me.Controls.Add(Me.lstCouleurs)
		Me.Controls.Add(Me.scrQuant1)
		Me.Controls.Add(Me.btnSouffler1)
		Me.Controls.Add(Me.btnLancer)
		Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
		Me.Name = "Form1"
		Me.Text = "Form2"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnQuitter As System.Windows.Forms.Button
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents Aff1 As System.Windows.Forms.Label
    Friend WithEvents lblBallon1 As System.Windows.Forms.Label
    Friend WithEvents lstCouleurs As System.Windows.Forms.ListBox
    Friend WithEvents scrQuant1 As System.Windows.Forms.HScrollBar
    Friend WithEvents btnSouffler1 As System.Windows.Forms.Button
    Friend WithEvents btnLancer As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
