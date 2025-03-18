Public Class TextProcessor
    Implements ITextProcessor

    Private inputString As String
    Private matchChars As String
    Private answer As String
    Private match As Boolean = False

    Private Function ITextProcessor_ProcessText(inputText As String, characters As String) As String Implements ITextProcessor.ProcessText
        inputString = LCase(inputText)
        matchChars = LCase(characters)

        If String.IsNullOrEmpty(inputString) Or String.IsNullOrEmpty(matchChars) Then
            answer = "VIGA! Sisend puudub!"
        Else
            GetOccurrences()
        End If

        Return answer
    End Function

    Private Sub GetOccurrences()
        Dim occurrences As New Dictionary(Of Char, Integer)

        For Each c As Char In matchChars
            occurrences.Add(c, 0)
        Next

        For Each c As Char In inputString
            If occurrences.ContainsKey(c) Then
                occurrences(c) += 1
                match = True
            End If
        Next

        If match Then
            answer = "Vastus: " + vbCrLf
            For Each c As Char In occurrences.Keys
                answer += c + " - " + occurrences(c).ToString + vbCrLf
            Next
            match = False
        Else
            answer = "VIGA! Ei leitud ühtegi sobivat tähemärki!"
        End If
    End Sub
End Class
