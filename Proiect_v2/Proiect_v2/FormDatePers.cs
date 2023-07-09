using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_v2
{
    public partial class FormDatePers : Form
    {
        int pagcurenta = 0;
        
        public DatePers dFormDatePers;
        public FormDatePers(DatePers dp)
        {
            InitializeComponent();

            if (dp == null)
                dFormDatePers = new DatePers();
            else{
                dFormDatePers = dp;
                textBox1.Text = dp.Nume;
                textBox2.Text = dp.Prenume;
                textBox3.Text = dp.CNP;
                textBox4.Text = dp.Numar;
                textBox5.Text = dp.Email;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dFormDatePers.Nume = textBox1.Text;
            dFormDatePers.Prenume = textBox2.Text;
            dFormDatePers.CNP = textBox3.Text;
            dFormDatePers.Numar = textBox4.Text;
            dFormDatePers.Email = textBox5.Text;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            PageSettings settings = printDocument1.DefaultPageSettings;
            var total_width = settings.PaperSize.Width -
                settings.Margins.Right - settings.Margins.Left;
            var total_height = settings.PaperSize.Height -
                settings.Margins.Top - settings.Margins.Bottom;

            if (pagcurenta == 0)
            {
                e.Graphics.DrawString(textBox1.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 150, 125);
                e.Graphics.DrawString(textBox2.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 150, 175);
                e.Graphics.DrawString(textBox3.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 150, 225);
                e.Graphics.DrawString(textBox4.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 150, 275);
                e.Graphics.DrawString(textBox5.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 150, 325);
            }
            else if (pagcurenta == 1)
            {
                e.Graphics.DrawString("PAGINA 2", new Font("Arial", 40, FontStyle.Bold), Brushes.Black, 150, 125);
            }
            pagcurenta++;

            if (pagcurenta < 2)
                e.HasMorePages = true;
            else
            {
                e.HasMorePages = false;
                pagcurenta = 0;
            }
        }

        private void textBox6_DragDrop(object sender, DragEventArgs e)
        {
            string data = (string)e.Data.GetData(typeof(string));
            textBox6.Text = data;
            if (e.Effect == DragDropEffects.Move)
            {
                listBox1.Items.Remove(data);
            }
        }

        private void textBox6_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Move | DragDropEffects.Copy;
            }
            else
            { e.Effect = DragDropEffects.None; }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox lb = sender as ListBox;
            if (lb.SelectedItems.Count > 0 && e.Button == MouseButtons.Right)
            {
                lb.DoDragDrop(lb.SelectedItems[0], DragDropEffects.Copy);
            }
            else if (lb.SelectedItems.Count > 0)
                lb.DoDragDrop(lb.SelectedItems[0], DragDropEffects.Move);
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Length < 5)
            {
                errorProvider1.SetError(textBox1, "Numele este mai scurt de 5 caractere");
                e.Cancel = true;
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");
        }
    }
}
