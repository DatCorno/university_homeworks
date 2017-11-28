<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPlus
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
        Me.components = New System.ComponentModel.Container
        Me.txtResult = New System.Windows.Forms.TextBox
        Me.Aff3 = New System.Windows.Forms.Label
        Me.Aff2 = New System.Windows.Forms.Label
        Me.Aff1 = New System.Windows.Forms.Label
        Me.lblBallon3 = New System.Windows.Forms.Label
        Me.lblBallon2 = New System.Windows.Forms.Label
        Me.lblBallon1 = New System.Windows.Forms.Label
        Me.lstCouleurs = New System.Windows.Forms.ListBox
        Me.scrQuant3 = New System.Windows.Forms.HScrollBar
        Me.scrQuant2 = New System.Windows.Forms.HScrollBar
        Me.scrQuant1 = New System.Windows.Forms.HScrollBar
        Me.btnSouffler3 = New System.Windows.Forms.Button
        Me.btnSouffler2 = New System.Windows.Forms.Button
        Me.btnSouffler1 = New System.Windows.Forms.Button
        Me.btnQuitter = New System.Windows.Forms.Button
        Me.btnLancer = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(30, 86)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(600, 120)
        Me.txtResult.TabIndex = 31
        Me.txtResult.Text = "Aucun résultat"
        Me.txtResult.Visible = False
        '
        'Aff3
        '
        Me.Aff3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Aff3.Location = New System.Drawing.Point(470, 29)
        Me.Aff3.Name = "Aff3"
        Me.Aff3.Size = New System.Drawing.Size(160, 16)
        Me.Aff3.TabIndex = 30
        Me.Aff3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Aff2
        '
        Me.Aff2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Aff2.Location = New System.Drawing.Point(249, 29)
        Me.Aff2.Name = "Aff2"
        Me.Aff2.Size = New System.Drawing.Size(160, 16)
        Me.Aff2.TabIndex = 29
        Me.Aff2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Aff1
        '
        Me.Aff1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Aff1.Location = New System.Drawing.Point(33, 29)
        Me.Aff1.Name = "Aff1"
        Me.Aff1.Size = New System.Drawing.Size(160, 16)
        Me.Aff1.TabIndex = 28
        Me.Aff1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblBallon3
        '
        Me.lblBallon3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblBallon3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBallon3.Location = New System.Drawing.Point(470, 214)
        Me.lblBallon3.Name = "lblBallon3"
        Me.lblBallon3.Size = New System.Drawing.Size(160, 64)
        Me.lblBallon3.TabIndex = 27
        Me.lblBallon3.Text = "Label1"
        Me.lblBallon3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBallon2
        '
        Me.lblBallon2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblBallon2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBallon2.Location = New System.Drawing.Point(246, 214)
        Me.lblBallon2.Name = "lblBallon2"
        Me.lblBallon2.Size = New System.Drawing.Size(160, 64)
        Me.lblBallon2.TabIndex = 26
        Me.lblBallon2.Text = "Label1"
        Me.lblBallon2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBallon1
        '
        Me.lblBallon1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblBallon1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBallon1.Location = New System.Drawing.Point(30, 214)
        Me.lblBallon1.Name = "lblBallon1"
        Me.lblBallon1.Size = New System.Drawing.Size(160, 64)
        Me.lblBallon1.TabIndex = 25
        Me.lblBallon1.Text = "Label1"
        Me.lblBallon1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstCouleurs
        '
        Me.lstCouleurs.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lstCouleurs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCouleurs.Items.AddRange(New Object() {"Bleu", "Rouge ", "Jaune ", "Vert"})
        Me.lstCouleurs.Location = New System.Drawing.Point(366, 390)
        Me.lstCouleurs.Name = "lstCouleurs"
        Me.lstCouleurs.Size = New System.Drawing.Size(120, 56)
        Me.lstCouleurs.TabIndex = 24
        '
        'scrQuant3
        '
        Me.scrQuant3.LargeChange = 1
        Me.scrQuant3.Location = New System.Drawing.Point(502, 318)
        Me.scrQuant3.Maximum = 5
        Me.scrQuant3.Minimum = 1
        Me.scrQuant3.Name = "scrQuant3"
        Me.scrQuant3.Size = New System.Drawing.Size(96, 17)
        Me.scrQuant3.TabIndex = 23
        Me.scrQuant3.Tag = "3"
        Me.scrQuant3.Value = 3
        '
        'scrQuant2
        '
        Me.scrQuant2.LargeChange = 1
        Me.scrQuant2.Location = New System.Drawing.Point(278, 318)
        Me.scrQuant2.Maximum = 5
        Me.scrQuant2.Minimum = 1
        Me.scrQuant2.Name = "scrQuant2"
        Me.scrQuant2.Size = New System.Drawing.Size(96, 17)
        Me.scrQuant2.TabIndex = 22
        Me.scrQuant2.Tag = "2"
        Me.scrQuant2.Value = 3
        '
        'scrQuant1
        '
        Me.scrQuant1.LargeChange = 1
        Me.scrQuant1.Location = New System.Drawing.Point(54, 318)
        Me.scrQuant1.Maximum = 5
        Me.scrQuant1.Minimum = 1
        Me.scrQuant1.Name = "scrQuant1"
        Me.scrQuant1.Size = New System.Drawing.Size(96, 17)
        Me.scrQuant1.TabIndex = 21
        Me.scrQuant1.Tag = "1"
        Me.scrQuant1.Value = 3
        '
        'btnSouffler3
        '
        Me.btnSouffler3.Enabled = False
        Me.btnSouffler3.Location = New System.Drawing.Point(510, 294)
        Me.btnSouffler3.Name = "btnSouffler3"
        Me.btnSouffler3.Size = New System.Drawing.Size(80, 23)
        Me.btnSouffler3.TabIndex = 20
        Me.btnSouffler3.Tag = "3"
        Me.btnSouffler3.Text = "Souffler"
        '
        'btnSouffler2
        '
        Me.btnSouffler2.Enabled = False
        Me.btnSouffler2.Location = New System.Drawing.Point(286, 294)
        Me.btnSouffler2.Name = "btnSouffler2"
        Me.btnSouffler2.Size = New System.Drawing.Size(80, 23)
        Me.btnSouffler2.TabIndex = 19
        Me.btnSouffler2.Tag = "2"
        Me.btnSouffler2.Text = "Souffler"
        '
        'btnSouffler1
        '
        Me.btnSouffler1.Enabled = False
        Me.btnSouffler1.Location = New System.Drawing.Point(62, 294)
        Me.btnSouffler1.Name = "btnSouffler1"
        Me.btnSouffler1.Size = New System.Drawing.Size(80, 23)
        Me.btnSouffler1.TabIndex = 18
        Me.btnSouffler1.Tag = "1"
        Me.btnSouffler1.Text = "Souffler"
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(598, 454)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitter.TabIndex = 17
        Me.btnQuitter.Text = "Quitter"
        '
        'btnLancer
        '
        Me.btnLancer.Location = New System.Drawing.Point(238, 390)
        Me.btnLancer.Name = "btnLancer"
        Me.btnLancer.Size = New System.Drawing.Size(128, 23)
        Me.btnLancer.TabIndex = 16
        Me.btnLancer.Text = "Lancer un ballon"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'FormPlus2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 539)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.Aff3)
        Me.Controls.Add(Me.Aff2)
        Me.Controls.Add(Me.Aff1)
        Me.Controls.Add(Me.lblBallon3)
        Me.Controls.Add(Me.lblBallon2)
        Me.Controls.Add(Me.lblBallon1)
        Me.Controls.Add(Me.lstCouleurs)
        Me.Controls.Add(Me.scrQuant3)
        Me.Controls.Add(Me.scrQuant2)
        Me.Controls.Add(Me.scrQuant1)
        Me.Controls.Add(Me.btnSouffler3)
        Me.Controls.Add(Me.btnSouffler2)
        Me.Controls.Add(Me.btnSouffler1)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnLancer)
        Me.Name = "FormPlus2"
        Me.Text = "FormPlus2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents Aff3 As System.Windows.Forms.Label
    Friend WithEvents Aff2 As System.Windows.Forms.Label
    Friend WithEvents Aff1 As System.Windows.Forms.Label
    Friend WithEvents lblBallon3 As System.Windows.Forms.Label
    Friend WithEvents lblBallon2 As System.Windows.Forms.Label
    Friend WithEvents lblBallon1 As System.Windows.Forms.Label
    Friend WithEvents lstCouleurs As System.Windows.Forms.ListBox
    Friend WithEvents scrQuant3 As System.Windows.Forms.HScrollBar
    Friend WithEvents scrQuant2 As System.Windows.Forms.HScrollBar
    Friend WithEvents scrQuant1 As System.Windows.Forms.HScrollBar
    Friend WithEvents btnSouffler3 As System.Windows.Forms.Button
    Friend WithEvents btnSouffler2 As System.Windows.Forms.Button
    Friend WithEvents btnSouffler1 As System.Windows.Forms.Button
    Friend WithEvents btnQuitter As System.Windows.Forms.Button
    Friend WithEvents btnLancer As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
