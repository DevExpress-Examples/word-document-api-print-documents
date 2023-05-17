Imports DevExpress.XtraEditors
Imports System.Drawing.Printing
Imports DevExpress.XtraRichEdit.API.Native

Namespace RichEditDocumentServer
    Partial Public Class XtraForm1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()

        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDefaultPrint.Click
            Using server As DevExpress.XtraRichEdit.RichEditDocumentServer = New DevExpress.XtraRichEdit.RichEditDocumentServer()
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
        End Sub

        Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrinterSettings.Click
            Using server As DevExpress.XtraRichEdit.RichEditDocumentServer = New DevExpress.XtraRichEdit.RichEditDocumentServer()
                server.LoadDocument("Grimm.docx")
#Region "#PrinterSettings"
                Dim printerSettings As PrinterSettings = New PrinterSettings()
                'Set the document pages to print:
                printerSettings.FromPage = 2
                printerSettings.ToPage = 3

                'Specify the number of copies:
                printerSettings.Copies = 2

                'Print the document: 
                server.Print(printerSettings)
#End Region
            End Using
        End Sub
    End Class
End Namespace