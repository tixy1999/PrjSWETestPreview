Public Class FormCharacterOccurrences
    Private Sub BtnProcess_Click(sender As Object, e As EventArgs) Handles BtnProcess.Click
        Try
            Dim WordProcessor As PrjSWETestPreviewTextProcessor.ITextProcessor = New PrjSWETestPreviewTextProcessor.TextProcessor
            TxtAnswer.Text = WordProcessor.ProcessText(TxtInputString.Text, TxtChars.Text)
        Catch ex As Exception
            TxtAnswer.Text = "Error! Component threw an error!\n" + ex.ToString
        End Try
    End Sub
End Class
