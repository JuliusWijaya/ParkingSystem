Public Class Form1
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        MaximizeBox = False
        txtnama.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Membuat sebuah variabel dengan keyword Dim dan diikuti oleh nama variabel 
        Dim val1 As String = String.Concat("Hello World!", " ", " VB.NET Asik Guys")
        Dim val2 As String = "123"
        Dim val3 As Integer = Integer.Parse(val2)
        val3.GetType()
        MsgBox("Variabel type: ", MsgBoxStyle.Information, "Information")
        'MessageBox.Show("Hello World!", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
    End Sub
End Class
