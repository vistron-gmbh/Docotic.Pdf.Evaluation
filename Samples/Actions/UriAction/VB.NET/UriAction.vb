Imports BitMiracle.Docotic.Pdf

Namespace BitMiracle.Docotic.Pdf.Samples
    Public NotInheritable Class UriAction
        Public Shared Sub Main()
            ' NOTE: 
            ' When used in trial mode, the library imposes some restrictions.
            ' Please visit http://bitmiracle.com/pdf-library/trial-restrictions.aspx
            ' for more information.

            Dim pathToFile As String = "UriAction.pdf"

            Using pdf As New PdfDocument()

                Dim uriAction As PdfUriAction = pdf.CreateHyperlinkAction(New Uri("http://www.google.com"))
                Dim annotation As PdfActionArea = pdf.Pages(0).AddActionArea(10, 50, 100, 100, uriAction)
                annotation.Border.Color = New PdfRgbColor(0, 0, 0)
                annotation.Border.DashPattern = New PdfDashPattern(New Single() {3, 2})
                annotation.Border.Width = 1
                annotation.Border.Style = PdfMarkerLineStyle.Dashed

                pdf.Save(pathToFile)
            End Using

            Console.WriteLine($"The output is located in {Environment.CurrentDirectory}")

            Process.Start(New ProcessStartInfo(pathToFile) With {.UseShellExecute = True})
        End Sub
    End Class
End Namespace