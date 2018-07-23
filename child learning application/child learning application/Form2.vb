Imports System.Data
Imports System.Data.SqlClient
Public Class Form2
    Dim MyCn As New SqlConnection
    Dim MyDataAdp As New SqlDataAdapter
    Dim MyCmdBld As New SqlCommandBuilder
    Dim MyDatatbl As New DataTable
    Dim cmd As New SqlCommand
    Dim MyRowPosition As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
        MyCn.ConnectionString = "Data Source=DELL-PC;Initial Catalog=app;Integrated Security=True"
        MyCn.Open()
        Using cmd As New SqlClient.SqlCommand("INSERT INTO profile(name) VALUES('" & TextBox1.Text & "')", MyCn)
            MyRowPosition = cmd.ExecuteNonQuery
        End Using
        MyCn.Close()
    End Sub


End Class