using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect_v2
{
    public partial class FormRezervare : Form
    {
        public FormRezervare()
        {
            InitializeComponent();
        }

        private void editeazaRutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Rute r = listView1.SelectedItems[0].Tag as Rute;
                FormRute fr = new FormRute(r);
                if (fr.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem l1 = listView1.SelectedItems[0];
                    l1.SubItems[0].Text = r.nrRez.ToString(); 
                    l1.SubItems[1].Text = r.AeroportPlecare;
                    l1.SubItems[2].Text = r.AeroportSosire;
                    l1.SubItems[3].Text = r.Data.ToString();
                    l1.SubItems[4].Text = r.Distanta.ToString();
                    l1.SubItems[5].Text = r.Pret.ToString();
                }
            }
        }

        private void adaugaRutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRute fr = new FormRute(null);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                ListViewItem lv = new ListViewItem(fr.rFormRute.nrRez.ToString());
                lv.SubItems.Add(fr.rFormRute.AeroportPlecare);
                lv.SubItems.Add(fr.rFormRute.AeroportSosire);
                lv.SubItems.Add(fr.rFormRute.Data.ToString());
                lv.SubItems.Add(fr.rFormRute.Distanta.ToString());
                lv.SubItems.Add(fr.rFormRute.Pret.ToString());
                lv.Tag = fr.rFormRute;
                listView1.Items.Add(lv);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                listView1.SelectedItems[0].Remove();
        }

        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRute fr = new FormRute(null);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                ListViewItem lv = new ListViewItem(fr.rFormRute.nrRez.ToString());
                lv.SubItems.Add(fr.rFormRute.AeroportPlecare);
                lv.SubItems.Add(fr.rFormRute.AeroportSosire);
                lv.SubItems.Add(fr.rFormRute.Data.ToString());
                lv.SubItems.Add(fr.rFormRute.Distanta.ToString());
                lv.SubItems.Add(fr.rFormRute.Pret.ToString());
                lv.Tag = fr.rFormRute;
                listView1.Items.Add(lv);
            }
        }

        private void editareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Rute r = listView1.SelectedItems[0].Tag as Rute;
                FormRute fr = new FormRute(r);
                if (fr.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem l1 = listView1.SelectedItems[0];
                    l1.SubItems[0].Text = r.nrRez.ToString();
                    l1.SubItems[1].Text = r.AeroportPlecare;
                    l1.SubItems[2].Text = r.AeroportSosire;
                    l1.SubItems[3].Text = r.Data.ToString();
                    l1.SubItems[4].Text = r.Distanta.ToString();
                    l1.SubItems[5].Text = r.Pret.ToString();
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                editareToolStripMenuItem.Enabled = true;
                stergeToolStripMenuItem.Enabled = true;
            }
            else
            {
                editareToolStripMenuItem.Enabled = false;
                stergeToolStripMenuItem.Enabled = false;
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                listView1.SelectedItems[0].Remove();
        }

        private void ruteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0){
                editeazaRutaToolStripMenuItem.Enabled = true;
                stergereToolStripMenuItem.Enabled = true;
            }
            else{
                editeazaRutaToolStripMenuItem.Enabled = false;
                stergereToolStripMenuItem.Enabled = false;
            }
            if (lvDatePers.SelectedItems.Count > 0){
                editeazaToolStripMenuItem.Enabled = true;
                stergereToolStripMenuItem1.Enabled = true;
            }
            else{
                editeazaToolStripMenuItem.Enabled = false;
                stergereToolStripMenuItem1.Enabled = false;
            }
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDatePers fdp = new FormDatePers(null);
            if (fdp.ShowDialog() == DialogResult.OK)
            {
                ListViewItem lv = new ListViewItem(fdp.dFormDatePers.Nume);
                lv.SubItems.Add(fdp.dFormDatePers.Prenume);
                lv.SubItems.Add(fdp.dFormDatePers.CNP);
                lv.SubItems.Add(fdp.dFormDatePers.Numar);
                lv.SubItems.Add(fdp.dFormDatePers.Email);
                lv.SubItems.Add(fdp.dFormDatePers.Email);
                lv.Tag = fdp.dFormDatePers;
                lvDatePers.Items.Add(lv);
            }
        }

        private void editeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvDatePers.SelectedItems.Count > 0)
            {
                DatePers dp = lvDatePers.SelectedItems[0].Tag as DatePers;
                FormDatePers fdp = new FormDatePers(dp);
                if (fdp.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem l1 = lvDatePers.SelectedItems[0];
                    l1.SubItems[0].Text = dp.Nume;
                    l1.SubItems[1].Text = dp.Prenume;
                    l1.SubItems[2].Text = dp.CNP;
                    l1.SubItems[3].Text = dp.Numar;
                    l1.SubItems[4].Text = dp.Email;
                }
            }
        }

        private void stergereToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lvDatePers.SelectedItems.Count > 0)
                lvDatePers.SelectedItems[0].Remove();
        }

        private void adaugareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormDatePers fdp = new FormDatePers(null);
            if (fdp.ShowDialog() == DialogResult.OK)
            {
                ListViewItem lv = new ListViewItem(fdp.dFormDatePers.Nume);
                lv.SubItems.Add(fdp.dFormDatePers.Prenume);
                lv.SubItems.Add(fdp.dFormDatePers.CNP);
                lv.SubItems.Add(fdp.dFormDatePers.Numar);
                lv.SubItems.Add(fdp.dFormDatePers.Email);
                lv.SubItems.Add(fdp.dFormDatePers.Email);
                lv.Tag = fdp.dFormDatePers;
                lvDatePers.Items.Add(lv);
            }
        }

        private void editareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lvDatePers.SelectedItems.Count > 0)
            {
                DatePers dp = lvDatePers.SelectedItems[0].Tag as DatePers;
                FormDatePers fdp = new FormDatePers(dp);
                if (fdp.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem l1 = lvDatePers.SelectedItems[0];
                    l1.SubItems[0].Text = dp.Nume;
                    l1.SubItems[1].Text = dp.Prenume;
                    l1.SubItems[2].Text = dp.CNP;
                    l1.SubItems[3].Text = dp.Numar;
                    l1.SubItems[4].Text = dp.Email;
                }
            }
        }

        private void stergereToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (lvDatePers.SelectedItems.Count > 0)
                lvDatePers.SelectedItems[0].Remove();
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            if (lvDatePers.SelectedItems.Count > 0)
            {
                editareToolStripMenuItem1.Enabled = true;
                stergereToolStripMenuItem2.Enabled = true;
            }
            else
            {
                editareToolStripMenuItem1.Enabled = false;
                stergereToolStripMenuItem2.Enabled = false;
            }
        }

        private void inchideAplicatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salveazaFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Fisier rezervari *.xml|*.xml";
            sfd.CheckPathExists = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Rezervari rezervari = new Rezervari();
                foreach (ListViewItem lv in listView1.Items)
                {
                    rezervari.ListaRute.Add((Rute)lv.Tag);
                }
                foreach (ListViewItem lv1 in lvDatePers.Items)
                {
                    rezervari.ListaDatePers.Add((DatePers)lv1.Tag);
                }
                XmlSerializer serializator = new XmlSerializer(typeof(Rezervari));
                TextWriter writer = new StreamWriter(sfd.FileName);
                serializator.Serialize(writer, rezervari);
                writer.Close();
            }
        }

        private void incarcaFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fisier rezervari *.xml|*.xml";
            ofd.CheckFileExists = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XmlSerializer serializator = new XmlSerializer(typeof(Rezervari));
                    StreamReader reader = new StreamReader(ofd.FileName);
                    Rezervari rezervari = (Rezervari)serializator.Deserialize(reader);
                    reader.Close();

                    listView1.Items.Clear();
                    lvDatePers.Items.Clear();

                    foreach (Rute r in rezervari.ListaRute)
                    {
                        ListViewItem lv = new ListViewItem(new string[] { r.nrRez.ToString(), r.AeroportPlecare, r.AeroportSosire, r.Data.ToString(), r.Distanta.ToString(), r.Pret.ToString() });
                        lv.Tag = r;
                        listView1.Items.Add(lv);
                    }

                    foreach (DatePers dp in rezervari.ListaDatePers)
                    {
                        ListViewItem lv = new ListViewItem(new string[] { dp.Nume, dp.Prenume, dp.CNP, dp.Numar, dp.Email });
                        lv.Tag = dp;
                        lvDatePers.Items.Add(lv);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRezervare_Click(object sender, EventArgs e)
        {
            FormDB fdb = new FormDB();
            fdb.Show();
        }

        private void statisticiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStatistici fs = new FormStatistici();
            fs.Show();
        }
    }
}
