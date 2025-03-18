Imports System.IO

Public Class TextProcessor
    Implements ITextProcessor

    Public Function ProcessText(inputString As String, chars As String) As String Implements ITextProcessor.ProcessText

        If String.IsNullOrEmpty(inputString) Then
            Return "VIGA! Sisend puudub!"
        Else
            Dim result As New Dictionary(Of Char, Integer)

            inputString = inputString.ToLower()

            For Each letter As Char In chars
                result(letter) = 0
            Next

            For Each letter As Char In inputString
                If result.ContainsKey(letter) Then
                    result(letter) += 1
                End If
            Next

            Dim resultString As String = String.Join(Environment.NewLine, result.Select(Function(p) p.Key & " - " & p.Value))

            Return resultString

        End If
    End Function
End Class
