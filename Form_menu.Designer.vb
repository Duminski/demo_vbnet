<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_menu
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
        Me.FrmgestionUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LBL_MENU = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormToolStripMenuItem, Me.FrmgestionUserToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(311, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FormToolStripMenuItem
        '
        Me.FormToolStripMenuItem.Name = "FormToolStripMenuItem"
        Me.FormToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.FormToolStripMenuItem.Text = "Form"
        '
        'FrmgestionUserToolStripMenuItem
        '
        Me.FrmgestionUserToolStripMenuItem.Name = "FrmgestionUserToolStripMenuItem"
        Me.FrmgestionUserToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.FrmgestionUserToolStripMenuItem.Text = "Accès utilisateur"
        '
        'LBL_MENU
        '
        Me.LBL_MENU.AutoSize = True
        Me.LBL_MENU.Font = New System.Drawing.Font("Calibri", 36.0!)
        Me.LBL_MENU.ForeColor = System.Drawing.Color.White
        Me.LBL_MENU.Location = New System.Drawing.Point(85, 208)
        Me.LBL_MENU.Name = "LBL_MENU"
        Me.LBL_MENU.Size = New System.Drawing.Size(140, 59)
        Me.LBL_MENU.TabIndex = 2
        Me.LBL_MENU.Text = "Menu"
        '
        'Form_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(311, 476)
        Me.Controls.Add(Me.LBL_MENU)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form_menu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FrmgestionUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LBL_MENU As System.Windows.Forms.Label

End Class
