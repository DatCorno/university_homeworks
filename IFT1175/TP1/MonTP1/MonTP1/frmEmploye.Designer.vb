<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmploye
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
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.txtRang = New System.Windows.Forms.TextBox()
		Me.txtPatron = New System.Windows.Forms.TextBox()
		Me.txtComm = New System.Windows.Forms.TextBox()
		Me.txtSalaire = New System.Windows.Forms.TextBox()
		Me.cmdQuit = New System.Windows.Forms.Button()
		Me.cboPoste = New System.Windows.Forms.ComboBox()
		Me.txtDateEmb = New System.Windows.Forms.TextBox()
		Me.txtNum = New System.Windows.Forms.TextBox()
		Me.cmdSuiv = New System.Windows.Forms.Button()
		Me.cmdPrec = New System.Windows.Forms.Button()
		Me.cmdInver = New System.Windows.Forms.Button()
		Me.cmdDern = New System.Windows.Forms.Button()
		Me.cmdPrem = New System.Windows.Forms.Button()
		Me.txtDate = New System.Windows.Forms.Label()
		Me.lblRevenu = New System.Windows.Forms.Label()
		Me.txtTelephone = New System.Windows.Forms.TextBox()
		Me.lstDept = New System.Windows.Forms.ListBox()
		Me.optPasComm = New System.Windows.Forms.RadioButton()
		Me.optComm = New System.Windows.Forms.RadioButton()
		Me.txtNom = New System.Windows.Forms.TextBox()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'txtRang
		'
		Me.txtRang.AcceptsReturn = True
		Me.txtRang.BackColor = System.Drawing.SystemColors.Window
		Me.txtRang.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtRang.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtRang.Location = New System.Drawing.Point(528, 262)
		Me.txtRang.Margin = New System.Windows.Forms.Padding(8)
		Me.txtRang.MaxLength = 0
		Me.txtRang.Name = "txtRang"
		Me.txtRang.ReadOnly = True
		Me.txtRang.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtRang.Size = New System.Drawing.Size(146, 38)
		Me.txtRang.TabIndex = 64
		Me.txtRang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.ToolTip1.SetToolTip(Me.txtRang, "Numéro (invariable) de l'employé")
		'
		'txtPatron
		'
		Me.txtPatron.AcceptsReturn = True
		Me.txtPatron.BackColor = System.Drawing.SystemColors.Window
		Me.txtPatron.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPatron.Enabled = False
		Me.txtPatron.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPatron.Location = New System.Drawing.Point(656, 701)
		Me.txtPatron.Margin = New System.Windows.Forms.Padding(8)
		Me.txtPatron.MaxLength = 0
		Me.txtPatron.Name = "txtPatron"
		Me.txtPatron.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPatron.Size = New System.Drawing.Size(358, 38)
		Me.txtPatron.TabIndex = 62
		Me.ToolTip1.SetToolTip(Me.txtPatron, "Affiche le nom sui suivant")
		'
		'txtComm
		'
		Me.txtComm.AcceptsReturn = True
		Me.txtComm.BackColor = System.Drawing.SystemColors.Window
		Me.txtComm.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtComm.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtComm.Location = New System.Drawing.Point(1040, 415)
		Me.txtComm.Margin = New System.Windows.Forms.Padding(8)
		Me.txtComm.MaxLength = 0
		Me.txtComm.Name = "txtComm"
		Me.txtComm.ReadOnly = True
		Me.txtComm.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtComm.Size = New System.Drawing.Size(230, 38)
		Me.txtComm.TabIndex = 52
		Me.ToolTip1.SetToolTip(Me.txtComm, "Montant de la commission")
		'
		'txtSalaire
		'
		Me.txtSalaire.AcceptsReturn = True
		Me.txtSalaire.BackColor = System.Drawing.SystemColors.Window
		Me.txtSalaire.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSalaire.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSalaire.Location = New System.Drawing.Point(1040, 281)
		Me.txtSalaire.Margin = New System.Windows.Forms.Padding(8)
		Me.txtSalaire.MaxLength = 0
		Me.txtSalaire.Name = "txtSalaire"
		Me.txtSalaire.ReadOnly = True
		Me.txtSalaire.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSalaire.Size = New System.Drawing.Size(230, 38)
		Me.txtSalaire.TabIndex = 48
		Me.ToolTip1.SetToolTip(Me.txtSalaire, "Salaire aux deux semaines")
		'
		'cmdQuit
		'
		Me.cmdQuit.BackColor = System.Drawing.SystemColors.Control
		Me.cmdQuit.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.cmdQuit.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdQuit.Location = New System.Drawing.Point(1146, 777)
		Me.cmdQuit.Margin = New System.Windows.Forms.Padding(8)
		Me.cmdQuit.Name = "cmdQuit"
		Me.cmdQuit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdQuit.Size = New System.Drawing.Size(174, 60)
		Me.cmdQuit.TabIndex = 46
		Me.cmdQuit.Text = "Quitter"
		Me.ToolTip1.SetToolTip(Me.cmdQuit, "Quitter l'application")
		Me.cmdQuit.UseVisualStyleBackColor = False
		'
		'cboPoste
		'
		Me.cboPoste.BackColor = System.Drawing.SystemColors.Window
		Me.cboPoste.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboPoste.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboPoste.Location = New System.Drawing.Point(336, 147)
		Me.cboPoste.Margin = New System.Windows.Forms.Padding(8)
		Me.cboPoste.Name = "cboPoste"
		Me.cboPoste.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboPoste.Size = New System.Drawing.Size(274, 39)
		Me.cboPoste.Sorted = True
		Me.cboPoste.TabIndex = 44
		Me.ToolTip1.SetToolTip(Me.cboPoste, "Permet de sélectionner un poste sans se tromper...")
		'
		'txtDateEmb
		'
		Me.txtDateEmb.AcceptsReturn = True
		Me.txtDateEmb.BackColor = System.Drawing.SystemColors.Window
		Me.txtDateEmb.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDateEmb.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDateEmb.Location = New System.Drawing.Point(720, 147)
		Me.txtDateEmb.Margin = New System.Windows.Forms.Padding(8)
		Me.txtDateEmb.MaxLength = 0
		Me.txtDateEmb.Name = "txtDateEmb"
		Me.txtDateEmb.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDateEmb.Size = New System.Drawing.Size(210, 38)
		Me.txtDateEmb.TabIndex = 42
		Me.txtDateEmb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.ToolTip1.SetToolTip(Me.txtDateEmb, "Date de l'embauche")
		'
		'txtNum
		'
		Me.txtNum.AcceptsReturn = True
		Me.txtNum.BackColor = System.Drawing.SystemColors.Window
		Me.txtNum.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNum.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtNum.Location = New System.Drawing.Point(80, 147)
		Me.txtNum.Margin = New System.Windows.Forms.Padding(8)
		Me.txtNum.MaxLength = 0
		Me.txtNum.Name = "txtNum"
		Me.txtNum.ReadOnly = True
		Me.txtNum.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtNum.Size = New System.Drawing.Size(146, 38)
		Me.txtNum.TabIndex = 39
		Me.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.ToolTip1.SetToolTip(Me.txtNum, "Numéro (invariable) de l'employé")
		'
		'cmdSuiv
		'
		Me.cmdSuiv.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSuiv.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSuiv.Enabled = False
		Me.cmdSuiv.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSuiv.Location = New System.Drawing.Point(634, 777)
		Me.cmdSuiv.Margin = New System.Windows.Forms.Padding(8)
		Me.cmdSuiv.Name = "cmdSuiv"
		Me.cmdSuiv.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSuiv.Size = New System.Drawing.Size(174, 60)
		Me.cmdSuiv.TabIndex = 37
		Me.cmdSuiv.Text = "Suivant"
		Me.ToolTip1.SetToolTip(Me.cmdSuiv, "Affiche le suivant")
		Me.cmdSuiv.UseVisualStyleBackColor = False
		'
		'cmdPrec
		'
		Me.cmdPrec.BackColor = System.Drawing.SystemColors.Control
		Me.cmdPrec.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPrec.Enabled = False
		Me.cmdPrec.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdPrec.Location = New System.Drawing.Point(378, 777)
		Me.cmdPrec.Margin = New System.Windows.Forms.Padding(8)
		Me.cmdPrec.Name = "cmdPrec"
		Me.cmdPrec.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdPrec.Size = New System.Drawing.Size(174, 60)
		Me.cmdPrec.TabIndex = 36
		Me.cmdPrec.Text = "Précédent"
		Me.ToolTip1.SetToolTip(Me.cmdPrec, "Affiche le précédent")
		Me.cmdPrec.UseVisualStyleBackColor = False
		'
		'cmdInver
		'
		Me.cmdInver.BackColor = System.Drawing.SystemColors.Control
		Me.cmdInver.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdInver.Enabled = False
		Me.cmdInver.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdInver.Location = New System.Drawing.Point(378, 701)
		Me.cmdInver.Margin = New System.Windows.Forms.Padding(8)
		Me.cmdInver.Name = "cmdInver"
		Me.cmdInver.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdInver.Size = New System.Drawing.Size(174, 60)
		Me.cmdInver.TabIndex = 35
		Me.cmdInver.Text = "Inverser"
		Me.ToolTip1.SetToolTip(Me.cmdInver, "Échange la position avec le précédent")
		Me.cmdInver.UseVisualStyleBackColor = False
		'
		'cmdDern
		'
		Me.cmdDern.BackColor = System.Drawing.SystemColors.Control
		Me.cmdDern.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdDern.Enabled = False
		Me.cmdDern.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdDern.Location = New System.Drawing.Point(890, 777)
		Me.cmdDern.Margin = New System.Windows.Forms.Padding(8)
		Me.cmdDern.Name = "cmdDern"
		Me.cmdDern.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdDern.Size = New System.Drawing.Size(174, 60)
		Me.cmdDern.TabIndex = 34
		Me.cmdDern.Text = "Dernier"
		Me.ToolTip1.SetToolTip(Me.cmdDern, "Affiche le dernier employé de la liste")
		Me.cmdDern.UseVisualStyleBackColor = False
		'
		'cmdPrem
		'
		Me.cmdPrem.BackColor = System.Drawing.SystemColors.Control
		Me.cmdPrem.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPrem.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdPrem.Location = New System.Drawing.Point(122, 777)
		Me.cmdPrem.Margin = New System.Windows.Forms.Padding(8)
		Me.cmdPrem.Name = "cmdPrem"
		Me.cmdPrem.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdPrem.Size = New System.Drawing.Size(174, 60)
		Me.cmdPrem.TabIndex = 33
		Me.cmdPrem.Text = "Premier"
		Me.ToolTip1.SetToolTip(Me.cmdPrem, "Affiche le premier de la liste")
		Me.cmdPrem.UseVisualStyleBackColor = False
		'
		'txtDate
		'
		Me.txtDate.BackColor = System.Drawing.SystemColors.Control
		Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDate.Cursor = System.Windows.Forms.Cursors.Default
		Me.txtDate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.txtDate.Location = New System.Drawing.Point(1040, 147)
		Me.txtDate.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
		Me.txtDate.Name = "txtDate"
		Me.txtDate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDate.Size = New System.Drawing.Size(152, 45)
		Me.txtDate.TabIndex = 63
		Me.ToolTip1.SetToolTip(Me.txtDate, "Nb années complètes")
		'
		'lblRevenu
		'
		Me.lblRevenu.BackColor = System.Drawing.SystemColors.Control
		Me.lblRevenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblRevenu.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblRevenu.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblRevenu.Location = New System.Drawing.Point(1040, 568)
		Me.lblRevenu.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
		Me.lblRevenu.Name = "lblRevenu"
		Me.lblRevenu.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblRevenu.Size = New System.Drawing.Size(280, 45)
		Me.lblRevenu.TabIndex = 55
		Me.ToolTip1.SetToolTip(Me.lblRevenu, "Salaire annuel + commission")
		'
		'txtTelephone
		'
		Me.txtTelephone.AcceptsReturn = True
		Me.txtTelephone.BackColor = System.Drawing.SystemColors.Window
		Me.txtTelephone.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTelephone.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTelephone.Location = New System.Drawing.Point(80, 358)
		Me.txtTelephone.Margin = New System.Windows.Forms.Padding(8)
		Me.txtTelephone.MaxLength = 0
		Me.txtTelephone.Name = "txtTelephone"
		Me.txtTelephone.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTelephone.Size = New System.Drawing.Size(210, 38)
		Me.txtTelephone.TabIndex = 59
		'
		'lstDept
		'
		Me.lstDept.BackColor = System.Drawing.SystemColors.Window
		Me.lstDept.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstDept.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstDept.ItemHeight = 31
		Me.lstDept.Items.AddRange(New Object() {"10", "20", "30", "40", "50", "60"})
		Me.lstDept.Location = New System.Drawing.Point(528, 395)
		Me.lstDept.Margin = New System.Windows.Forms.Padding(8)
		Me.lstDept.Name = "lstDept"
		Me.lstDept.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstDept.Size = New System.Drawing.Size(102, 190)
		Me.lstDept.TabIndex = 56
		'
		'optPasComm
		'
		Me.optPasComm.BackColor = System.Drawing.SystemColors.Control
		Me.optPasComm.Cursor = System.Windows.Forms.Cursors.Default
		Me.optPasComm.Enabled = False
		Me.optPasComm.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optPasComm.Location = New System.Drawing.Point(784, 473)
		Me.optPasComm.Margin = New System.Windows.Forms.Padding(8)
		Me.optPasComm.Name = "optPasComm"
		Me.optPasComm.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optPasComm.Size = New System.Drawing.Size(174, 60)
		Me.optPasComm.TabIndex = 51
		Me.optPasComm.TabStop = True
		Me.optPasComm.Text = "Non"
		Me.optPasComm.UseVisualStyleBackColor = False
		'
		'optComm
		'
		Me.optComm.BackColor = System.Drawing.SystemColors.Control
		Me.optComm.Cursor = System.Windows.Forms.Cursors.Default
		Me.optComm.Enabled = False
		Me.optComm.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optComm.Location = New System.Drawing.Point(784, 415)
		Me.optComm.Margin = New System.Windows.Forms.Padding(8)
		Me.optComm.Name = "optComm"
		Me.optComm.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optComm.Size = New System.Drawing.Size(174, 60)
		Me.optComm.TabIndex = 50
		Me.optComm.TabStop = True
		Me.optComm.Text = "Oui"
		Me.optComm.UseVisualStyleBackColor = False
		'
		'txtNom
		'
		Me.txtNom.AcceptsReturn = True
		Me.txtNom.BackColor = System.Drawing.SystemColors.Window
		Me.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNom.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtNom.Location = New System.Drawing.Point(80, 262)
		Me.txtNom.Margin = New System.Windows.Forms.Padding(8)
		Me.txtNom.MaxLength = 0
		Me.txtNom.Name = "txtNom"
		Me.txtNom.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtNom.Size = New System.Drawing.Size(358, 38)
		Me.txtNom.TabIndex = 38
		'
		'Label15
		'
		Me.Label15.BackColor = System.Drawing.SystemColors.Control
		Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label15.Location = New System.Drawing.Point(528, 225)
		Me.Label15.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
		Me.Label15.Name = "Label15"
		Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label15.Size = New System.Drawing.Size(152, 41)
		Me.Label15.TabIndex = 65
		Me.Label15.Text = "Rang"
		'
		'Label9
		'
		Me.Label9.BackColor = System.Drawing.SystemColors.Control
		Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label9.Location = New System.Drawing.Point(656, 663)
		Me.Label9.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
		Me.Label9.Name = "Label9"
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.Size = New System.Drawing.Size(258, 41)
		Me.Label9.TabIndex = 61
		Me.Label9.Text = "Nom du patron"
		'
		'Label14
		'
		Me.Label14.BackColor = System.Drawing.SystemColors.Control
		Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label14.Location = New System.Drawing.Point(80, 320)
		Me.Label14.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
		Me.Label14.Name = "Label14"
		Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label14.Size = New System.Drawing.Size(170, 41)
		Me.Label14.TabIndex = 60
		Me.Label14.Text = "Téléphone"
		'
		'Label13
		'
		Me.Label13.BackColor = System.Drawing.SystemColors.Control
		Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label13.Location = New System.Drawing.Point(742, 358)
		Me.Label13.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
		Me.Label13.Name = "Label13"
		Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label13.Size = New System.Drawing.Size(234, 41)
		Me.Label13.TabIndex = 58
		Me.Label13.Text = "A commission ?"
		'
		'Label10
		'
		Me.Label10.BackColor = System.Drawing.SystemColors.Control
		Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label10.Location = New System.Drawing.Point(506, 358)
		Me.Label10.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
		Me.Label10.Name = "Label10"
		Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label10.Size = New System.Drawing.Size(194, 41)
		Me.Label10.TabIndex = 57
		Me.Label10.Text = "Département"
		'
		'Label8
		'
		Me.Label8.BackColor = System.Drawing.SystemColors.Control
		Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Location = New System.Drawing.Point(1040, 529)
		Me.Label8.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.Size = New System.Drawing.Size(258, 41)
		Me.Label8.TabIndex = 54
		Me.Label8.Text = "Revenu annuel"
		'
		'Label7
		'
		Me.Label7.BackColor = System.Drawing.SystemColors.Control
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Location = New System.Drawing.Point(1040, 376)
		Me.Label7.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.Size = New System.Drawing.Size(192, 41)
		Me.Label7.TabIndex = 53
		Me.Label7.Text = "Commission"
		'
		'Label6
		'
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Location = New System.Drawing.Point(1040, 244)
		Me.Label6.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.Size = New System.Drawing.Size(152, 41)
		Me.Label6.TabIndex = 49
		Me.Label6.Text = "Salaire"
		'
		'Label5
		'
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Location = New System.Drawing.Point(1040, 110)
		Me.Label5.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.Size = New System.Drawing.Size(258, 41)
		Me.Label5.TabIndex = 47
		Me.Label5.Text = "Années de service"
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Location = New System.Drawing.Point(358, 110)
		Me.Label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.Size = New System.Drawing.Size(110, 41)
		Me.Label4.TabIndex = 45
		Me.Label4.Text = "Poste"
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Location = New System.Drawing.Point(720, 110)
		Me.Label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.Size = New System.Drawing.Size(238, 41)
		Me.Label3.TabIndex = 43
		Me.Label3.Text = "Date Embauche"
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Location = New System.Drawing.Point(80, 225)
		Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.Size = New System.Drawing.Size(152, 41)
		Me.Label2.TabIndex = 41
		Me.Label2.Text = "Nom"
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Location = New System.Drawing.Point(80, 110)
		Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.Size = New System.Drawing.Size(152, 41)
		Me.Label1.TabIndex = 40
		Me.Label1.Text = "Numéro"
		'
		'frmEmploye
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1400, 944)
		Me.Controls.Add(Me.txtRang)
		Me.Controls.Add(Me.txtPatron)
		Me.Controls.Add(Me.txtTelephone)
		Me.Controls.Add(Me.lstDept)
		Me.Controls.Add(Me.txtComm)
		Me.Controls.Add(Me.optPasComm)
		Me.Controls.Add(Me.optComm)
		Me.Controls.Add(Me.txtSalaire)
		Me.Controls.Add(Me.cmdQuit)
		Me.Controls.Add(Me.cboPoste)
		Me.Controls.Add(Me.txtDateEmb)
		Me.Controls.Add(Me.txtNum)
		Me.Controls.Add(Me.txtNom)
		Me.Controls.Add(Me.cmdSuiv)
		Me.Controls.Add(Me.cmdPrec)
		Me.Controls.Add(Me.cmdInver)
		Me.Controls.Add(Me.cmdDern)
		Me.Controls.Add(Me.cmdPrem)
		Me.Controls.Add(Me.Label15)
		Me.Controls.Add(Me.txtDate)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.Label14)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.lblRevenu)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Enabled = False
		Me.Margin = New System.Windows.Forms.Padding(8)
		Me.Name = "frmEmploye"
		Me.Text = "frmEmpl"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents txtRang As System.Windows.Forms.TextBox
    Public WithEvents txtPatron As System.Windows.Forms.TextBox
    Public WithEvents txtTelephone As System.Windows.Forms.TextBox
    Public WithEvents lstDept As System.Windows.Forms.ListBox
    Public WithEvents txtComm As System.Windows.Forms.TextBox
    Public WithEvents optPasComm As System.Windows.Forms.RadioButton
    Public WithEvents optComm As System.Windows.Forms.RadioButton
    Public WithEvents txtSalaire As System.Windows.Forms.TextBox
    Public WithEvents cmdQuit As System.Windows.Forms.Button
    Public WithEvents cboPoste As System.Windows.Forms.ComboBox
    Public WithEvents txtDateEmb As System.Windows.Forms.TextBox
    Public WithEvents txtNum As System.Windows.Forms.TextBox
    Public WithEvents txtNom As System.Windows.Forms.TextBox
    Public WithEvents cmdSuiv As System.Windows.Forms.Button
    Public WithEvents cmdPrec As System.Windows.Forms.Button
    Public WithEvents cmdInver As System.Windows.Forms.Button
    Public WithEvents cmdDern As System.Windows.Forms.Button
    Public WithEvents cmdPrem As System.Windows.Forms.Button
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents txtDate As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents lblRevenu As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
End Class
