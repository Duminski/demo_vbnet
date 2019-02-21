<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AddPopup
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
        Me.TXT_ID = New System.Windows.Forms.TextBox
        Me.TXT_PRENOM = New System.Windows.Forms.TextBox
        Me.TXT_MDP = New System.Windows.Forms.TextBox
        Me.CBOX_SERVICE = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.BT_ADD = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TXT_ID
        '
        Me.TXT_ID.Location = New System.Drawing.Point(143, 73)
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.Size = New System.Drawing.Size(143, 20)
        Me.TXT_ID.TabIndex = 0
        Me.TXT_ID.Text = "Tapez votre nom"
        '
        'TXT_PRENOM
        '
        Me.TXT_PRENOM.Location = New System.Drawing.Point(143, 126)
        Me.TXT_PRENOM.Name = "TXT_PRENOM"
        Me.TXT_PRENOM.Size = New System.Drawing.Size(143, 20)
        Me.TXT_PRENOM.TabIndex = 1
        Me.TXT_PRENOM.Text = "Tapez votre prénom"
        '
        'TXT_MDP
        '
        Me.TXT_MDP.Location = New System.Drawing.Point(143, 235)
        Me.TXT_MDP.Name = "TXT_MDP"
        Me.TXT_MDP.Size = New System.Drawing.Size(143, 20)
        Me.TXT_MDP.TabIndex = 3
        Me.TXT_MDP.Text = "Tapez votre mot de passe"
        '
        'CBOX_SERVICE
        '
        Me.CBOX_SERVICE.FormattingEnabled = True
        Me.CBOX_SERVICE.Location = New System.Drawing.Point(143, 178)
        Me.CBOX_SERVICE.Name = "CBOX_SERVICE"
        Me.CBOX_SERVICE.Size = New System.Drawing.Size(143, 21)
        Me.CBOX_SERVICE.TabIndex = 2
        Me.CBOX_SERVICE.Text = "Tapez votre service"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(68, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 33)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ajout de compte"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(70, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nom :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(51, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Prénom :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(54, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Service :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(12, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Mot de passe :"
        '
        'BT_ADD
        '
        Me.BT_ADD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_ADD.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.BT_ADD.Location = New System.Drawing.Point(68, 291)
        Me.BT_ADD.Name = "BT_ADD"
        Me.BT_ADD.Size = New System.Drawing.Size(201, 38)
        Me.BT_ADD.TabIndex = 9
        Me.BT_ADD.Text = "Valider"
        Me.BT_ADD.UseVisualStyleBackColor = True
        '
        'Frm_AddPopup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(338, 356)
        Me.Controls.Add(Me.BT_ADD)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBOX_SERVICE)
        Me.Controls.Add(Me.TXT_MDP)
        Me.Controls.Add(Me.TXT_PRENOM)
        Me.Controls.Add(Me.TXT_ID)
        Me.Name = "Frm_AddPopup"
        Me.Text = "Frm_AddPopup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_ID As System.Windows.Forms.TextBox
    Friend WithEvents TXT_PRENOM As System.Windows.Forms.TextBox
    Friend WithEvents TXT_MDP As System.Windows.Forms.TextBox
    Friend WithEvents CBOX_SERVICE As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BT_ADD As System.Windows.Forms.Button
End Class
