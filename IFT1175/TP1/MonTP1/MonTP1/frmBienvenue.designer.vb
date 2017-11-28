<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBienvenue
	Inherits System.Windows.Forms.Form

	'Form remplace la méthode Dispose pour nettoyer la liste des composants.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.tmrMotDePasse = New System.Windows.Forms.Timer(Me.components)
		Me.tmrMessage = New System.Windows.Forms.Timer(Me.components)
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.txtMotDePasse = New System.Windows.Forms.TextBox()
		Me.lblMess = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'tmrMotDePasse
		'
		Me.tmrMotDePasse.Interval = 1
		'
		'tmrMessage
		'
		Me.tmrMessage.Interval = 1
		'
		'txtMotDePasse
		'
		Me.txtMotDePasse.AcceptsReturn = True
		Me.txtMotDePasse.BackColor = System.Drawing.SystemColors.Window
		Me.txtMotDePasse.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMotDePasse.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMotDePasse.Location = New System.Drawing.Point(477, 513)
		Me.txtMotDePasse.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
		Me.txtMotDePasse.MaxLength = 6
		Me.txtMotDePasse.Name = "txtMotDePasse"
		Me.txtMotDePasse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtMotDePasse.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMotDePasse.Size = New System.Drawing.Size(316, 38)
		Me.txtMotDePasse.TabIndex = 4
		'
		'lblMess
		'
		Me.lblMess.BackColor = System.Drawing.SystemColors.Control
		Me.lblMess.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMess.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMess.Location = New System.Drawing.Point(520, 589)
		Me.lblMess.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
		Me.lblMess.Name = "lblMess"
		Me.lblMess.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMess.Size = New System.Drawing.Size(216, 41)
		Me.lblMess.TabIndex = 5
		Me.lblMess.Text = "Un instant SVP"
		Me.lblMess.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblMess.Visible = False
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Red
		Me.Label1.Location = New System.Drawing.Point(413, 265)
		Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.Size = New System.Drawing.Size(429, 117)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Bonjour"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'frmBienvenue
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1293, 932)
		Me.Controls.Add(Me.txtMotDePasse)
		Me.Controls.Add(Me.lblMess)
		Me.Controls.Add(Me.Label1)
		Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
		Me.Name = "frmBienvenue"
		Me.Text = "frmIntro"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Public WithEvents tmrMotDePasse As System.Windows.Forms.Timer
	Public WithEvents tmrMessage As System.Windows.Forms.Timer
	Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents txtMotDePasse As System.Windows.Forms.TextBox
	Public WithEvents lblMess As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
End Class
