Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Globalization

Public Class Frm_ModifyPopup

    'Initialisation des données de la ligne sélectionnée
    Private Sub Frm_ModifyPopup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Combobox initialisation
        Dim cmdCbox As SqlCommand
        sqlQuery = "SELECT * FROM service;"

        'myConn.Open()

        cmdCbox = New SqlCommand(sqlQuery, myConn)

        Dim adapter As New SqlDataAdapter(cmdCbox)

        Dim table As New DataTable

        adapter.Fill(table)

        CBOX_SERVICE.DataSource = table

        CBOX_SERVICE.DisplayMember = "Service"
        CBOX_SERVICE.ValueMember = "ID"

        myConn.Close()

        'Remplissage des boxes selon la ligne sélectionnée
        TXT_ID.Text = dt.Rows(Form_Modify.DataGridView1.CurrentRow.Index)("Nom").ToString()
        TXT_PRENOM.Text = dt.Rows(Form_Modify.DataGridView1.CurrentRow.Index)("Prenom").ToString()
        TXT_MDP.Text = dt.Rows(Form_Modify.DataGridView1.CurrentRow.Index)("Mdp").ToString()
        CBOX_SERVICE.Text = dt.Rows(Form_Modify.DataGridView1.CurrentRow.Index)("Service").ToString()


    End Sub
    'Upper case sur premier caractère
    Private Sub TXT_ID_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_ID.Leave

        TXT_ID.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TXT_ID.Text.ToLower())

    End Sub
    Private Sub TXT_PRENOM_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_PRENOM.Leave

        TXT_PRENOM.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TXT_PRENOM.Text.ToLower())

    End Sub
    Private Sub CBOX_SERVICE_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBOX_SERVICE.Leave

        CBOX_SERVICE.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(CBOX_SERVICE.Text.ToLower())

    End Sub
    'Bouton "Save" pour modifier le compte
    Private Sub BT_SAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_SAVE.Click

        If (String.IsNullOrEmpty(TXT_ID.Text)) _
                Or (String.IsNullOrEmpty(TXT_PRENOM.Text)) _
                Or (String.IsNullOrEmpty(CBOX_SERVICE.Text)) _
                Or (String.IsNullOrEmpty(TXT_MDP.Text)) Then

            MessageBox.Show("Veuillez renseigner tous les champs.", "Erreur de création", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)

        ElseIf Regex.IsMatch(TXT_ID.Text, "[1-9²`~£€!@#\$%\^&\*\(\)_\-\+=\{\}\[\]\\\|:;""'<>°,\.\?/]") Then

            MessageBox.Show("Votre identifiant contient des caractères non autorisés.", "Erreur de création", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)

        ElseIf Regex.IsMatch(TXT_PRENOM.Text, "[1-9²`~£€!@#\$%\^&\*\(\)_\-\+=\{\}\[\]\\\|:;""'<>°,\.\?/]") Then

            MessageBox.Show("Votre mot de passe contient des caractères non autorisés.", "Erreur de création", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)

        ElseIf Regex.IsMatch(CBOX_SERVICE.Text, "[1-9²`~£€!@#\$%\^&\*\(\)_\-\+=\{\}\[\]\\\|:;""'<>°,\.\?/]") Then

            MessageBox.Show("Votre service contient des caractères non autorisés.", "Erreur de création", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)

        ElseIf Regex.IsMatch(TXT_MDP.Text, "[²`~£€!@#\$%\^&\*\(\)_\-\+=\{\}\[\]\\\|:;""'<>°,\.\?/]") Then

            MessageBox.Show("Votre mot de passe contient des caractères non autorisés.", "Erreur de création", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)

        Else

            Dim cmdUpd As SqlCommand
            cmdUpd = New SqlCommand(sqlQuery, myConn)

            myConn.Open()

            cmdUpd.Connection = myConn
            cmdUpd.CommandType = CommandType.Text
            cmdUpd.CommandText = "SELECT Service FROM Service WHERE UPPER(Service) = '" & CBOX_SERVICE.Text & "'"

            Dim reader As SqlDataReader = cmdUpd.ExecuteReader(CommandBehavior.CloseConnection)
            reader.Read()

            'Test pour savoir si le service modifié existe déjà ou non
            If reader.HasRows Then

                sqlQuery = "UPDATE Login SET Nom = '" & TXT_ID.Text & "', Prenom = '" & TXT_PRENOM.Text & "',Mdp = '" & TXT_MDP.Text & "',ID_Service = (SELECT ID FROM Service WHERE service = '" & CBOX_SERVICE.Text & "')  WHERE Login.ID = '" & Form_Modify.DataGridView1.CurrentRow.Cells(0).Value & "';"
                sqlQuery2 = "UPDATE Service SET Service ='" & CBOX_SERVICE.Text & "' WHERE ID = '" & Form_Modify.DataGridView1.CurrentRow.Cells(0).Value & "';"
                sqlQuery3 = sqlQuery + sqlQuery2

                cmdUpd = New SqlCommand(sqlQuery, myConn)

                reader.Close()

            Else

                'Ajout du service
                sqlQuery = "INSERT INTO Service (Service) VALUES ('" & CBOX_SERVICE.Text & "');UPDATE Login SET Nom = '" & TXT_ID.Text & "', Prenom = '" & TXT_PRENOM.Text & "',Mdp = '" & TXT_MDP.Text & "',ID_Service = (SELECT ID FROM Service WHERE service = '" & CBOX_SERVICE.Text & "')  WHERE Login.ID = '" & Form_Modify.DataGridView1.CurrentRow.Cells(0).Value & "';"
                sqlQuery3 = "UPDATE Service SET Service ='" & CBOX_SERVICE.Text & "' WHERE ID = '" & Form_Modify.DataGridView1.CurrentRow.Cells(0).Value & "';"
                sqlQuery4 = sqlQuery + sqlQuery3

                cmdUpd = New SqlCommand(sqlQuery4, myConn)

                reader.Close()

            End If

            cmdUpd = New SqlCommand(sqlQuery, myConn)
            exNonQuerryUpd(sqlQuery)

            sqlQuery = "SELECT Login.ID, Nom, Prenom, Mdp, Service FROM Login INNER JOIN Service ON Login.ID_Service = Service.ID;"
            Form_Modify.InitData(sqlQuery)

        End If

    End Sub

End Class