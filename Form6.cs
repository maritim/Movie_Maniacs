using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Movie_Maniacs
{
    public partial class Form6 : Form
    {
        private MovieClass Movie;

        public Form6(MovieClass movie,bool Edit)
        {
            InitializeComponent();

            Movie = movie;
            ReviewTextBox.Text = Movie.Get_Review().Replace(@"\n",Environment.NewLine);

            if (!Edit)
            {
                menuStrip1.Visible = false;
                ReviewTextBox.BackColor = Color.White;
                ReviewTextBox.ReadOnly = true;
                contextMenuStrip1.Items[0].Enabled = contextMenuStrip1.Items[1].Enabled = 
                    contextMenuStrip1.Items[2].Enabled = contextMenuStrip1.Items[3].Enabled = contextMenuStrip1.Items[5].Enabled = false;
            }
        }

        private string printingString;

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReviewTextBox.Text = null;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open";
            ofd.Filter = "Text Files (*.txt) | *.txt|All Files | *.*";

            ofd.ShowDialog();

            if (ofd.FileName != "")
                ReviewTextBox.Text = WorkerClass.ReadFile(ofd.FileName, true).Replace(@"\n",Environment.NewLine);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReviewTextBox.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReviewTextBox.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReviewTextBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReviewTextBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReviewTextBox.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReviewTextBox.SelectAll();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Movie.Set_Review(ReviewTextBox.Text);
            Movie.Update_Informations();
            this.Close();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;

            printingString = ReviewTextBox.Text;

            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage); 

            if (printDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }

        void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;

            Graphics graphic = e.Graphics;

            try
            {
                graphic.MeasureString(printingString, this.Font,
                    e.MarginBounds.Size, StringFormat.GenericTypographic,
                    out charactersOnPage, out linesPerPage);

                if (printingString.Length < charactersOnPage)
                {
                    Rectangle rectangle = Rectangle.FromLTRB(e.MarginBounds.Left, e.MarginBounds.Top + 60, e.MarginBounds.Right, e.MarginBounds.Bottom);

                    graphic.DrawString(Movie.Movie_Name, new Font("Times New Roman", 20), Brushes.Black, new Point(e.MarginBounds.Left, 100), StringFormat.GenericTypographic);

                    graphic.DrawString(printingString, new Font("Times New Roman", 12), Brushes.Black, rectangle, StringFormat.GenericTypographic);
                }
                else
                    graphic.DrawString(printingString, new Font("Times New Roman", 12), Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);

                printingString = printingString.Substring(charactersOnPage);

                e.HasMorePages = (printingString.Length > 0);

                if(!e.HasMorePages)
                    graphic.DrawImage(Image.FromFile(Movie.Movie_Name + "//" + Movie.Movie_Name + ".jpg"), new Point(300, e.MarginBounds.Top + 100 + 16 * (linesPerPage)));
            }
            catch
            {
 
            }

//            for(int i=0;i<=ReviewTextBox.Text.Length;i+=100)
//                graphic.DrawString(ReviewTextBox.Text.Substring(i,WorkerClass.min(i+100,ReviewTextBox.Text.Length,"int")), new Font("Courier New", 12), new SolidBrush(Color.Black), 30, 30);
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;

            string printingText = ReviewTextBox.Text;

            printDocument.DocumentName = Movie.Movie_Name + "'s review";

            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            printingString = ReviewTextBox.Text;

            PrintPreviewDialog previewDocument = new PrintPreviewDialog();

            previewDocument.Document = printDocument;

            previewDocument.ShowDialog();
        }
    }
}
