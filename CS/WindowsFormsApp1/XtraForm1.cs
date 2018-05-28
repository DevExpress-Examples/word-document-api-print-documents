using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Drawing.Printing;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;

namespace RichEditDocumentServer
{
    public partial class XtraForm1 : XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using (DevExpress.XtraRichEdit.RichEditDocumentServer server = new DevExpress.XtraRichEdit.RichEditDocumentServer())
            {
                server.LoadDocument("Grimm.docx");
                foreach (Section _section in server.Document.Sections)
                {
                    _section.Page.PaperKind = PaperKind.A3;
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

        private void simpleButton2_Click(object sender, EventArgs e)
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