using iTextSharp.text.pdf;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Barcode
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            bool isPreview = chb_preview.Checked;
            Barcode39 barcode39 = new Barcode39();
            barcode39.Code = "20201209/WED";
            barcode39.BarHeight = 50f;

            //save image file
            //barcode39.CreateDrawingImage(Color.Black, Color.White).Save(@"C:\Users\Chanos\Desktop\git\barcode.png");

            Image barcodeImage = barcode39.CreateDrawingImage(Color.Black, Color.White);

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (printSender, printEvent) =>
            {
                printEvent.Graphics.DrawImage(barcodeImage, new Point(0, 0));
            };

            using (PageSetupDialog pageSetupDialog = new PageSetupDialog())
            {
                pageSetupDialog.Document = printDocument;
                pageSetupDialog.ShowDialog();
            }

            using (PrintDialog printDialog = new PrintDialog()) 
            {
                printDialog.Document = printDocument;
                printDialog.ShowDialog();
            } 

            if (!isPreview)
            {
                printDocument.Print();
            }
            else
            {
                using (PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog())
                {
                    printPreviewDialog.Document = printDocument;
                    printPreviewDialog.ShowDialog();
                }
            } 
        } 
    }
}
