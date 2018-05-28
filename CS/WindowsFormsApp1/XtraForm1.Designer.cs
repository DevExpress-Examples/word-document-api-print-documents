namespace RichEditDocumentServer
{
    partial class XtraForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.btnDefaultPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrinterSettings = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // btnDefaultPrint
            // 
            this.btnDefaultPrint.Location = new System.Drawing.Point(65, 94);
            this.btnDefaultPrint.Name = "btnDefaultPrint";
            this.btnDefaultPrint.Size = new System.Drawing.Size(164, 23);
            this.btnDefaultPrint.TabIndex = 0;
            this.btnDefaultPrint.Text = "Load and Print The Document";
            this.btnDefaultPrint.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnPrinterSettings
            // 
            this.btnPrinterSettings.Location = new System.Drawing.Point(65, 123);
            this.btnPrinterSettings.Name = "btnPrinterSettings";
            this.btnPrinterSettings.Size = new System.Drawing.Size(164, 23);
            this.btnPrinterSettings.TabIndex = 1;
            this.btnPrinterSettings.Text = "Print Two Copies of Pages 2-3";
            this.btnPrinterSettings.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 227);
            this.Controls.Add(this.btnPrinterSettings);
            this.Controls.Add(this.btnDefaultPrint);
            this.MaximizeBox = false;
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton btnDefaultPrint;
        private DevExpress.XtraEditors.SimpleButton btnPrinterSettings;
    }
}