Public Class Frm_gestionUser

    'Changement de curseur
    Private Sub BT_CREATEACC_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_CREATEACC.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub BT_MODIFY_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_MODIFY.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub Frm_gestionUser_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        Me.Cursor = Cursors.Arrow
    End Sub
    'Affichage de Form 1
    Private Sub FormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormToolStripMenuItem.Click

        ExitedForm = Me
        Frm_1.Show()
        Me.Close()

    End Sub
    'Affichage de Form 2
    Private Sub MenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuToolStripMenuItem.Click

        Frm_2.Show()
        Me.Close()

    End Sub
    'Affichage de Form 3
    Private Sub Form3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Form3ToolStripMenuItem.Click

        Frm_3.Show()
        Me.Close()

    End Sub
    'Ouvre la fenêtre de création d'utilisateur
    Private Sub BT_CREATEACC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_CREATEACC.Click

        Form_Create.ShowDialog()

    End Sub
    'Ouvre la fenêtre de modification d'utilisateur
    Private Sub BT_MODIFY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_MODIFY.Click

        Form_Modify.ShowDialog()

    End Sub

End Class