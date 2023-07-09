using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_v2
{
    public partial class UserControl1 : UserControl
    {
        public event EventHandler LoginSuccess;
        
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "student")
            {
               
                OnLoginSuccess(EventArgs.Empty);
                this.Parent.Controls.Remove(this);
            }
            else
            {
               
                MessageBox.Show("               Autentificare esuata. \nNumele de utilizator sau parola incorecte.");
            }
        }
        protected virtual void OnLoginSuccess(EventArgs e)
        {
            LoginSuccess?.Invoke(this, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
