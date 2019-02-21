<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Modify
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
        Me.LBL_MODIFY = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.BT_ADDROW = New System.Windows.Forms.Button
        Me.BT_DELETEROW = New System.Windows.Forms.Button
        Me.BT_UPD = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.CBOX_SEARCH = New System.Windows.Forms.ComboBox
        Me.TXT_SEARCH = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.BT_SEARCH = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBL_MODIFY
        '
        Me.LBL_MODIFY.AutoSize = True
        Me.LBL_MODIFY.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.LBL_MODIFY.Location = New System.Drawing.Point(367, 24)
        Me.LBL_MODIFY.Name = "LBL_MODIFY"
        Me.LBL_MODIFY.Size = New System.Drawing.Size(275, 33)
        Me.LBL_MODIFY.TabIndex = 0
        Me.LBL_MODIFY.Text = "Modification de compte"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.Location = New System.Drawing.Point(18, 122)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(957, 436)
        Me.DataGridView1.TabIndex = 1
        '
        'BT_ADDROW
        '
        Me.BT_ADDROW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_ADDROW.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.BT_ADDROW.Location = New System.Drawing.Point(707, 160)
        Me.BT_ADDROW.Name = "BT_ADDROW"
        Me.BT_ADDROW.Size = New System.Drawing.Size(191, 41)
        Me.BT_ADDROW.TabIndex = 2
        Me.BT_ADDROW.Text = "Rajouter une ligne"
        Me.BT_ADDROW.UseVisualStyleBackColor = True
        '
        'BT_DELETEROW
        '
        Me.BT_DELETEROW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_DELETEROW.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.BT_DELETEROW.Location = New System.Drawing.Point(707, 260)
        Me.BT_DELETEROW.Name = "BT_DELETEROW"
        Me.BT_DELETEROW.Size = New System.Drawing.Size(191, 59)
        Me.BT_DELETEROW.TabIndex = 3
        Me.BT_DELETEROW.Text = "Supprimer la ligne sélectionnée"
        Me.BT_DELETEROW.UseVisualStyleBackColor = True
        '
        'BT_UPD
        '
        Me.BT_UPD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_UPD.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.BT_UPD.Location = New System.Drawing.Point(707, 373)
        Me.BT_UPD.Name = "BT_UPD"
        Me.BT_UPD.Size = New System.Drawing.Size(191, 46)
        Me.BT_UPD.TabIndex = 4
        Me.BT_UPD.Text = "Modifier la ligne"
        Me.BT_UPD.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(707, 472)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 46)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Actualiser"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(43, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Rechercher :"
        '
        'CBOX_SEARCH
        '
        Me.CBOX_SEARCH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOX_SEARCH.FormattingEnabled = True
        Me.CBOX_SEARCH.Items.AddRange(New Object() {"Nom", "Prénom", "Service"})
        Me.CBOX_SEARCH.Location = New System.Drawing.Point(413, 92)
        Me.CBOX_SEARCH.Name = "CBOX_SEARCH"
        Me.CBOX_SEARCH.Size = New System.Drawing.Size(192, 21)
        Me.CBOX_SEARCH.TabIndex = 9
        '
        'TXT_SEARCH
        '
        Me.TXT_SEARCH.Location = New System.Drawing.Point(139, 92)
        Me.TXT_SEARCH.Name = "TXT_SEARCH"
        Me.TXT_SEARCH.Size = New System.Drawing.Size(203, 20)
        Me.TXT_SEARCH.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(357, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Dans :"
        '
        'BT_SEARCH
        '
        Me.BT_SEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_SEARCH.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.BT_SEARCH.Location = New System.Drawing.Point(650, 85)
        Me.BT_SEARCH.Name = "BT_SEARCH"
        Me.BT_SEARCH.Size = New System.Drawing.Size(135, 31)
        Me.BT_SEARCH.TabIndex = 10
        Me.BT_SEARCH.Text = "Rechercher"
        Me.BT_SEARCH.UseVisualStyleBackColor = True
        '
        'Form_Modify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(999, 581)
        Me.Controls.Add(Me.BT_SEARCH)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_SEARCH)
        Me.Controls.Add(Me.CBOX_SEARCH)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BT_UPD)
        Me.Controls.Add(Me.BT_DELETEROW)
        Me.Controls.Add(Me.BT_ADDROW)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LBL_MODIFY)
        Me.Name = "Form_Modify"
        Me.Text = "Gestion des comptes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBL_MODIFY As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BT_ADDROW As System.Windows.Forms.Button
    Friend WithEvents BT_DELETEROW As System.Windows.Forms.Button
    Friend WithEvents BT_UPD As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBOX_SEARCH As System.Windows.Forms.ComboBox
    Friend WithEvents TXT_SEARCH As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BT_SEARCH As System.Windows.Forms.Button
End Class
