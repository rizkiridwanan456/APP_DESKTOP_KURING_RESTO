Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Text
Public Class Saung
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        TB1.Clear()
        TB2.Clear()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub Saung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim url As String = "http://localhost:1323/saung"
        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        request.Method = "Get"

        Dim response As HttpWebResponse = request.GetResponse()
        Dim read = New StreamReader(response.GetResponseStream())
        Dim responseText As String = read.ReadToEnd()

        Dim table As DataTable = JsonConvert.DeserializeObject(Of DataTable)(responseText)


        DG.DataSource = table
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim apiUrl As String = "http://localhost:1323/saung/" & TB1.Text
        Dim requestBody As String = "{""Status"": """ & TB2.Text & """}"

        Dim request As WebRequest = WebRequest.Create(apiUrl)
        request.Method = "PUT"
        request.ContentType = "application/json"

        Dim requestBodyBytes As Byte() = System.Text.Encoding.ASCII.GetBytes(requestBody)
        request.ContentLength = requestBodyBytes.Length

        Using requestStream As Stream = request.GetRequestStream()
            requestStream.Write(requestBodyBytes, 0, requestBodyBytes.Length)
        End Using
        Try
            Using response As WebResponse = request.GetResponse()
                Using responseStream As Stream = response.GetResponseStream()
                    Using reader As New StreamReader(responseStream)
                        Dim result As String = reader.ReadToEnd()
                        ' Lakukan sesuatu dengan hasil response di sini
                        MessageBox.Show("Data berhasil diperbarui!")
                    End Using
                End Using
            End Using
        Catch ex As WebException
            Dim response As WebResponse = ex.Response
            Using responseStream As Stream = response.GetResponseStream()
                Using reader As New StreamReader(responseStream)
                    Dim errorText As String = reader.ReadToEnd()
                    ' Tangani kesalahan di sini
                    MessageBox.Show("Terjadi kesalahan: " & errorText)
                End Using
            End Using
        End Try
        GetDataAndDisplay()
    End Sub
    Private Sub GetDataAndDisplay()
        Dim url As String = "http://localhost:1323/saung"
        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        request.Method = "Get"

        Dim response As HttpWebResponse = request.GetResponse()
        Dim read = New StreamReader(response.GetResponseStream())
        Dim responseText As String = read.ReadToEnd()

        Dim table As DataTable = JsonConvert.DeserializeObject(Of DataTable)(responseText)


        DG.DataSource = table
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TB1.Clear()
        TB2.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub
End Class