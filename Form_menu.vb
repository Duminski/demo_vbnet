Public Class Form_menu

    'Affichage de Form 1
    Private Sub FormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormToolStripMenuItem.Click

        ExitedForm = Me
        Frm_1.Show()
        Me.Close()

    End Sub
    'Affichage d'accès utilisateur
    Private Sub FrmgestionUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrmgestionUserToolStripMenuItem.Click

        Frm_gestionUser.Show()
        Me.Close()

    End Sub

End Class




