Module ModuleFonction

    'Fonction swap pour cycler 3 images dans 3 Forms différentes
    Public Sub swapPbox(ByVal PBOX As PictureBox)


        'Dim tabImage(2) As Image

        'tabImage(0) = Frm_1.PBOX.Image
        'tabImage(1) = Frm_2.PBOX.Image
        'tabImage(2) = Frm_3.PBOX.Image



        Dim ImTmp As New PictureBox
        ImTmp.Image = PBOX.Image

        If (PBOX Is Frm_1.PBOX) Then

            PBOX.Image = Frm_3.PBOX.Image

            Frm_3.PBOX.Image = Frm_2.PBOX.Image

            Frm_2.PBOX.Image = ImTmp.Image


        ElseIf PBOX Is Frm_2.PBOX Then

            ImTmp.Image = PBOX.Image

            PBOX.Image = Frm_1.PBOX.Image

            Frm_1.PBOX.Image = Frm_3.PBOX.Image

            Frm_3.PBOX.Image = ImTmp.Image

        ElseIf PBOX Is Frm_3.PBOX Then

            ImTmp.Image = PBOX.Image

            PBOX.Image = Frm_2.PBOX.Image

            Frm_2.PBOX.Image = Frm_1.PBOX.Image

            Frm_1.PBOX.Image = ImTmp.Image

        End If

    End Sub
    'Éxecution de la commande recherche
    Public Sub exNonQuerrySearch(ByVal sqlQuery As String)

        OpenCon(myConn)

        With cmd

            .Connection = myConn
            .CommandText = sqlQuery

        End With

        cmd.ExecuteNonQuery()

        ''Test du nombre de lignes affectées par la commande
        'If result > 0 Then

        '    MsgBox("La recherche a été effectuée.")

        'Else

        '    MsgBox("Cette personne ou ce service n'existe pas.")

        'End If

        CloseCon(myConn)

    End Sub
    'Éxecution de la commande SQL pour la MAJ BDD
    Public Sub exNonQuerryUpd(ByVal sqlQuery As String)

        OpenCon(myConn)

        'If myConn.State = ConnectionState.Open Then

        '    MsgBox("Connexion ouverte")

        'Else

        '    MsgBox("Connexion bloquée")

        'End If


        With cmd

            .Connection = myConn
            .CommandText = sqlQuery

        End With

        result = cmd.ExecuteNonQuery()

        'Test du nombre de lignes affectées par la commande
        If result > 0 Then

            MsgBox("La base de données a été mise à jour.")

        Else

            MsgBox("Erreur lors de la mise à jour.")

        End If

        CloseCon(myConn)

    End Sub
    'Éxecution de la commande SQL pour l'ajout de compte
    Public Sub exNonQuerryAdd(ByVal sqlQuery As String)

        OpenCon(myConn)

        With cmd

            .Connection = myConn
            .CommandText = sqlQuery

        End With

        result = cmd.ExecuteNonQuery()

        'Test du nombre de lignes affectées par la commande
        If result > 0 Then

            MsgBox("L'ajout de compte a été effectuée.")

        Else

            MsgBox("Erreur lors de l'ajout.")

        End If

        CloseCon(myConn)

    End Sub
    'Éxecution de la commande SQL pour la suppression de compte
    Public Sub exNonQuerryDel(ByVal sqlQuery As String)

        OpenCon(myConn)

        With cmd

            .Connection = myConn
            .CommandText = sqlQuery

        End With

        'result = 
        cmd.ExecuteNonQuery()

        'Test du nombre de lignes affectées par la commande
        'If result > 0 Then

        '    MsgBox("La suppression de compte a été effectuée.")

        'Else

        '    MsgBox("Erreur lors de la suppression.")

        'End If

        'CloseCon(myConn)

    End Sub
    'Éxecution de la commande SQL pour la création de compte
    Public Sub exNonQuerry(ByVal sqlQuery As String)

        OpenCon(myConn)

        With cmd

            .Connection = myConn
            .CommandText = sqlQuery

        End With

        result = cmd.ExecuteNonQuery()

        'Test du nombre de lignes affectées par la commande
        If result > 0 Then

            MsgBox("L'utilisateur a été enregistré.")

        Else

            MsgBox("Erreur lors de l'enregistrement de l'utilisateur.")

        End If

        CloseCon(myConn)

    End Sub
    'Ouverture de la connexion à la base de données
    Public Function OpenCon(ByVal myConn)

        Try

            myConn.Open()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        Return myConn

    End Function
    'Fermeture de la connexion à la base de données
    Public Function CloseCon(ByVal myConn)

        Try

            myConn.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        Return myConn

    End Function

End Module
