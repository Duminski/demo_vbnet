Imports System.Data.SqlClient

Module declaration

    Public myConn As New SqlConnection("Data Source=MDRPC02\SQLEXPRESS;Initial Catalog=Projet_Demo;Integrated Security=False;Connect Timeout=30;User ID=sa;Password=C4F9E000")
    Public cmd As SqlCommand
    Public reader As SqlDataReader
    Public adapter As SqlDataAdapter
    Public dt As DataTable
    Public ds As DataSet
    Public sqlQuery As String
    Public sqlQuery2 As String
    Public sqlQuery3 As String
    Public sqlQuery4 As String
    Public result As String = 0
    Public nbClic As Integer
    Public nbIma As Integer

    Public ExitedForm As Form

    Public user1 As User
    Public user2 As User
    Public user3 As User
    Public user4 As User

    Public NbrAcc As Integer = 0

    Structure User

        Dim ID As String
        Dim Prenom As String
        Dim Service As String
        Dim Mdp As String

    End Structure

End Module
