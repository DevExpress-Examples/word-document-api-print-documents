using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraRichEdit.API.Native;

namespace RichEditDocumentServer
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option:\r\nLoad and print the document: type 1\r\nPrint Two Copies of Pages 2-3: type 2");
            string answer = Console.ReadLine()?.ToLower();
            Console.WriteLine("Printing the document");
            if (answer == "1")
            {
                using (DevExpress.XtraRichEdit.RichEditDocumentServer server = new DevExpress.XtraRichEdit.RichEditDocumentServer())
                {
                    server.LoadDocument("Grimm.docx");
                    foreach (Section _section in server.Document.Sections)
                    {
                        _section.Page.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A3;
                        _section.Page.Landscape = true;
                        _section.Margins.Left = 500f;
                        _section.Margins.Right = 500f;
                        _section.Margins.Top = 200f;
                        _section.Margins.Bottom = 200f;
                        _section.PageNumbering.NumberingFormat = NumberingFormat.CardinalText;
                        _section.PageNumbering.FirstPageNumber = 0;
                    }
                    server.Print();
                }
            }
            else
            {
                using (DevExpress.XtraRichEdit.RichEditDocumentServer server = new DevExpress.XtraRichEdit.RichEditDocumentServer())
                {
                    server.LoadDocument("Grimm.docx");
                    #region #PrinterSettings
                    PrinterSettings printerSettings = new PrinterSettings();
                    //Set the document pages to print:
                    printerSettings.FromPage = 2;
                    printerSettings.ToPage = 3;

                    //Specify the number of copies:
                    printerSettings.Copies = 2;

                    //Print the document: 
                    server.Print(printerSettings);
                    #endregion #PrinterSettings
                }
            }
        }
    }
}
