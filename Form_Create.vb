Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Globalization

Public Class Form_Create

    'Clear la Form + Réinitialise les textes + Initialisation Combobox
    Private Sub Form_Create_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Liaison Combobox/BDD
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


        'vide les zones de textes
        TXT_ID.Text = ""
        TXT_PRENOM.Clear()
        CBOX_SERVICE.SelectedIndex = -1
        TXT_MDP.Clear()
        TXT_CONF.Clear()

        'Initialisation des textes
        TxtInitialize()

        'TXT_ID.Text = "Tapez votre nom"
        'TXT_PRENOM.Text = "Tapez votre prénom"
        'CBOX_SERVICE.Text = "Tapez votre service"
        'TXT_MDP.Text = "Tapez votre mot de passe"
        'TXT_CONF.Text = "Confirmez votre mot de passe"


    End Sub
    'Supprime le texte par défaut si l'utilisateur clique ou tab dans la textbox + Upper case sur premier caractère
    Private Sub TXT_ID_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_ID.Leave

        'Dim txtID As String
        'txtID = TXT_ID.Text

        TxtInitialize()
        If TXT_ID.Text <> "Tapez votre nom" Then

            TXT_ID.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TXT_ID.Text.ToLower())

        End If

    End Sub
    Public Sub TXT_ID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ID.Click
        If TXT_ID.Text = "Tapez votre nom" Then
            TXT_ID.Text = ""
        End If
    End Sub
    Private Sub TXT_PRENOM_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_PRENOM.Leave

        TxtInitialize()

        If TXT_PRENOM.Text <> "Tapez votre prénom" Then

            TXT_PRENOM.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TXT_PRENOM.Text.ToLower())

        End If

    End Sub
    Public Sub TXT_PRENOM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_PRENOM.Click
        If TXT_PRENOM.Text = "Tapez votre prénom" Then
            TXT_PRENOM.Text = ""
        End If
    End Sub
    Private Sub CBOX_SERVICE_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBOX_SERVICE.Leave

        TxtInitialize()

        If CBOX_SERVICE.Text <> "Tapez votre service" Then

            CBOX_SERVICE.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(CBOX_SERVICE.Text.ToLower())

        End If

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
    Private Sub TXT_CONF_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_CONF.Leave
        TxtInitialize()
    End Sub
    Public Sub TXT_CONF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_CONF.Click
        If TXT_CONF.Text = "Confirmez votre mot de passe" Then
            TXT_CONF.Text = ""
        End If
    End Sub
    'Affiche/Cache le mot de passe
    Private Sub PBOX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBOX1.Click

        With TXT_MDP
            If .PasswordChar = "*" Then
                .PasswordChar = ""
            Else
                .PasswordChar = "*"
            End If
        End With

    End Sub
    'Affiche/Cache le mot de passe
    Private Sub PBOX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBOX2.Click

        With TXT_CONF
            If .PasswordChar = "*" Then
                .PasswordChar = ""
            Else
                .PasswordChar = "*"
            End If
        End With

    End Sub
    'Caractères du mot de passe qui se transforme en *
    Private Sub TXT_MDP_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_MDP.KeyPress

        Me.TXT_MDP.PasswordChar = "*"

    End Sub
    Private Sub TXT_CONF_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_CONF.KeyPress

        Me.TXT_CONF.PasswordChar = "*"

    End Sub
    'Affiche un tooltip d'aide du bouton
    Private Sub PBOX1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBOX1.MouseHover

        TTip1.Show("Cacher/Montrer le mot de passe", PBOX1)

    End Sub
    Private Sub PBOX2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBOX2.MouseHover

        TTip1.Show("Cacher/Montrer le mot de passe", PBOX2)

    End Sub
    'Création de compte
    Private Sub BT_VALIDE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_VALIDE.Click

        'Check des textboxes
        If (String.IsNullOrEmpty(TXT_ID.Text) Or TXT_ID.Text = "Tapez votre nom") _
                Or (String.IsNullOrEmpty(TXT_PRENOM.Text) Or TXT_PRENOM.Text = "Tapez votre prénom") _
                Or (String.IsNullOrEmpty(CBOX_SERVICE.Text) Or CBOX_SERVICE.Text = "Tapez votre service") _
                Or (String.IsNullOrEmpty(TXT_MDP.Text) Or TXT_MDP.Text = "Tapez votre mot de passe") Then

            MessageBox.Show("Veuillez renseigner tous les champs.", "Erreur de création", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)

        ElseIf (String.Compare(TXT_MDP.Text, TXT_CONF.Text) <> 0) Then

            MessageBox.Show("Le mot de passe n'a pas été bien recopié.", "Erreur de création", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)

        ElseIf Regex.IsMatch(TXT_ID.Text, "[1-9²`~£€!@#\$%\^&\*\(\)_\-\+=\{\}\[\]\\\|:;""'<>°,\.\?/]") Then

            MessageBox.Show("Votre identifiant contient des caractères non autorisés.", "Erreur de création", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)

        ElseIf Regex.IsMatch(TXT_PRENOM.Text, "[1-9²`~£€!@#\$%\^&\*\(\)_\-\+=\{\}\[\]\\\|:;""'<>°,\.\?/]") Then

            MessageBox.Show("Votre mot de passe contient des caractères non autorisés.", "Erreur de création", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)

        ElseIf Regex.IsMatch(TXT_MDP.Text, "[²`~£€!@#\$%\^&\*\(\)_\-\+=\{\}\[\]\\\|:;""'<>°,\.\?/]") Then

            MessageBox.Show("Votre mot de passe contient des caractères non autorisés.", "Erreur de création", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)

        ElseIf Regex.IsMatch(CBOX_SERVICE.Text, "[1-9²`~£€!@#\$%\^&\*\(\)_\-\+=\{\}\[\]\\\|:;""'<>°,\.\?/]") Then

            MessageBox.Show("Votre service contient des caractères non autorisés.", "Erreur de création", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)

        Else

            NbrAcc = NbrAcc + 1

            MsgBox("Votre compte a bien été créé.")

            sqlQuery = "SELECT Login.ID, Nom, Prenom, Mdp, Service FROM Login INNER JOIN Service ON Login.ID_Service = Service.ID;"
            sqlQuery2 = "SELECT service FROM Service;"

            cmd = New SqlCommand

            myConn.Open()

            cmd.Connection = myConn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT Service FROM Service WHERE UPPER(Service) = '" & CBOX_SERVICE.Text.Trim.ToUpper & "'"

            Dim reader As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            reader.Read()

            'Test de la textbox "Service" (Si le service est déjà existant ou s'il faut en créer un autre dans la BDD)
            If reader.HasRows Then

                sqlQuery = "INSERT INTO Login (Nom, Prenom, Mdp, ID_Service) VALUES ('" & TXT_ID.Text & "','" & TXT_PRENOM.Text & "','" & TXT_MDP.Text & "', (SELECT ID FROM Service WHERE service = '" & CBOX_SERVICE.Text & "'));"
                cmd = New SqlCommand(sqlQuery, myConn)

                reader.Close()

            Else

                'Ajout du service
                sqlQuery = "INSERT INTO Service (Service) VALUES ('" & CBOX_SERVICE.Text & "');INSERT INTO Login (Nom, Prenom, Mdp,ID_Service) VALUES ('" & TXT_ID.Text & "','" & TXT_PRENOM.Text & "','" & TXT_MDP.Text & "',(SELECT ID FROM Service WHERE Service = '" & CBOX_SERVICE.Text & "')); "
                cmd = New SqlCommand(sqlQuery, myConn)

                reader.Close()

            End If

            'Ajout du compte en BDD
            cmd = New SqlCommand(sqlQuery, myConn)
            exNonQuerry(sqlQuery)

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

        If TXT_CONF.Text = "" Then

            TXT_CONF.Text = "Confirmez votre mot de passe"
            TXT_CONF.PasswordChar = ""

        End If



    End Sub

End Class