Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class Form_Modify

    'Initialisation de la grille par la fonction initData
    Public Sub Form_Modify_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sqlQuery = "SELECT Login.ID, Nom, Prenom, Mdp, Service FROM Login INNER JOIN Service ON Login.ID_Service = Service.ID;"
        InitData(sqlQuery)

    End Sub
    'Bouton Ajouter une ligne
    Private Sub BT_ADDROW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_ADDROW.Click

        Frm_AddPopup.ShowDialog()

    End Sub
    'Bouton Update (base de données)
    Private Sub BT_UPD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_UPD.Click

        Frm_ModifyPopup.ShowDialog()

    End Sub
    'Bouton Supprimer une ligne
    Private Sub BT_DELETEROW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_DELETEROW.Click

        Dim cmdDel As SqlCommand

        If MessageBox.Show("Êtes-vous sûr de vouloir supprimer  le compte sélectionné ? ", "Critical Warning", _
                MessageBoxButtons.YesNo, _
                MessageBoxIcon.Warning, _
                MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

            cmdDel = New SqlCommand(sqlQuery, myConn)

            sqlQuery = "DELETE FROM Login WHERE ID='" & DataGridView1.CurrentRow.Cells(0).Value & "';"

            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)

            exNonQuerryDel(sqlQuery)

        End If

    End Sub
    'Bouton de recherche dans la base de données
    Private Sub BT_SEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_SEARCH.Click

        If CBOX_SEARCH.SelectedItem = "Nom" Then

            sqlQuery = "SELECT Login.ID, Nom, Prenom, Mdp, Service FROM Login INNER JOIN Service ON Login.ID_Service = Service.ID WHERE Nom = '" _
                        & TXT_SEARCH.Text & "'; "
            InitData(sqlQuery)
            exNonQuerrySearch(sqlQuery)

        ElseIf CBOX_SEARCH.SelectedItem = "Prénom" Then

            sqlQuery = "SELECT Login.ID, Nom, Prenom, Mdp, Service FROM Login INNER JOIN Service ON Login.ID_Service = Service.ID WHERE Prenom = '" _
                        & TXT_SEARCH.Text & "'; "
            InitData(sqlQuery)
            exNonQuerrySearch(sqlQuery)

        ElseIf CBOX_SEARCH.SelectedItem = "Service" Then


            sqlQuery = "SELECT Login.ID, Nom, Prenom, Mdp, Service FROM Login INNER JOIN Service ON Login.ID_Service = Service.ID WHERE Service = '" _
                        & TXT_SEARCH.Text & "'; "
            InitData(sqlQuery)
            exNonQuerrySearch(sqlQuery)

        End If

    End Sub
    'Bouton "Actualiser"
    Private Sub BT_ACT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        sqlQuery = "SELECT Login.ID, Nom, Prenom, Mdp, Service FROM Login INNER JOIN Service ON Login.ID_Service = Service.ID;"
        InitData(sqlQuery)
        'InitCbox()

    End Sub
    'Initialise les 3 utilisateurs et les 3 services
    Public Sub InitData(ByVal sqlQuery)

        Dim myConn As New SqlConnection("Data Source=MDRPC02\SQLEXPRESS;Initial Catalog=Projet_Demo;Integrated Security=False;Connect Timeout=30;User ID=sa;Password=C4F9E000")

        ds = New DataSet
        dt = New DataTable

        'Vide le GV
        If (ds.Tables.Count > 0) Then

            dt.Clear()

        End If

        'Remplit la Grid
        OpenCon(myConn)

        cmd = New SqlCommand(sqlQuery, myConn)

        adapter = New SqlDataAdapter(cmd)

        adapter.SelectCommand = cmd

        adapter.Fill(dt)

        DataGridView1.DataSource = dt

        CloseCon(myConn)

        DataGridView1.Columns(0).ReadOnly = True
        DataGridView1.Columns(1).ReadOnly = True
        DataGridView1.Columns(2).ReadOnly = True
        DataGridView1.Columns(3).ReadOnly = True
        DataGridView1.Columns(4).ReadOnly = True

    End Sub

End Class
