<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ModifyPopup
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.TXT_ID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TXT_PRENOM = New System.Windows.Forms.TextBox
        Me.CBOX_SERVICE = New System.Windows.Forms.ComboBox
        Me.TXT_MDP = New System.Windows.Forms.TextBox
        Me.BT_SAVE = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(200, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Modification du compte"
        '
        'TXT_ID
        '
        Me.TXT_ID.Location = New System.Drawing.Point(132, 96)
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.Size = New System.Drawing.Size(129, 20)
        Me.TXT_ID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(60, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nom :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(41, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Prenom :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(379, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Service :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(337, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Mot de passe :"
        '
        'TXT_PRENOM
        '
        Me.TXT_PRENOM.Location = New System.Drawing.Point(132, 181)
        Me.TXT_PRENOM.Name = "TXT_PRENOM"
        Me.TXT_PRENOM.Size = New System.Drawing.Size(129, 20)
        Me.TXT_PRENOM.TabIndex = 6
        '
        'CBOX_SERVICE
        '
        Me.CBOX_SERVICE.FormattingEnabled = True
        Me.CBOX_SERVICE.Location = New System.Drawing.Point(465, 98)
        Me.CBOX_SERVICE.Name = "CBOX_SERVICE"
        Me.CBOX_SERVICE.Size = New System.Drawing.Size(152, 21)
        Me.CBOX_SERVICE.TabIndex = 7
        '
        'TXT_MDP
        '
        Me.TXT_MDP.Location = New System.Drawing.Point(465, 181)
        Me.TXT_MDP.Name = "TXT_MDP"
        Me.TXT_MDP.Size = New System.Drawing.Size(152, 20)
        Me.TXT_MDP.TabIndex = 8
        '
        'BT_SAVE
        '
        Me.BT_SAVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_SAVE.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.BT_SAVE.Location = New System.Drawing.Point(206, 256)
        Me.BT_SAVE.Name = "BT_SAVE"
        Me.BT_SAVE.Size = New System.Drawing.Size(236, 47)
        Me.BT_SAVE.TabIndex = 9
        Me.BT_SAVE.Text = "Enregistrer les modifications"
        Me.BT_SAVE.UseVisualStyleBackColor = True
        '
        'Frm_ModifyPopup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(654, 340)
        Me.Controls.Add(Me.BT_SAVE)
        Me.Controls.Add(Me.TXT_MDP)
        Me.Controls.Add(Me.CBOX_SERVICE)
        Me.Controls.Add(Me.TXT_PRENOM)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_ID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_ModifyPopup"
        Me.Text = "Frm_ModifyPopup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXT_PRENOM As System.Windows.Forms.TextBox
    Friend WithEvents CBOX_SERVICE As System.Windows.Forms.ComboBox
    Friend WithEvents TXT_MDP As System.Windows.Forms.TextBox
    Friend WithEvents BT_SAVE As System.Windows.Forms.Button
End Class
