Imports System
Imports BitMiracle.Docotic.Pdf.HtmlToPdf

Namespace BitMiracle.Docotic.Pdf.Samples
    Public NotInheritable Class HtmlToPdfConsole
        Public Shared Sub Main()
            Task.Run(
                Async Function()
                    Await convertUrlToPdfAsync("https://bitmiracle.com/", "HtmlToPdfConsole.pdf")
                End Function
            ).GetAwaiter().GetResult()
        End Sub

        Private Shared Async Function convertUrlToPdfAsync(urlString As String, pdfFileName As String) As Task
            ' NOTE: 
            ' When used in trial mode, the library imposes some restrictions.
            ' Please visit http://bitmiracle.com/pdf-library/trial-restrictions.aspx
            ' for more information.

            Using converter = Await HtmlConverter.CreateAsync()

                Using pdf = Await converter.CreatePdfAsync(New Uri(urlString))
                    pdf.Save(pdfFileName)
                End Using
            End Using

            Console.WriteLine($"The output is located in {Environment.CurrentDirectory}")

            Process.Start(New ProcessStartInfo(pdfFileName) With {.UseShellExecute = True})
        End Function
    End Class
End Namespace