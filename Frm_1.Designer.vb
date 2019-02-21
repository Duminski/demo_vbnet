<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_1
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
        Me.BT_PREVIOUS = New System.Windows.Forms.Button
        Me.BT_MENU = New System.Windows.Forms.Button
        Me.PBOX = New System.Windows.Forms.PictureBox
        CType(Me.PBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BT_PREVIOUS
        '
        Me.BT_PREVIOUS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_PREVIOUS.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.BT_PREVIOUS.Location = New System.Drawing.Point(102, 65)
        Me.BT_PREVIOUS.Name = "BT_PREVIOUS"
        Me.BT_PREVIOUS.Size = New System.Drawing.Size(179, 59)
        Me.BT_PREVIOUS.TabIndex = 2
        Me.BT_PREVIOUS.Text = "Retour à la page précédente"
        Me.BT_PREVIOUS.UseVisualStyleBackColor = True
        '
        'BT_MENU
        '
        Me.BT_MENU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_MENU.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_MENU.Location = New System.Drawing.Point(102, 165)
        Me.BT_MENU.Name = "BT_MENU"
        Me.BT_MENU.Size = New System.Drawing.Size(179, 59)
        Me.BT_MENU.TabIndex = 3
        Me.BT_MENU.Text = "Retour au menu"
        Me.BT_MENU.UseVisualStyleBackColor = True
        '
        'PBOX
        '
        Me.PBOX.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBOX.Image = Global.ProjetDemo.My.Resources.Resources.PR_ProDe
        Me.PBOX.Location = New System.Drawing.Point(109, 244)
        Me.PBOX.Name = "PBOX"
        Me.PBOX.Size = New System.Drawing.Size(163, 144)
        Me.PBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBOX.TabIndex = 5
        Me.PBOX.TabStop = False
        '
        'Frm_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(389, 401)
        Me.Controls.Add(Me.PBOX)
        Me.Controls.Add(Me.BT_MENU)
        Me.Controls.Add(Me.BT_PREVIOUS)
        Me.Name = "Frm_1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        CType(Me.PBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BT_PREVIOUS As System.Windows.Forms.Button
    Friend WithEvents BT_MENU As System.Windows.Forms.Button
    Friend WithEvents PBOX As System.Windows.Forms.PictureBox
End Class
