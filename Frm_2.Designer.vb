<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_2))
        Me.Button2 = New System.Windows.Forms.Button
        Me.BT_MENU = New System.Windows.Forms.Button
        Me.PBOX = New System.Windows.Forms.PictureBox
        CType(Me.PBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Button2.Location = New System.Drawing.Point(102, 65)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(179, 59)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Retour à la page précédente"
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.PBOX.Image = CType(resources.GetObject("PBOX.Image"), System.Drawing.Image)
        Me.PBOX.Location = New System.Drawing.Point(109, 244)
        Me.PBOX.Name = "PBOX"
        Me.PBOX.Size = New System.Drawing.Size(163, 144)
        Me.PBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBOX.TabIndex = 5
        Me.PBOX.TabStop = False
        '
        'Frm_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(389, 401)
        Me.Controls.Add(Me.PBOX)
        Me.Controls.Add(Me.BT_MENU)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Frm_2"
        Me.Text = "Form2"
        CType(Me.PBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BT_MENU As System.Windows.Forms.Button
    Friend WithEvents PBOX As System.Windows.Forms.PictureBox
End Class
