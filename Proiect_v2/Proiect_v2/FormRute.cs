using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect_v2
{
    public partial class FormRute : Form
    {
        // Dictionar pentru a stoca distanțele dintre orașe
        private Dictionary<string, Dictionary<string, int>> Distanta = new Dictionary<string, Dictionary<string, int>>();

        // Dictionar pentru a stoca prețurile biletelor de avion dintre orașe
        private Dictionary<string, Dictionary<string, float>> pretBilet = new Dictionary<string, Dictionary<string, float>>();
        
        public Rute rFormRute;
        public FormRute(Rute r)
        {
            InitializeComponent();

            Distanta.Add("Bucuresti", new Dictionary<string, int>() {
                {"Timisoara", 60},
                {"Iasi", 70},
                {"Barcelona", 185},
                {"Zaragoza", 190},
                {"Valencia", 200},
                {"Paris", 190},
                {"Lyon", 155},
                {"Marseille", 170},
                {"Amsterdam", 165},
                {"Rotterdam", 160},
                {"Groningen", 190},
                {"Berlin", 130},
                {"Munchen", 125},
                {"Dortmund", 150}
            });
            Distanta.Add("Timisoara", new Dictionary<string, int>() {
                {"Bucuresti", 60},
                {"Iasi", 95 },
                {"Barcelona", 165 },
                {"Zaragoza", 160 },
                {"Valencia", 165},
                {"Paris", 135 },
                {"Lyon", 100 },
                {"Marseille", 115 },
                {"Amsterdam", 135 },
                {"Rotterdam", 130 },
                {"Groningen", 150 },
                {"Berlin", 100 },
                {"Munchen", 80 },
                {"Dortmund", 120 }
            });
            Distanta.Add("Iasi", new Dictionary<string, int>() {
                {"Bucuresti", 70},
                {"Timisoara", 95 },
                {"Barcelona", 190 },
                {"Zaragoza", 185 },
                {"Valencia", 195 },
                {"Paris", 155 },
                {"Lyon", 130 },
                {"Marseille", 145 },
                {"Amsterdam", 165 },
                {"Rotterdam", 160 },
                {"Groningen", 185 },
                {"Berlin", 110 },
                {"Munchen", 100 },
                {"Dortmund", 130 }
            });
            Distanta.Add("Barcelona", new Dictionary<string, int>() {
                {"Bucuresti", 180 },
                {"Timisoara", 165 },
                {"Iasi", 190 },
                {"Zaragoza", 60 },
                {"Valencia", 50 },
                {"Paris", 125 },
                {"Lyon", 100 },
                {"Marseille", 60 },
                {"Amsterdam", 145 },
                {"Rotterdam", 140 },
                {"Groningen", 165 },
                {"Berlin", 155 },
                {"Munchen", 120 },
                {"Dortmund", 155 }
            });
            Distanta.Add("Zaragoza", new Dictionary<string, int>() {
                {"Bucuresti", 180 },
                {"Timisoara", 165 },
                {"Iasi", 195 },
                {"Barcelona", 60 },
                {"Valencia", 45 },
                {"Paris", 125 },
                {"Lyon", 100 },
                {"Marseille", 80 },
                {"Amsterdam", 145 },
                {"Rotterdam", 140 },
                {"Groningen", 160 },
                {"Berlin", 140 },
                {"Munchen", 115 },
                {"Dortmund", 140}
            });
            Distanta.Add("Valencia", new Dictionary<string, int>() {
                {"Bucuresti", 165 },
                {"Timisoara", 145 },
                {"Iasi", 195 },
                {"Barcelona", 50 },
                {"Zaragoza", 45 },
                {"Paris", 125 },
                {"Lyon", 105 },
                {"Marseille", 70 },
                {"Amsterdam", 155 },
                {"Rotterdam", 150 },
                {"Groningen", 170 },
                {"Berlin", 140 },
                {"Munchen", 115 },
                {"Dortmund", 145 }
            });
            Distanta.Add("Paris", new Dictionary<string, int>() {
                {"Bucuresti", 155 },
                {"Timisoara", 115 },
                {"Iasi", 155 },
                {"Barcelona", 120 },
                {"Zaragoza", 100 },
                {"Valencia", 125 },
                {"Lyon", 65 },
                {"Marseille", 75 },
                {"Amsterdam", 70 },
                {"Rotterdam", 70 },
                {"Groningen", 75 },
                {"Berlin", 100 },
                {"Munchen", 90 },
                {"Dortmund", 85 }
            });
            Distanta.Add("Lyon", new Dictionary<string, int>() {
                {"Bucuresti", 155},
                {"Timisoara", 110 },
                {"Iasi", 155 },
                {"Barcelona", 90 },
                {"Zaragoza", 85 },
                {"Valencia", 95 },
                {"Paris", 65 },
                {"Marseille", 50 },
                {"Amsterdam", 100 },
                {"Rotterdam", 100 },
                {"Groningen", 110 },
                {"Berlin", 120 },
                {"Munchen", 80 },
                {"Dortmund", 100 }
            });
            Distanta.Add("Marseille", new Dictionary<string, int>() {
                {"Bucuresti", 155 },
                {"Timisoara", 125 },
                {"Iasi", 165 },
                {"Barcelona", 70 },
                {"Zaragoza", 80 },
                {"Valencia", 90 },
                {"Paris", 75 },
                {"Lyon", 50 },
                {"Amsterdam", 110 },
                {"Rotterdam", 110 },
                {"Groningen", 120 },
                {"Berlin", 120 },
                {"Munchen", 100 },
                {"Dortmund", 105 }
            });
            Distanta.Add("Amsterdam", new Dictionary<string, int>() {
                {"Bucuresti", 160},
                {"Timisoara", 120},
                {"Iasi", 155 },
                {"Barcelona", 125 },
                {"Zaragoza", 115 },
                {"Valencia", 120 },
                {"Paris", 65 },
                {"Lyon", 85 },
                {"Marseille", 110 },
                {"Rotterdam", 55 },
                {"Groningen", 50 },
                {"Berlin", 85 },
                {"Munchen", 80 },
                {"Dortmund", 60 }
            });
            Distanta.Add("Rotterdam", new Dictionary<string, int>() {
                {"Bucuresti", 135},
                {"Timisoara", 120},
                {"Iasi", 150},
                {"Barcelona", 130},
                {"Zaragoza", 120 },
                {"Valencia", 120 },
                {"Paris", 60 },
                {"Lyon", 80 },
                {"Marseille", 105 },
                {"Amsterdam", 55 },
                {"Groningen", 35 },
                {"Berlin", 70 },
                {"Munchen", 80 },
                {"Dortmund", 50 }
            });
            Distanta.Add("Groningen", new Dictionary<string, int>() {
                {"Bucuresti", 170},
                {"Timisoara", 150},
                {"Iasi", 175},
                {"Barcelona", 155},
                {"Zaragoza", 150},
                {"Valencia", 155 },
                {"Paris", 70 },
                {"Lyon", 90 },
                {"Marseille", 115 },
                {"Amsterdam", 50 },
                {"Rotterdam", 35 },
                {"Berlin", 100 },
                {"Munchen", 105 },
                {"Dortmund", 70 }
            });
            Distanta.Add("Berlin", new Dictionary<string, int>() {
                {"Bucuresti", 100},
                {"Timisoara", 80},
                {"Iasi", 105},
                {"Barcelona", 150},
                {"Zaragoza", 135},
                {"Valencia", 145 },
                {"Paris", 100 },
                {"Lyon", 100 },
                {"Marseille", 120 },
                {"Amsterdam", 75 },
                {"Rotterdam", 70 },
                {"Groningen", 70 },
                {"Munchen", 70 },
                {"Dortmund", 65 }
            });
            Distanta.Add("Munchen", new Dictionary<string, int>() {
                {"Bucuresti", 100},
                {"Timisoara", 60},
                {"Iasi", 100},
                {"Barcelona", 120},
                {"Zaragoza", 115},
                {"Valencia", 110 },
                {"Paris", 80 },
                {"Lyon", 80 },
                {"Marseille", 90 },
                {"Amsterdam", 80 },
                {"Rotterdam", 80 },
                {"Groningen", 85 },
                {"Berlin", 80 },
                {"Dortmund", 75 }
            });
            Distanta.Add("Dortmund", new Dictionary<string, int>() {
                {"Bucuresti", 120},
                {"Timisoara", 100},
                {"Iasi", 140 },
                {"Barcelona", 135 },
                {"Zaragoza", 120 },
                {"Valencia", 135 },
                {"Paris", 100 },
                {"Lyon", 105 },
                {"Marseille", 125 },
                {"Amsterdam", 60 },
                {"Rotterdam", 55 },
                {"Groningen", 65 },
                {"Berlin", 75 },
                {"Munchen", 70 }
            });

            pretBilet.Add("Bucuresti", new Dictionary<string, float>() {
                {"Timisoara", 51},
                {"Iasi", 90},
                {"Barcelona", 99},
                {"Zaragoza", 120},
                {"Valencia", 107},
                {"Paris", 127},
                {"Lyon", 98},
                {"Marseille", 94},
                {"Amsterdam", 94},
                {"Rotterdam", 93},
                {"Groningen", 94},
                {"Berlin", 65},
                {"Munchen", 139},
                {"Dortmund", 138}
            });
            pretBilet.Add("Timisoara", new Dictionary<string, float>() {
                {"Bucuresti", 45},
                {"Iasi", 154},
                {"Barcelona", 229},
                {"Zaragoza", 360},
                {"Valencia", 211},
                {"Paris", 154},
                {"Lyon", 153},
                {"Marseille", 198},
                {"Amsterdam", 168},
                {"Rotterdam", 230},
                {"Groningen", 173},
                {"Berlin", 176},
                {"Munchen", 68},
                {"Dortmund", 54}
            });
            pretBilet.Add("Iasi", new Dictionary<string, float>() {
                {"Bucuresti", 65},
                {"Timisoara", 147},
                {"Barcelona", 71},
                {"Zaragoza", 195},
                {"Valencia", 273},
                {"Paris", 90},
                {"Lyon", 206},
                {"Marseille", 163},
                {"Amsterdam", 156},
                {"Rotterdam", 399},
                {"Groningen", 300},
                {"Berlin", 299},
                {"Munchen", 140},
                {"Dortmund", 68}
            });
            pretBilet.Add("Barcelona", new Dictionary<string, float>() {
                {"Bucuresti", 89},
                {"Timisoara", 154},
                {"Iasi", 64},
                {"Zaragoza", 42},
                {"Valencia", 43},
                {"Paris", 53},
                {"Lyon", 33},
                {"Marseille", 29},
                {"Amsterdam", 60},
                {"Rotterdam", 85},
                {"Groningen", 59},
                {"Berlin", 106},
                {"Munchen", 73},
                {"Dortmund", 51}
            });
            pretBilet.Add("Zaragoza", new Dictionary<string, float>() {
                {"Bucuresti", 69},
                {"Timisoara", 154},
                {"Iasi", 64},
                {"Barcelona", 32},
                {"Valencia", 30},
                {"Paris", 73},
                {"Lyon", 33},
                {"Marseille", 26},
                {"Amsterdam", 60},
                {"Rotterdam", 85},
                {"Groningen", 59},
                {"Berlin", 105},
                {"Munchen", 63},
                {"Dortmund", 51}
            });
            pretBilet.Add("Valencia", new Dictionary<string, float>() {
                {"Bucuresti", 89},
                {"Timisoara", 210},
                {"Iasi", 226},
                {"Barcelona", 35},
                {"Zaragoza", 21},
                {"Paris", 59},
                {"Lyon", 70},
                {"Marseille", 20},
                {"Amsterdam", 101},
                {"Rotterdam", 214},
                {"Groningen", 88},
                {"Berlin", 138},
                {"Munchen", 84},
                {"Dortmund", 67}
            });
            pretBilet.Add("Paris", new Dictionary<string, float>() {
                {"Bucuresti", 49},
                {"Timisoara", 101},
                {"Iasi", 39},
                {"Barcelona", 49},
                {"Zaragoza", 31},
                {"Valencia", 80},
                {"Lyon", 112},
                {"Marseille", 90},
                {"Amsterdam", 57},
                {"Rotterdam", 58},
                {"Groningen", 55},
                {"Berlin", 41},
                {"Munchen", 65},
                {"Dortmund", 55}
            });
            pretBilet.Add("Lyon", new Dictionary<string, float>() {
                {"Bucuresti", 89},
                {"Timisoara", 154},
                {"Iasi", 64},
                {"Barcelona", 32},
                {"Zaragoza", 30},
                {"Valencia", 21},
                {"Paris", 59},
                {"Marseille", 26},
                {"Amsterdam", 60},
                {"Rotterdam", 85},
                {"Groningen", 59},
                {"Berlin", 105},
                {"Munchen", 63},
                {"Dortmund", 51}
            });
            pretBilet.Add("Marseille", new Dictionary<string, float>() {
                {"Bucuresti", 27},
                {"Timisoara", 158},
                {"Iasi", 176},
                {"Barcelona", 24},
                {"Zaragoza", 26},
                {"Valencia", 20},
                {"Paris", 130},
                {"Lyon", 132},
                {"Amsterdam", 79},
                {"Rotterdam", 83},
                {"Groningen", 74},
                {"Berlin", 174},
                {"Munchen", 91},
                {"Dortmund", 110}
            });
            pretBilet.Add("Amsterdam", new Dictionary<string, float>() {
                {"Bucuresti", 135},
                {"Timisoara", 167},
                {"Iasi", 176},
                {"Barcelona", 165},
                {"Zaragoza", 160},
                {"Valencia", 126},
                {"Paris", 69},
                {"Lyon", 135},
                {"Marseille", 195},
                {"Rotterdam", 203},
                {"Groningen", 189},
                {"Berlin", 57},
                {"Munchen", 118},
                {"Dortmund", 219}
            });
            pretBilet.Add("Rotterdam", new Dictionary<string, float>() {
                {"Bucuresti", 136},
                {"Timisoara", 166},
                {"Iasi", 175},
                {"Barcelona", 145},
                {"Zaragoza", 150},
                {"Valencia", 122},
                {"Paris", 70},
                {"Lyon", 140},
                {"Marseille", 125},
                {"Amsterdam", 240},
                {"Groningen", 176},
                {"Berlin", 45},
                {"Munchen", 38},
                {"Dortmund", 20}
            });
            pretBilet.Add("Groningen", new Dictionary<string, float>() {
                {"Bucuresti", 137},
                {"Timisoara", 160},
                {"Iasi", 180},
                {"Barcelona", 159},
                {"Zaragoza", 163},
                {"Valencia", 129},
                {"Paris", 73},
                {"Lyon", 128},
                {"Marseille", 180},
                {"Amsterdam", 247},
                {"Rotterdam", 199},
                {"Berlin", 50},
                {"Munchen", 120},
                {"Dortmund", 230}
            });
            pretBilet.Add("Berlin", new Dictionary<string, float>() {
                {"Bucuresti", 160},
                {"Timisoara", 152},
                {"Iasi", 173},
                {"Barcelona", 130},
                {"Zaragoza", 200},
                {"Valencia", 140},
                {"Paris", 63},
                {"Lyon", 171},
                {"Marseille", 141},
                {"Amsterdam", 38},
                {"Rotterdam", 39},
                {"Groningen", 40},
                {"Munchen", 131},
                {"Dortmund", 17}
            });
            pretBilet.Add("Munchen", new Dictionary<string, float>() {
                {"Bucuresti", 207},
                {"Timisoara", 281},
                {"Iasi", 167},
                {"Barcelona", 120},
                {"Zaragoza", 125},
                {"Valencia", 171},
                {"Paris", 68},
                {"Lyon", 63},
                {"Marseille", 107},
                {"Amsterdam", 39},
                {"Rotterdam", 37},
                {"Groningen", 28},
                {"Berlin", 48},
                {"Dortmund", 16}
            });
            pretBilet.Add("Dortmund", new Dictionary<string, float>() {
                {"Bucuresti", 88},
                {"Timisoara", 48},
                {"Iasi", 72},
                {"Barcelona", 71},
                {"Zaragoza", 78},
                {"Valencia", 69},
                {"Paris", 53},
                {"Lyon", 75},
                {"Marseille", 138},
                {"Amsterdam", 20},
                {"Rotterdam", 22},
                {"Groningen", 112},
                {"Berlin", 27},
                {"Munchen", 19}
            });

            tvPlecare.Nodes.Add("Romania");
            tvPlecare.Nodes[0].Nodes.Add("Bucuresti");
            tvPlecare.Nodes[0].Nodes.Add("Timisoara");
            tvPlecare.Nodes[0].Nodes.Add("Iasi");
            tvPlecare.Nodes[0].Nodes[0].Nodes.Add("Aeroportul international Henri Coanda");
            tvPlecare.Nodes[0].Nodes[1].Nodes.Add("Aeroportul international Traian Vuia");
            tvPlecare.Nodes[0].Nodes[2].Nodes.Add("Aeroportul international Iasi");

            tvPlecare.Nodes.Add("Spania");
            tvPlecare.Nodes[1].Nodes.Add("Barcelona");
            tvPlecare.Nodes[1].Nodes.Add("Zaragoza");
            tvPlecare.Nodes[1].Nodes.Add("Valencia");
            tvPlecare.Nodes[1].Nodes[0].Nodes.Add("El Prat de Llobregat");
            tvPlecare.Nodes[1].Nodes[1].Nodes.Add("Aeropuerto de Zaragoza");
            tvPlecare.Nodes[1].Nodes[2].Nodes.Add("Aeropuerto de Valencia");

            tvPlecare.Nodes.Add("Franta");
            tvPlecare.Nodes[2].Nodes.Add("Paris");
            tvPlecare.Nodes[2].Nodes.Add("Lyon");
            tvPlecare.Nodes[2].Nodes.Add("Marseille");
            tvPlecare.Nodes[2].Nodes[0].Nodes.Add("Aeroport de Paris-Charles de Gaulle");
            tvPlecare.Nodes[2].Nodes[1].Nodes.Add("Aeroport de Lyon-Saint Exupery");
            tvPlecare.Nodes[2].Nodes[2].Nodes.Add("Aeroport de Marseille Provence");

            tvPlecare.Nodes.Add("Olanda");
            tvPlecare.Nodes[3].Nodes.Add("Amsterdam");
            tvPlecare.Nodes[3].Nodes.Add("Rotterdam");
            tvPlecare.Nodes[3].Nodes.Add("Groningen");
            tvPlecare.Nodes[3].Nodes[0].Nodes.Add("Amsterdam Airport Schiphol");
            tvPlecare.Nodes[3].Nodes[1].Nodes.Add("Rotterdam The Hague Airport");
            tvPlecare.Nodes[3].Nodes[2].Nodes.Add("Groningen Airport Eelde");

            tvPlecare.Nodes.Add("Germania");
            tvPlecare.Nodes[4].Nodes.Add("Berlin");
            tvPlecare.Nodes[4].Nodes.Add("Munchen");
            tvPlecare.Nodes[4].Nodes.Add("Dortmund");
            tvPlecare.Nodes[4].Nodes[0].Nodes.Add("Berlin Brandenburg International Airport");
            tvPlecare.Nodes[4].Nodes[1].Nodes.Add("Munich Airport");
            tvPlecare.Nodes[4].Nodes[2].Nodes.Add("Dortmund Airport");

            if (r == null)
                rFormRute = new Rute();
            else
            {
                rFormRute = r;
                comboBox1.Text = rFormRute.nrRez.ToString();
                tvPlecare.Text = rFormRute.AeroportPlecare;
                lbSosire.Text = rFormRute.AeroportSosire;
                dateTimePicker1.Value = rFormRute.Data;
                textBox4.Text = rFormRute.Distanta.ToString();
                textBox5.Text = rFormRute.Pret.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rFormRute.nrRez = int.Parse(comboBox1.Text);
            //rFormRute.AeroportPlecare = tvPlecare.SelectedNode.Text;
            //rFormRute.AeroportSosire = lbSosire.Text;
            rFormRute.Data = dateTimePicker1.Value;
            rFormRute.Distanta = int.Parse(textBox4.Text);
            rFormRute.Pret = float.Parse(textBox5.Text);
        }

        private void tvPlecare_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedNodeText = e.Node.Text;

            string airportName = "";

            List<string> citiesList = new List<string>();
            foreach (TreeNode countryNode in tvPlecare.Nodes)
            {
                foreach (TreeNode cityNode in countryNode.Nodes)
                {
                    if (cityNode.Text == selectedNodeText)
                    {
                        // Am gasit nodul orasului selectat, asadar putem cauta nodul aeroportului corespunzator
                        foreach (TreeNode airportNode in cityNode.Nodes)
                        {
                            airportName = airportNode.Text;
                        }
                    }
                }
            }

            foreach (TreeNode countryNode in tvPlecare.Nodes)
            {
                foreach (TreeNode cityNode in countryNode.Nodes)
                {
                    if (cityNode.Text != selectedNodeText)
                    {
                        citiesList.Add(cityNode.Text);
                    }
                }
            }
            lbSosire.Items.Clear();
            lbSosire.Items.AddRange(citiesList.ToArray());
            rFormRute.AeroportPlecare = airportName;
            Dist();
            Pret();
        }

        private void lbSosire_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity = lbSosire.SelectedItem.ToString();
           
            string airportName = "";
            foreach (TreeNode countryNode in tvPlecare.Nodes)
            {
                foreach (TreeNode cityNode in countryNode.Nodes)
                {
                    if (cityNode.Text == selectedCity)
                    {
                       
                        foreach (TreeNode airportNode in cityNode.Nodes)
                        {
                            airportName = airportNode.Text;
                        }
                    }
                }
            }
            rFormRute.AeroportSosire = airportName;
            Dist();
            Pret();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void Dist()
        {
            
            if (tvPlecare.SelectedNode != null && lbSosire.SelectedItem != null && tvPlecare.SelectedNode.Text != lbSosire.SelectedItem.ToString())
            {
                
                int dist = Distanta[tvPlecare.SelectedNode.Text][lbSosire.SelectedItem.ToString()];

               
                textBox4.Text = dist.ToString();
            }
        }

        private void Pret()
        {
            {
                
                if (tvPlecare.SelectedNode != null && lbSosire.SelectedItem != null && tvPlecare.SelectedNode.Text != lbSosire.SelectedItem.ToString())
                {
                    
                    float pret = pretBilet[tvPlecare.SelectedNode.Text][lbSosire.SelectedItem.ToString()];

                    
                    textBox5.Text = string.Format("{0:F2}", pret);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
