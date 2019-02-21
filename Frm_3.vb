Public Class Frm_3

    'Lancement de toutes les Frm_X existantes + Positionnement
    Private Sub Frm_3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Location = New Point(500, 500)

        Frm_2.Show()
        Frm_2.Location = New Point(250, 250)

        Frm_1.Show()
        Frm_1.Location = New Point(0, 0)

    End Sub
    'Bouton Retour au menu
    Private Sub BT_MENU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_MENU.Click

        Form_menu.Show()
        Me.Close()

    End Sub
    'Bouton Retour à la page précédente
    Private Sub BT_PREVIOUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_PREVIOUS.Click

        Frm_gestionUser.Show()
        Me.Close()

    End Sub
    'Changement des images des forms
    Private Sub PBOXCI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBOX.Click

        swapPbox(PBOX)

    End Sub

End Class