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
    public partial class FormStatistici : Form
    {
        int nrobs;
        float[] y;
        string[] x;

        public FormStatistici()
        {
            InitializeComponent();
            nrobs = 5;
            x = new string[] { "Romania", "Spania", "Franta", "Olanda", "Germania" };
            y = new float[] { 20.0f, 75.0f, 56.0f, 36.0f, 50.0f };
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void btnInchide_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Rectangle zonaClient = e.ClipRectangle;

            Brush fundal = new SolidBrush(Color.WhiteSmoke);

            g.FillRectangle(fundal, zonaClient);

            zonaClient.X += 20; zonaClient.Y += 20;
            zonaClient.Height -= 45; zonaClient.Width -= 40;

            int vl = zonaClient.Left, vr = zonaClient.Right,
                vt = zonaClient.Top, vb = zonaClient.Bottom, i;

            Pen creionRosu = new Pen(Color.Blue, 2);
            g.DrawRectangle(creionRosu, zonaClient);

            int lat, dist;
            string denx = "";
            float rap_dis_lat = 0.2f, max;

            SolidBrush[] pensule = new SolidBrush[]
                { new SolidBrush (Color.Yellow),
                new SolidBrush (Color.Red),
                new SolidBrush (Color.DarkBlue),
                new SolidBrush (Color.Orange),
                new SolidBrush (Color.Brown),
                new SolidBrush (Color.Moccasin)
                };

            Pen[] creioane = new Pen[]
                {
                    new Pen (Color.Moccasin),
                    new Pen(Color.Yellow),
                    new Pen (Color.Blue),
                    new Pen(Color.HotPink),
                    new Pen (Color.DarkGreen),
                    new Pen (Color.LightPink),
                };

            SolidBrush pensulaCurenta;
            Pen creionCurent;

            lat = (int)((vr - vl) / (int)((nrobs + 1) * rap_dis_lat + nrobs) * 0.95);
            dist = (int)(lat * rap_dis_lat);

            for (max = y[0], i = 1; i < nrobs; i++)
                if (max < y[i]) max = y[i];

            creionCurent = creioane[0];

            g.DrawLine(creionCurent, vl, vt, vl, vb);
            g.DrawLine(creionCurent, vl, vb, vr, vb);

            for (i = 0; i < nrobs; i++)
            {
                pensulaCurenta = pensule[i % pensule.Length];
                PointF pnt = new PointF(
                    vl + i * (lat + dist) + rap_dis_lat + dist,
                    vb - 0.95f * y[i] * (vb - vt) / max
                             );
                SizeF sz = new SizeF(
                lat, 0.95f * y[i] * (vb - vt) / max
                         );
                g.FillRectangle(pensulaCurenta, new RectangleF(pnt, sz));

           

                denx = "" + x[i];
                g.DrawString(denx, Font, pensulaCurenta,
                    vl + dist + lat / 3 + i * (lat + dist), vb + 5);
            }
        }
    }
}
