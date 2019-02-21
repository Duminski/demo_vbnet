Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Globalization

Public Class Frm_AddPopup
    Inherits System.Windows.Forms.Form

    'Initialisation Combobox et textes
    Private Sub Frm_AddPopup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Combobox initialisation
        Dim cmdCbox As SqlCommand
        sqlQuery = "SELECT * FROM service;"

        myConn.Open()

        cmdCbox = New SqlCommand(sqlQuery, myConn)

        Dim adapter As New SqlDataAdapter(cmdCbox)

        Dim table As New DataTable

        adapter.Fill(table)

        CBOX_SERVICE.DataSource = table

        CBOX_SERVICE.DisplayMember = "Service"
        CBOX_SERVICE.ValueMember = "ID"

        myConn.Close()

        'Vide les zones de textes
        TXT_ID.Text = ""
        TXT_PRENOM.Clear()
        CBOX_SERVICE.SelectedIndex = -1
        TXT_MDP.Clear()

        'Initialisation des textes
        TxtInitialize()


    End Sub
    'Supprime le texte par défaut si l'utilisateur clique ou tab dans la textbox + Upper case sur premier caractère
    Private Sub TXT_ID_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_ID.Leave

        TxtInitialize()

        TXT_ID.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TXT_ID.Text.ToLower())

    End Sub
    Public Sub TXT_ID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ID.Click
        If TXT_ID.Text = "Tapez votre nom" Then
            TXT_ID.Text = ""
        End If
    End Sub
    Private Sub TXT_PRENOM_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_PRENOM.Leave

        TxtInitialize()

        TXT_PRENOM.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TXT_PRENOM.Text.ToLower())

    End Sub
    Public Sub TXT_PRENOM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_PRENOM.Click
        If TXT_PRENOM.Text = "Tapez votre prénom" Then
            TXT_PRENOM.Text = ""
        End If
    End Sub
    Private Sub CBOX_SERVICE_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBOX_SERVICE.Leave

        TxtInitialize()

        CBOX_SERVICE.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(CBOX_SERVICE.Text.ToLower())

    End Sub
    Public Sub CBOX_SERVICE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOX_SERVICE.Click
        If CBOX_SERVICE.Text = "Tapez votre service" Then
            CBOX_SERVICE.Text = ""
        End If
    End Sub
    Private Sub TXT_MDP_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_MDP.Leave
        TxtInitialize()
    End Sub
    Public Sub TXT_MDP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_MDP.Click
        If TXT_MDP.Text = "Tapez votre mot de passe" Then
            TXT_MDP.Text = ""
        End If
    End Sub
    'Bouton "Valider" pour ajouter un compte
    Private Sub BT_ADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_ADD.Click

        If (String.IsNullOrEmpty(TXT_ID.Text) Or TXT_ID.Text = "Tapez votre nom") _
                Or (String.IsNullOrEmpty(TXT_PRENOM.Text) Or TXT_PRENOM.Text = "Tapez votre prénom") _
                Or (String.IsNullOrEmpty(CBOX_SERVICE.Text) Or CBOX_SERVICE.Text = "Tapez votre service") _
                Or (String.IsNullOrEmpty(TXT_MDP.Text) Or TXT_MDP.Text = "Tapez votre mot de passe") Then

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

            sqlQuery = "SELECT Login.ID, Nom, Prenom, Mdp, Service FROM Login INNER JOIN Service ON Login.ID_Service = Service.ID;"
            sqlQuery2 = "SELECT service FROM Service;"

            Dim cmdAdd As SqlCommand
            cmdAdd = New SqlCommand(sqlQuery, myConn)

            myConn.Open()

            cmdAdd.Connection = myConn
            cmdAdd.CommandType = CommandType.Text
            cmdAdd.CommandText = "SELECT Service FROM Service WHERE UPPER(Service) = '" & CBOX_SERVICE.Text.Trim.ToUpper & "'"

            Dim reader As SqlDataReader = cmdAdd.ExecuteReader(CommandBehavior.CloseConnection)
            reader.Read()

            If reader.HasRows Then

                sqlQuery = "INSERT INTO Login (Nom,Prenom,Mdp,ID_Service) VALUES ('" & TXT_ID.Text & "','" & TXT_PRENOM.Text & "','" & TXT_MDP.Text & "', (SELECT ID FROM Service WHERE Service = '" & CBOX_SERVICE.Text & "'));"

                cmdAdd = New SqlCommand(sqlQuery, myConn)

                reader.Close()

            Else

                sqlQuery = "INSERT INTO Service (Service) VALUES ('" & CBOX_SERVICE.Text & "');INSERT INTO Login (Nom,Prenom,Mdp,ID_Service) VALUES ('" & TXT_ID.Text & "','" & TXT_PRENOM.Text & "','" & TXT_MDP.Text & "', (SELECT ID FROM Service WHERE Service = '" & CBOX_SERVICE.Text & "'));"

                cmdAdd = New SqlCommand(sqlQuery, myConn)

                reader.Close()

            End If

            cmdAdd = New SqlCommand(sqlQuery, myConn)
            exNonQuerryAdd(sqlQuery)

            sqlQuery2 = "SELECT Login.ID, Nom, Prenom, Mdp, Service FROM Login INNER JOIN Service ON Login.ID_Service = Service.ID;"
            Form_Modify.InitData(sqlQuery2)

        End If

    End Sub
    'Réécriture des textes dans textboxs si rien n'a été écrit
    Private Sub TxtInitialize()

        If TXT_ID.Text = "" Then

            TXT_ID.Text = "Tapez votre nom"

        End If

        If TXT_PRENOM.Text = "" Then

            TXT_PRENOM.Text = "Tapez votre prénom"

        End If

        If CBOX_SERVICE.Text = "" Then

            CBOX_SERVICE.Text = "Tapez votre service"

        End If


        If TXT_MDP.Text = "" Then

            TXT_MDP.Text = "Tapez votre mot de passe"
            TXT_MDP.PasswordChar = ""

        End If


    End Sub

End Class