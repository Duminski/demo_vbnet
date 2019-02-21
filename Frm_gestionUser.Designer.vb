<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_gestionUser
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Form3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BT_CREATEACC = New System.Windows.Forms.Button
        Me.BT_MODIFY = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormToolStripMenuItem, Me.MenuToolStripMenuItem, Me.Form3ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(534, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FormToolStripMenuItem
        '
        Me.FormToolStripMenuItem.Name = "FormToolStripMenuItem"
        Me.FormToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.FormToolStripMenuItem.Text = "Form"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.MenuToolStripMenuItem.Text = "Form 2"
        '
        'Form3ToolStripMenuItem
        '
        Me.Form3ToolStripMenuItem.Name = "Form3ToolStripMenuItem"
        Me.Form3ToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.Form3ToolStripMenuItem.Text = "Form 3"
        '
        'BT_CREATEACC
        '
        Me.BT_CREATEACC.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.BT_CREATEACC.Location = New System.Drawing.Point(141, 122)
        Me.BT_CREATEACC.Name = "BT_CREATEACC"
        Me.BT_CREATEACC.Size = New System.Drawing.Size(246, 81)
        Me.BT_CREATEACC.TabIndex = 14
        Me.BT_CREATEACC.Text = "Créer un compte"
        Me.BT_CREATEACC.UseVisualStyleBackColor = True
        '
        'BT_MODIFY
        '
        Me.BT_MODIFY.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.BT_MODIFY.Location = New System.Drawing.Point(141, 286)
        Me.BT_MODIFY.Name = "BT_MODIFY"
        Me.BT_MODIFY.Size = New System.Drawing.Size(246, 81)
        Me.BT_MODIFY.TabIndex = 15
        Me.BT_MODIFY.Text = "Modifier un compte"
        Me.BT_MODIFY.UseVisualStyleBackColor = True
        '
        'Frm_gestionUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(534, 523)
        Me.Controls.Add(Me.BT_MODIFY)
        Me.Controls.Add(Me.BT_CREATEACC)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_gestionUser"
        Me.Text = "Accès utilisateur"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Form3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BT_CREATEACC As System.Windows.Forms.Button
    Friend WithEvents BT_MODIFY As System.Windows.Forms.Button
End Class
