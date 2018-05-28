Namespace RichEditDocumentServer
    Partial Public Class XtraForm1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.btnDefaultPrint = New DevExpress.XtraEditors.SimpleButton()
            Me.btnPrinterSettings = New DevExpress.XtraEditors.SimpleButton()
            Me.SuspendLayout()
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' btnDefaultPrint
            ' 
            Me.btnDefaultPrint.Location = New System.Drawing.Point(65, 94)
            Me.btnDefaultPrint.Name = "btnDefaultPrint"
            Me.btnDefaultPrint.Size = New System.Drawing.Size(164, 23)
            Me.btnDefaultPrint.TabIndex = 0
            Me.btnDefaultPrint.Text = "Load and Print The Document"
            ' 
            ' btnPrinterSettings
            ' 
            Me.btnPrinterSettings.Location = New System.Drawing.Point(65, 123)
            Me.btnPrinterSettings.Name = "btnPrinterSettings"
            Me.btnPrinterSettings.Size = New System.Drawing.Size(164, 23)
            Me.btnPrinterSettings.TabIndex = 1
            Me.btnPrinterSettings.Text = "Print Two Copies of Pages 2-3"
            ' 
            ' XtraForm1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(289, 227)
            Me.Controls.Add(Me.btnPrinterSettings)
            Me.Controls.Add(Me.btnDefaultPrint)
            Me.MaximizeBox = False
            Me.Name = "XtraForm1"
            Me.Text = "XtraForm1"
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
        Private WithEvents btnDefaultPrint As DevExpress.XtraEditors.SimpleButton
        Private WithEvents btnPrinterSettings As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace