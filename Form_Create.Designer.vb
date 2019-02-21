<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Create
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Create))
        Me.LBL_ID = New System.Windows.Forms.Label
        Me.TXT_ID = New System.Windows.Forms.TextBox
        Me.LBL_SERVICE = New System.Windows.Forms.Label
        Me.LBL_MDP = New System.Windows.Forms.Label
        Me.TXT_MDP = New System.Windows.Forms.TextBox
        Me.LBL_CONF = New System.Windows.Forms.Label
        Me.TXT_CONF = New System.Windows.Forms.TextBox
        Me.LBL_CREATE = New System.Windows.Forms.Label
        Me.BT_VALIDE = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TXT_PRENOM = New System.Windows.Forms.TextBox
        Me.PBOX1 = New System.Windows.Forms.PictureBox
        Me.PBOX2 = New System.Windows.Forms.PictureBox
        Me.TTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CBOX_SERVICE = New System.Windows.Forms.ComboBox
        CType(Me.PBOX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBOX2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBL_ID
        '
        Me.LBL_ID.AutoSize = True
        Me.LBL_ID.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.LBL_ID.Location = New System.Drawing.Point(137, 122)
        Me.LBL_ID.Name = "LBL_ID"
        Me.LBL_ID.Size = New System.Drawing.Size(47, 19)
        Me.LBL_ID.TabIndex = 5
        Me.LBL_ID.Text = "Nom :"
        '
        'TXT_ID
        '
        Me.TXT_ID.Location = New System.Drawing.Point(190, 122)
        Me.TXT_ID.Multiline = True
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.Size = New System.Drawing.Size(258, 18)
        Me.TXT_ID.TabIndex = 7
        Me.TXT_ID.Text = "Tapez votre nom"
        '
        'LBL_SERVICE
        '
        Me.LBL_SERVICE.AutoSize = True
        Me.LBL_SERVICE.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.LBL_SERVICE.Location = New System.Drawing.Point(121, 189)
        Me.LBL_SERVICE.Name = "LBL_SERVICE"
        Me.LBL_SERVICE.Size = New System.Drawing.Size(63, 19)
        Me.LBL_SERVICE.TabIndex = 8
        Me.LBL_SERVICE.Text = "Service :"
        '
        'LBL_MDP
        '
        Me.LBL_MDP.AutoSize = True
        Me.LBL_MDP.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.LBL_MDP.Location = New System.Drawing.Point(79, 219)
        Me.LBL_MDP.Name = "LBL_MDP"
        Me.LBL_MDP.Size = New System.Drawing.Size(105, 19)
        Me.LBL_MDP.TabIndex = 10
        Me.LBL_MDP.Text = "Mot de passe :"
        '
        'TXT_MDP
        '
        Me.TXT_MDP.Location = New System.Drawing.Point(190, 220)
        Me.TXT_MDP.Name = "TXT_MDP"
        Me.TXT_MDP.Size = New System.Drawing.Size(258, 20)
        Me.TXT_MDP.TabIndex = 11
        Me.TXT_MDP.Text = "Tapez votre mot de passe"
        '
        'LBL_CONF
        '
        Me.LBL_CONF.AutoSize = True
        Me.LBL_CONF.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.LBL_CONF.Location = New System.Drawing.Point(84, 253)
        Me.LBL_CONF.Name = "LBL_CONF"
        Me.LBL_CONF.Size = New System.Drawing.Size(100, 19)
        Me.LBL_CONF.TabIndex = 13
        Me.LBL_CONF.Text = "Confirmation :"
        '
        'TXT_CONF
        '
        Me.TXT_CONF.Location = New System.Drawing.Point(190, 254)
        Me.TXT_CONF.Name = "TXT_CONF"
        Me.TXT_CONF.Size = New System.Drawing.Size(258, 20)
        Me.TXT_CONF.TabIndex = 14
        Me.TXT_CONF.Text = "Confirmez votre mot de passe"
        '
        'LBL_CREATE
        '
        Me.LBL_CREATE.AutoSize = True
        Me.LBL_CREATE.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.LBL_CREATE.Location = New System.Drawing.Point(12, 43)
        Me.LBL_CREATE.Name = "LBL_CREATE"
        Me.LBL_CREATE.Size = New System.Drawing.Size(263, 33)
        Me.LBL_CREATE.TabIndex = 15
        Me.LBL_CREATE.Text = "Création d'un compte :"
        '
        'BT_VALIDE
        '
        Me.BT_VALIDE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_VALIDE.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.BT_VALIDE.Location = New System.Drawing.Point(209, 306)
        Me.BT_VALIDE.Name = "BT_VALIDE"
        Me.BT_VALIDE.Size = New System.Drawing.Size(154, 37)
        Me.BT_VALIDE.TabIndex = 16
        Me.BT_VALIDE.Text = "Valider"
        Me.BT_VALIDE.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(118, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 19)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Prénom :"
        '
        'TXT_PRENOM
        '
        Me.TXT_PRENOM.Location = New System.Drawing.Point(190, 154)
        Me.TXT_PRENOM.Name = "TXT_PRENOM"
        Me.TXT_PRENOM.Size = New System.Drawing.Size(258, 20)
        Me.TXT_PRENOM.TabIndex = 8
        Me.TXT_PRENOM.Text = "Tapez votre prénom"
        '
        'PBOX1
        '
        Me.PBOX1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBOX1.Image = CType(resources.GetObject("PBOX1.Image"), System.Drawing.Image)
        Me.PBOX1.Location = New System.Drawing.Point(454, 220)
        Me.PBOX1.Name = "PBOX1"
        Me.PBOX1.Size = New System.Drawing.Size(22, 20)
        Me.PBOX1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBOX1.TabIndex = 18
        Me.PBOX1.TabStop = False
        '
        'PBOX2
        '
        Me.PBOX2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBOX2.Image = CType(resources.GetObject("PBOX2.Image"), System.Drawing.Image)
        Me.PBOX2.Location = New System.Drawing.Point(454, 254)
        Me.PBOX2.Name = "PBOX2"
        Me.PBOX2.Size = New System.Drawing.Size(22, 20)
        Me.PBOX2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBOX2.TabIndex = 19
        Me.PBOX2.TabStop = False
        '
        'CBOX_SERVICE
        '
        Me.CBOX_SERVICE.FormattingEnabled = True
        Me.CBOX_SERVICE.Location = New System.Drawing.Point(190, 186)
        Me.CBOX_SERVICE.Name = "CBOX_SERVICE"
        Me.CBOX_SERVICE.Size = New System.Drawing.Size(258, 21)
        Me.CBOX_SERVICE.TabIndex = 9
        Me.CBOX_SERVICE.Text = "Tapez votre service"
        '
        'Form_Create
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(498, 382)
        Me.Controls.Add(Me.CBOX_SERVICE)
        Me.Controls.Add(Me.PBOX2)
        Me.Controls.Add(Me.PBOX1)
        Me.Controls.Add(Me.TXT_PRENOM)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BT_VALIDE)
        Me.Controls.Add(Me.LBL_CREATE)
        Me.Controls.Add(Me.TXT_CONF)
        Me.Controls.Add(Me.LBL_CONF)
        Me.Controls.Add(Me.TXT_MDP)
        Me.Controls.Add(Me.LBL_MDP)
        Me.Controls.Add(Me.LBL_SERVICE)
        Me.Controls.Add(Me.TXT_ID)
        Me.Controls.Add(Me.LBL_ID)
        Me.Name = "Form_Create"
        Me.Text = "Création de compte"
        CType(Me.PBOX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBOX2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBL_ID As System.Windows.Forms.Label
    Friend WithEvents TXT_ID As System.Windows.Forms.TextBox
    Friend WithEvents LBL_SERVICE As System.Windows.Forms.Label
    Friend WithEvents LBL_MDP As System.Windows.Forms.Label
    Friend WithEvents TXT_MDP As System.Windows.Forms.TextBox
    Friend WithEvents LBL_CONF As System.Windows.Forms.Label
    Friend WithEvents TXT_CONF As System.Windows.Forms.TextBox
    Friend WithEvents LBL_CREATE As System.Windows.Forms.Label
    Friend WithEvents BT_VALIDE As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_PRENOM As System.Windows.Forms.TextBox
    Friend WithEvents PBOX1 As System.Windows.Forms.PictureBox
    Friend WithEvents PBOX2 As System.Windows.Forms.PictureBox
    Friend WithEvents TTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents CBOX_SERVICE As System.Windows.Forms.ComboBox
End Class
