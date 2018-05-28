Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.Drawing.Printing
Imports DevExpress.XtraRichEdit

Namespace RichEditDocumentServer
    Partial Public Class XtraForm1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()

        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDefaultPrint.Click
            Using server As New DevExpress.XtraRichEdit.RichEditDocumentServer()
                server.LoadDocument("Grimm.docx")
                server.Print()
            End Using
        End Sub

        Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrinterSettings.Click
            Using server As New DevExpress.XtraRichEdit.RichEditDocumentServer()
                server.LoadDocument("Grimm.docx")
'                #Region "#PrinterSettings"
                Dim printerSettings As New PrinterSettings()
				
				'Set the document pages to print:
                printerSettings.FromPage = 2
                printerSettings.ToPage = 3
				
				'Specify the number of copies:
                printerSettings.Copies = 2
				
				'Print the document:
                server.Print(printerSettings)
'                #End Region ' #PrinterSettings

            End Using
        End Sub
    End Class
End Namespace