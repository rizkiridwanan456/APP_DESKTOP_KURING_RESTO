Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization
Imports Newtonsoft.Json
Imports System.Net.Http
Public Class Order_list
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub Order_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim url As String = "http://localhost:1323/pesan"
        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        request.Method = "Get"

        Dim response As HttpWebResponse = request.GetResponse()
        Dim read = New StreamReader(response.GetResponseStream())
        Dim responseText As String = read.ReadToEnd()

        Dim table As DataTable = JsonConvert.DeserializeObject(Of DataTable)(responseText)


        DG.DataSource = table
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim url As String = "http://localhost:1323/cari/" & TB1.Text ' Ganti dengan URL API Anda

            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
            request.Method = "GET"

            Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
            Dim stream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(stream)
            Dim responseBody As String = reader.ReadToEnd()

            Dim data As List(Of Object) = JsonConvert.DeserializeObject(Of List(Of Object))(responseBody)

            DG.DataSource = data

            response.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim url As String = "http://localhost:1323/pesan"
        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        request.Method = "Get"

        Dim response As HttpWebResponse = request.GetResponse()
        Dim read = New StreamReader(response.GetResponseStream())
        Dim responseText As String = read.ReadToEnd()

        Dim table As DataTable = JsonConvert.DeserializeObject(Of DataTable)(responseText)


        DG.DataSource = table
        TB1.Clear()
    End Sub
End Class