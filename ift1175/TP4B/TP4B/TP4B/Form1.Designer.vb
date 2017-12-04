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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtClientNo = New System.Windows.Forms.TextBox()
		Me.txtIMC = New System.Windows.Forms.TextBox()
		Me.txtWeight = New System.Windows.Forms.TextBox()
		Me.txtHeight = New System.Windows.Forms.TextBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.rdbIsNotSmoker = New System.Windows.Forms.RadioButton()
		Me.rdbIsSmoker = New System.Windows.Forms.RadioButton()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.rdbIsWoman = New System.Windows.Forms.RadioButton()
		Me.rdbIsMan = New System.Windows.Forms.RadioButton()
		Me.lblLowerBound = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.lblUpperBound = New System.Windows.Forms.Label()
		Me.btnFirst = New System.Windows.Forms.Button()
		Me.btnPrevious = New System.Windows.Forms.Button()
		Me.btnNext = New System.Windows.Forms.Button()
		Me.btnLast = New System.Windows.Forms.Button()
		Me.btnQuit = New System.Windows.Forms.Button()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(40, 53)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(229, 32)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Numéro du client"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(40, 97)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(85, 32)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Taille"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(40, 141)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(87, 32)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Poids"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(40, 188)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(65, 32)
		Me.Label4.TabIndex = 3
		Me.Label4.Text = "IMC"
		'
		'txtClientNo
		'
		Me.txtClientNo.Enabled = False
		Me.txtClientNo.Location = New System.Drawing.Point(275, 50)
		Me.txtClientNo.Name = "txtClientNo"
		Me.txtClientNo.Size = New System.Drawing.Size(478, 38)
		Me.txtClientNo.TabIndex = 4
		'
		'txtIMC
		'
		Me.txtIMC.Enabled = False
		Me.txtIMC.Location = New System.Drawing.Point(275, 185)
		Me.txtIMC.Name = "txtIMC"
		Me.txtIMC.Size = New System.Drawing.Size(478, 38)
		Me.txtIMC.TabIndex = 5
		'
		'txtWeight
		'
		Me.txtWeight.Enabled = False
		Me.txtWeight.Location = New System.Drawing.Point(275, 138)
		Me.txtWeight.Name = "txtWeight"
		Me.txtWeight.Size = New System.Drawing.Size(478, 38)
		Me.txtWeight.TabIndex = 6
		'
		'txtHeight
		'
		Me.txtHeight.Enabled = False
		Me.txtHeight.Location = New System.Drawing.Point(275, 94)
		Me.txtHeight.Name = "txtHeight"
		Me.txtHeight.Size = New System.Drawing.Size(478, 38)
		Me.txtHeight.TabIndex = 7
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.rdbIsNotSmoker)
		Me.GroupBox1.Controls.Add(Me.rdbIsSmoker)
		Me.GroupBox1.Enabled = False
		Me.GroupBox1.Location = New System.Drawing.Point(775, 50)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(141, 170)
		Me.GroupBox1.TabIndex = 8
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Fumeur"
		'
		'rdbIsNotSmoker
		'
		Me.rdbIsNotSmoker.AutoSize = True
		Me.rdbIsNotSmoker.Enabled = False
		Me.rdbIsNotSmoker.Location = New System.Drawing.Point(7, 128)
		Me.rdbIsNotSmoker.Name = "rdbIsNotSmoker"
		Me.rdbIsNotSmoker.Size = New System.Drawing.Size(104, 36)
		Me.rdbIsNotSmoker.TabIndex = 1
		Me.rdbIsNotSmoker.TabStop = True
		Me.rdbIsNotSmoker.Text = "Non"
		Me.rdbIsNotSmoker.UseVisualStyleBackColor = True
		'
		'rdbIsSmoker
		'
		Me.rdbIsSmoker.AutoSize = True
		Me.rdbIsSmoker.Enabled = False
		Me.rdbIsSmoker.Location = New System.Drawing.Point(7, 37)
		Me.rdbIsSmoker.Name = "rdbIsSmoker"
		Me.rdbIsSmoker.Size = New System.Drawing.Size(97, 36)
		Me.rdbIsSmoker.TabIndex = 0
		Me.rdbIsSmoker.TabStop = True
		Me.rdbIsSmoker.Text = "Oui"
		Me.rdbIsSmoker.UseVisualStyleBackColor = True
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.rdbIsWoman)
		Me.GroupBox2.Controls.Add(Me.rdbIsMan)
		Me.GroupBox2.Location = New System.Drawing.Point(46, 288)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(342, 99)
		Me.GroupBox2.TabIndex = 9
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Sexe"
		'
		'rdbIsWoman
		'
		Me.rdbIsWoman.AutoSize = True
		Me.rdbIsWoman.Enabled = False
		Me.rdbIsWoman.Location = New System.Drawing.Point(162, 37)
		Me.rdbIsWoman.Name = "rdbIsWoman"
		Me.rdbIsWoman.Size = New System.Drawing.Size(147, 36)
		Me.rdbIsWoman.TabIndex = 1
		Me.rdbIsWoman.TabStop = True
		Me.rdbIsWoman.Text = "Femme"
		Me.rdbIsWoman.UseVisualStyleBackColor = True
		'
		'rdbIsMan
		'
		Me.rdbIsMan.AutoSize = True
		Me.rdbIsMan.Enabled = False
		Me.rdbIsMan.Location = New System.Drawing.Point(6, 37)
		Me.rdbIsMan.Name = "rdbIsMan"
		Me.rdbIsMan.Size = New System.Drawing.Size(150, 36)
		Me.rdbIsMan.TabIndex = 0
		Me.rdbIsMan.TabStop = True
		Me.rdbIsMan.Text = "Homme"
		Me.rdbIsMan.UseVisualStyleBackColor = True
		'
		'lblLowerBound
		'
		Me.lblLowerBound.AutoSize = True
		Me.lblLowerBound.Location = New System.Drawing.Point(423, 306)
		Me.lblLowerBound.Name = "lblLowerBound"
		Me.lblLowerBound.Size = New System.Drawing.Size(0, 32)
		Me.lblLowerBound.TabIndex = 10
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(577, 306)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(47, 32)
		Me.Label5.TabIndex = 11
		Me.Label5.Text = "de"
		'
		'lblUpperBound
		'
		Me.lblUpperBound.AutoSize = True
		Me.lblUpperBound.Location = New System.Drawing.Point(733, 306)
		Me.lblUpperBound.Name = "lblUpperBound"
		Me.lblUpperBound.Size = New System.Drawing.Size(0, 32)
		Me.lblUpperBound.TabIndex = 12
		'
		'btnFirst
		'
		Me.btnFirst.Location = New System.Drawing.Point(46, 423)
		Me.btnFirst.Name = "btnFirst"
		Me.btnFirst.Size = New System.Drawing.Size(134, 51)
		Me.btnFirst.TabIndex = 13
		Me.btnFirst.Text = "Premier"
		Me.btnFirst.UseVisualStyleBackColor = True
		'
		'btnPrevious
		'
		Me.btnPrevious.Location = New System.Drawing.Point(186, 423)
		Me.btnPrevious.Name = "btnPrevious"
		Me.btnPrevious.Size = New System.Drawing.Size(169, 51)
		Me.btnPrevious.TabIndex = 14
		Me.btnPrevious.Text = "Précédent"
		Me.btnPrevious.UseVisualStyleBackColor = True
		'
		'btnNext
		'
		Me.btnNext.Location = New System.Drawing.Point(361, 423)
		Me.btnNext.Name = "btnNext"
		Me.btnNext.Size = New System.Drawing.Size(134, 51)
		Me.btnNext.TabIndex = 15
		Me.btnNext.Text = "Suivant"
		Me.btnNext.UseVisualStyleBackColor = True
		'
		'btnLast
		'
		Me.btnLast.Location = New System.Drawing.Point(501, 423)
		Me.btnLast.Name = "btnLast"
		Me.btnLast.Size = New System.Drawing.Size(134, 51)
		Me.btnLast.TabIndex = 16
		Me.btnLast.Text = "Dernier"
		Me.btnLast.UseVisualStyleBackColor = True
		'
		'btnQuit
		'
		Me.btnQuit.Location = New System.Drawing.Point(641, 423)
		Me.btnQuit.Name = "btnQuit"
		Me.btnQuit.Size = New System.Drawing.Size(134, 51)
		Me.btnQuit.TabIndex = 17
		Me.btnQuit.Text = "Quitter"
		Me.btnQuit.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(952, 492)
		Me.Controls.Add(Me.btnQuit)
		Me.Controls.Add(Me.btnLast)
		Me.Controls.Add(Me.btnNext)
		Me.Controls.Add(Me.btnPrevious)
		Me.Controls.Add(Me.btnFirst)
		Me.Controls.Add(Me.lblUpperBound)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.lblLowerBound)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.txtHeight)
		Me.Controls.Add(Me.txtWeight)
		Me.Controls.Add(Me.txtIMC)
		Me.Controls.Add(Me.txtClientNo)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents txtClientNo As TextBox
	Friend WithEvents txtIMC As TextBox
	Friend WithEvents txtWeight As TextBox
	Friend WithEvents txtHeight As TextBox
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents rdbIsNotSmoker As RadioButton
	Friend WithEvents rdbIsSmoker As RadioButton
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents rdbIsMan As RadioButton
	Friend WithEvents rdbIsWoman As RadioButton
	Friend WithEvents lblLowerBound As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents lblUpperBound As Label
	Friend WithEvents btnFirst As Button
	Friend WithEvents btnPrevious As Button
	Friend WithEvents btnNext As Button
	Friend WithEvents btnLast As Button
	Friend WithEvents btnQuit As Button
End Class
