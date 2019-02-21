Public Class Frm_1

    'Lancement de toutes les Frm_X existantes + Positionnement
    Private Sub Frm_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Location = New Point(0, 0)

        Frm_2.Show()
        Frm_2.Location = New Point(250, 250)

        Frm_3.Show()
        Frm_3.Location = New Point(500, 500)
        'swapPbox(PBOX)

    End Sub
    'Bouton Retour à la page précédente
    Public Sub BT_PREVIOUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_PREVIOUS.Click

        If ExitedForm Is Frm_gestionUser Then

            Frm_gestionUser.Show()
            Me.Close()

        Else

            Form_menu.Show()
            Me.Close()

        End If

    End Sub
    'Bouton Retour au menu
    Private Sub BT_MENU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_MENU.Click

        Form_menu.Show()
        Me.Close()

    End Sub
    'Changement des images des forms
    Private Sub PBOX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBOX.Click

        swapPbox(PBOX)

    End Sub
 
End Class
