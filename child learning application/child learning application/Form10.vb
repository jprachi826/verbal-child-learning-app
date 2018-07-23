Imports System.Data
Imports System.Data.SqlClient
Public Class Form3
    Dim MyCn As New SqlConnection
    Dim MyDataAdp As New SqlDataAdapter
    Dim MyCmdBld As New SqlCommandBuilder
    Dim MyDatatbl As New DataTable
    Dim cmd As New SqlCommand
    Dim MyRowPosition As Integer = 0
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form7.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End
    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AppDataSet.profile' table. You can move, or remove it, as needed.
        Me.ProfileTableAdapter.Fill(Me.AppDataSet.profile)
        MyCn.ConnectionString = "Data Source=DELL-PC;Initial Catalog=app;Integrated Security=True"
        MyCn.Open()
        MyDataAdp = New SqlDataAdapter("Select*  from profile", MyCn)
        MyCmdBld = New SqlCommandBuilder(MyDataAdp)
        MyDataAdp.Fill(MyDatatbl)
        'Dim MyDataRow As DataRow = MyDatatbl.Rows()
        'Dim strName As String
        'strName = MyDataRow("name")
        'Label3.Text = strName.ToString
        MyCn.Close()
        If MyDatatbl.Rows.Count > 0 Then
            Label3.Text = MyDatatbl.Rows(1).Item("name").ToString

        End If
    End Sub
End Class