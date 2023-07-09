namespace Proiect_v2
{
    partial class FormRezervare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRezervare));
            this.listView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incarcaFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inchideAplicatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaRutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editeazaRutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datePersonaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.graficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRezervare = new System.Windows.Forms.Button();
            this.lvDatePers = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView1.BackgroundImage")));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 34);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1001, 216);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.Text = "Nr. Rezervari";
            this.ColumnHeader.Width = 160;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Aeroport Plecare";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 220;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Aeroport Sosire";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 220;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Data";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Distanta(min)";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 145;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Pret bilet(€)";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 130;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareToolStripMenuItem,
            this.editareToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 76);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // adaugareToolStripMenuItem
            // 
            this.adaugareToolStripMenuItem.Name = "adaugareToolStripMenuItem";
            this.adaugareToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.adaugareToolStripMenuItem.Text = "Adaugare";
            this.adaugareToolStripMenuItem.Click += new System.EventHandler(this.adaugareToolStripMenuItem_Click);
            // 
            // editareToolStripMenuItem
            // 
            this.editareToolStripMenuItem.Name = "editareToolStripMenuItem";
            this.editareToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.editareToolStripMenuItem.Text = "Editare";
            this.editareToolStripMenuItem.Click += new System.EventHandler(this.editareToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisiereToolStripMenuItem,
            this.ruteToolStripMenuItem,
            this.datePersonaleToolStripMenuItem,
            this.graficToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1001, 35);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fisiereToolStripMenuItem
            // 
            this.fisiereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaFisierToolStripMenuItem,
            this.incarcaFisierToolStripMenuItem,
            this.inchideAplicatieToolStripMenuItem});
            this.fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            this.fisiereToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.fisiereToolStripMenuItem.Text = "Fisiere";
            // 
            // salveazaFisierToolStripMenuItem
            // 
            this.salveazaFisierToolStripMenuItem.Name = "salveazaFisierToolStripMenuItem";
            this.salveazaFisierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salveazaFisierToolStripMenuItem.Size = new System.Drawing.Size(298, 30);
            this.salveazaFisierToolStripMenuItem.Text = "Salveaza fisier";
            this.salveazaFisierToolStripMenuItem.Click += new System.EventHandler(this.salveazaFisierToolStripMenuItem_Click);
            // 
            // incarcaFisierToolStripMenuItem
            // 
            this.incarcaFisierToolStripMenuItem.Name = "incarcaFisierToolStripMenuItem";
            this.incarcaFisierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.incarcaFisierToolStripMenuItem.Size = new System.Drawing.Size(298, 30);
            this.incarcaFisierToolStripMenuItem.Text = "Incarca fisier";
            this.incarcaFisierToolStripMenuItem.Click += new System.EventHandler(this.incarcaFisierToolStripMenuItem_Click);
            // 
            // inchideAplicatieToolStripMenuItem
            // 
            this.inchideAplicatieToolStripMenuItem.Name = "inchideAplicatieToolStripMenuItem";
            this.inchideAplicatieToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.inchideAplicatieToolStripMenuItem.Size = new System.Drawing.Size(298, 30);
            this.inchideAplicatieToolStripMenuItem.Text = "Inchide aplicatie";
            this.inchideAplicatieToolStripMenuItem.Click += new System.EventHandler(this.inchideAplicatieToolStripMenuItem_Click);
            // 
            // ruteToolStripMenuItem
            // 
            this.ruteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaRutaToolStripMenuItem,
            this.editeazaRutaToolStripMenuItem,
            this.stergereToolStripMenuItem});
            this.ruteToolStripMenuItem.Name = "ruteToolStripMenuItem";
            this.ruteToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.ruteToolStripMenuItem.Text = "Rute";
            this.ruteToolStripMenuItem.Click += new System.EventHandler(this.ruteToolStripMenuItem_Click);
            // 
            // adaugaRutaToolStripMenuItem
            // 
            this.adaugaRutaToolStripMenuItem.Name = "adaugaRutaToolStripMenuItem";
            this.adaugaRutaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.adaugaRutaToolStripMenuItem.Size = new System.Drawing.Size(245, 30);
            this.adaugaRutaToolStripMenuItem.Text = "Adaugare";
            this.adaugaRutaToolStripMenuItem.Click += new System.EventHandler(this.adaugaRutaToolStripMenuItem_Click);
            // 
            // editeazaRutaToolStripMenuItem
            // 
            this.editeazaRutaToolStripMenuItem.Name = "editeazaRutaToolStripMenuItem";
            this.editeazaRutaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editeazaRutaToolStripMenuItem.Size = new System.Drawing.Size(245, 30);
            this.editeazaRutaToolStripMenuItem.Text = "Editare";
            this.editeazaRutaToolStripMenuItem.Click += new System.EventHandler(this.editeazaRutaToolStripMenuItem_Click);
            // 
            // stergereToolStripMenuItem
            // 
            this.stergereToolStripMenuItem.Name = "stergereToolStripMenuItem";
            this.stergereToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.stergereToolStripMenuItem.Size = new System.Drawing.Size(245, 30);
            this.stergereToolStripMenuItem.Text = "Stergere";
            this.stergereToolStripMenuItem.Click += new System.EventHandler(this.stergereToolStripMenuItem_Click);
            // 
            // datePersonaleToolStripMenuItem
            // 
            this.datePersonaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.editeazaToolStripMenuItem,
            this.stergereToolStripMenuItem1});
            this.datePersonaleToolStripMenuItem.Name = "datePersonaleToolStripMenuItem";
            this.datePersonaleToolStripMenuItem.Size = new System.Drawing.Size(152, 29);
            this.datePersonaleToolStripMenuItem.Text = "Date personale";
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(178, 30);
            this.adaugaToolStripMenuItem.Text = "Adaugare";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // editeazaToolStripMenuItem
            // 
            this.editeazaToolStripMenuItem.Name = "editeazaToolStripMenuItem";
            this.editeazaToolStripMenuItem.Size = new System.Drawing.Size(178, 30);
            this.editeazaToolStripMenuItem.Text = "Editare";
            this.editeazaToolStripMenuItem.Click += new System.EventHandler(this.editeazaToolStripMenuItem_Click);
            // 
            // stergereToolStripMenuItem1
            // 
            this.stergereToolStripMenuItem1.Name = "stergereToolStripMenuItem1";
            this.stergereToolStripMenuItem1.Size = new System.Drawing.Size(178, 30);
            this.stergereToolStripMenuItem1.Text = "Stergere";
            this.stergereToolStripMenuItem1.Click += new System.EventHandler(this.stergereToolStripMenuItem1_Click);
            // 
            // graficToolStripMenuItem
            // 
            this.graficToolStripMenuItem.Name = "graficToolStripMenuItem";
            this.graficToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.graficToolStripMenuItem.Text = "Grafic";
            this.graficToolStripMenuItem.Click += new System.EventHandler(this.statisticiToolStripMenuItem_Click);
            // 
            // btnRezervare
            // 
            this.btnRezervare.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRezervare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRezervare.BackgroundImage")));
            this.btnRezervare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRezervare.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRezervare.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnRezervare.Location = new System.Drawing.Point(436, 414);
            this.btnRezervare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRezervare.Name = "btnRezervare";
            this.btnRezervare.Size = new System.Drawing.Size(138, 55);
            this.btnRezervare.TabIndex = 9;
            this.btnRezervare.Text = "Rezervari";
            this.btnRezervare.UseVisualStyleBackColor = false;
            this.btnRezervare.Click += new System.EventHandler(this.btnRezervare_Click);
            // 
            // lvDatePers
            // 
            this.lvDatePers.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvDatePers.BackColor = System.Drawing.Color.White;
            this.lvDatePers.BackgroundImage = global::Proiect_v2.Properties.Resources.AirLine_1_3;
            this.lvDatePers.BackgroundImageTiled = true;
            this.lvDatePers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader9,
            this.columnHeader10});
            this.lvDatePers.ContextMenuStrip = this.contextMenuStrip2;
            this.lvDatePers.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDatePers.ForeColor = System.Drawing.Color.Black;
            this.lvDatePers.HideSelection = false;
            this.lvDatePers.HoverSelection = true;
            this.lvDatePers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvDatePers.Location = new System.Drawing.Point(0, 249);
            this.lvDatePers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvDatePers.Name = "lvDatePers";
            this.lvDatePers.Size = new System.Drawing.Size(1001, 157);
            this.lvDatePers.TabIndex = 10;
            this.lvDatePers.UseCompatibleStateImageBehavior = false;
            this.lvDatePers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "     Nume";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prenume";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CNP";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Telefon";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 135;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Email";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 210;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareToolStripMenuItem1,
            this.editareToolStripMenuItem1,
            this.stergereToolStripMenuItem2});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(144, 76);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // adaugareToolStripMenuItem1
            // 
            this.adaugareToolStripMenuItem1.Name = "adaugareToolStripMenuItem1";
            this.adaugareToolStripMenuItem1.Size = new System.Drawing.Size(143, 24);
            this.adaugareToolStripMenuItem1.Text = "Adaugare";
            this.adaugareToolStripMenuItem1.Click += new System.EventHandler(this.adaugareToolStripMenuItem1_Click);
            // 
            // editareToolStripMenuItem1
            // 
            this.editareToolStripMenuItem1.Name = "editareToolStripMenuItem1";
            this.editareToolStripMenuItem1.Size = new System.Drawing.Size(143, 24);
            this.editareToolStripMenuItem1.Text = "Editare";
            this.editareToolStripMenuItem1.Click += new System.EventHandler(this.editareToolStripMenuItem1_Click);
            // 
            // stergereToolStripMenuItem2
            // 
            this.stergereToolStripMenuItem2.Name = "stergereToolStripMenuItem2";
            this.stergereToolStripMenuItem2.Size = new System.Drawing.Size(143, 24);
            this.stergereToolStripMenuItem2.Text = "Stergere";
            this.stergereToolStripMenuItem2.Click += new System.EventHandler(this.stergereToolStripMenuItem2_Click);
            // 
            // FormRezervare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1001, 491);
            this.Controls.Add(this.lvDatePers);
            this.Controls.Add(this.btnRezervare);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRezervare";
            this.Text = "Rezervare";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ColumnHeader;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incarcaFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inchideAplicatieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaRutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editeazaRutaToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datePersonaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editeazaToolStripMenuItem;
        private System.Windows.Forms.Button btnRezervare;
        private System.Windows.Forms.ListView lvDatePers;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem graficToolStripMenuItem;
    }
}

