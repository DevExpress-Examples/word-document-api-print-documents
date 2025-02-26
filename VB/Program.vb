Imports System
Imports System.Drawing.Printing
Imports DevExpress.XtraRichEdit.API.Native

Namespace RichEditDocumentServer
    Class Program
        Shared Sub Main(ByVal args As String())
            Console.WriteLine("Choose an option:" & vbCrLf & "Load and print the document: type 1" & vbCrLf & "Print Two Copies of Pages 2-3: type 2")
            Dim answer As String = Console.ReadLine()?.ToLower()
            Console.WriteLine("Printing the document")

            If answer = "1" Then
                Using server As New DevExpress.XtraRichEdit.RichEditDocumentServer()
                    server.LoadDocument("Grimm.docx")
                    For Each _section As Section In server.Document.Sections
                        _section.Page.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A3
                        _section.Page.Landscape = True
                        _section.Margins.Left = 500.0F
                        _section.Margins.Right = 500.0F
                        _section.Margins.Top = 200.0F
                        _section.Margins.Bottom = 200.0F
                        _section.PageNumbering.NumberingFormat = NumberingFormat.CardinalText
                        _section.PageNumbering.FirstPageNumber = 0
                    Next
                    server.Print()
                End Using
            Else
                Using server As New DevExpress.XtraRichEdit.RichEditDocumentServer()
                    server.LoadDocument("Grimm.docx")
                    ' Printer settings
                    Dim printerSettings As New PrinterSettings()
                    printerSettings.FromPage = 2
                    printerSettings.ToPage = 3
                    printerSettings.Copies = 2
                    ' Print document
                    server.Print(printerSettings)
                End Using
            End If
        End Sub
    End Class
End Namespace
