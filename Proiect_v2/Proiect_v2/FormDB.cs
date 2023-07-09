using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_v2
{
    public partial class FormDB : Form
    {
        private bool isLoggedIn = false;

        public FormDB()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormDB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_DB_AirlinesDataSet2.Airline' table. You can move, or remove it, as needed.
            this.airlineTableAdapter2.Fill(this._DB_AirlinesDataSet2.Airline);
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            string stringConexiune = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DB-Airlines;Integrated Security=True";
            SqlConnection conexiune = new SqlConnection(stringConexiune);
            conexiune.Open();

            string insertCommand = "insert into Airline values(@Nume, @Telefon, @Email, @NrRezervari)";
            SqlCommand comanda = new SqlCommand(insertCommand, conexiune);
            comanda.Parameters.AddWithValue("@Nume", tbNume.Text);
            comanda.Parameters.AddWithValue("@Telefon", tbTelefon.Text);
            comanda.Parameters.AddWithValue("@Email", tbEmail.Text);
            comanda.Parameters.AddWithValue("@NrRezervari", int.Parse(tbNrRezervari.Text));
            comanda.ExecuteNonQuery();
            conexiune.Close();
            MessageBox.Show("Datele au fost salvate cu succes!");
        }

        private void btnActualizeaza_Click(object sender, EventArgs e)
        {
            string stringConexiune = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DB-Airlines;Integrated Security=True";
            SqlConnection conexiune = new SqlConnection(stringConexiune);
            conexiune.Open();

            string updateCommand = "update Airline set Nume=@Nume, Telefon=@Telefon, Email=@Email, NrRezervari=@NrRezervari where Id=@Id";
            SqlCommand comanda = new SqlCommand(updateCommand, conexiune);
            comanda.Parameters.AddWithValue("@Id", int.Parse(tbId.Text));
            comanda.Parameters.AddWithValue("@Nume", tbNume.Text);
            comanda.Parameters.AddWithValue("@Telefon", tbTelefon.Text);
            comanda.Parameters.AddWithValue("@Email", tbEmail.Text);
            comanda.Parameters.AddWithValue("@NrRezervari", int.Parse(tbNrRezervari.Text));
            comanda.ExecuteNonQuery();
            conexiune.Close();
            MessageBox.Show("Datele au fost actualizate cu succes!");
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {
            string stringConexiune = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DB-Airlines;Integrated Security=True";
            using (SqlConnection conexiune = new SqlConnection(stringConexiune))
            {
                conexiune.Open();
                string selectCommand = "select * from Airline where Id=@Id";
                SqlCommand comanda = new SqlCommand(selectCommand, conexiune);
                comanda.Parameters.AddWithValue("@Id", tbId.Text);
                SqlDataReader reader = comanda.ExecuteReader();
                if (reader.Read())
                {
                    tbNume.Text = reader["Nume"].ToString();
                    tbTelefon.Text = reader["Telefon"].ToString();
                    tbEmail.Text = reader["Email"].ToString();
                    tbNrRezervari.Text = reader["NrRezervari"].ToString();
                }
                else
                {
                    tbNume.Text = "";
                    tbTelefon.Text = "";
                    tbEmail.Text = "";
                    tbNrRezervari.Text = "";
                }
                reader.Close();
            }
        }
        private void LoginControl_LoginSuccess(object sender, EventArgs e)
        {
            isLoggedIn = true;
            string stringConexiune = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DB-Airlines;Integrated Security=True";
            SqlConnection conexiune = new SqlConnection(stringConexiune);
            conexiune.Open();
            string deleteCommand = "delete from Airline where Id=@Id";
            SqlCommand comanda = new SqlCommand(deleteCommand, conexiune);
            comanda.Parameters.AddWithValue("@Id", int.Parse(tbId.Text));
            comanda.ExecuteNonQuery();
            conexiune.Close();
            MessageBox.Show("Datele au fost sterse cu succes!");
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            UserControl1 loginControl = new UserControl1();
            loginControl.LoginSuccess += LoginControl_LoginSuccess;
            this.Controls.Add(loginControl);
            loginControl.Location = new Point((this.Width - loginControl.Width) / 2, (this.Height - loginControl.Height) / 2);
            loginControl.Size = new Size(320, 340);
            loginControl.BringToFront();
        }

        private void btnInchide_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
