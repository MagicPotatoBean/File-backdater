Imports System.IO
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filenames() As String
        With OpenFileDialog1
            .Title = "Select file to backdate"
            .Multiselect = True
            .ShowDialog()
            filenames = .FileNames
        End With
        If filenames.Length > 0 Then
            For Each filename In filenames
                Try
                    If File.Exists(filename) Then
                        File.SetCreationTime(filename, DateTimePicker1.Value)
                    End If
                Catch ex As Exception
                    MsgBox(ex)
                End Try
            Next
            MsgBox("Done!")
        Else
            MsgBox("No files selected")
        End If
    End Sub
End Class
