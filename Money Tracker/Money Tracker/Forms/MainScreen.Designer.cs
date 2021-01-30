namespace Money_Tracker
{
    partial class MainScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.optionPanel = new System.Windows.Forms.Panel();
            this.labelSuma = new System.Windows.Forms.Label();
            this.filtruDescriere = new System.Windows.Forms.TextBox();
            this.labelFiltru1 = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.filtruData = new System.Windows.Forms.DateTimePicker();
            this.sortLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.findPicture2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnEconomii = new System.Windows.Forms.Button();
            this.btnVenituri = new System.Windows.Forms.Button();
            this.btnCheltuieli = new System.Windows.Forms.Button();
            this.btnStatisctica = new System.Windows.Forms.Button();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteRecord = new System.Windows.Forms.Button();
            this.addEconomii = new System.Windows.Forms.Button();
            this.addVenituri = new System.Windows.Forms.Button();
            this.addCheltuieli = new System.Windows.Forms.Button();
            this.filtruSuma = new System.Windows.Forms.NumericUpDown();
            this.labelVenit = new System.Windows.Forms.Label();
            this.filtruTip = new System.Windows.Forms.ComboBox();
            this.setFilter = new System.Windows.Forms.Button();
            this.resetFiltre = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.optionPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findPicture2)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filtruSuma)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.optionPanel);
            this.headerPanel.Controls.Add(this.panel2);
            this.headerPanel.Controls.Add(this.titlePanel);
            this.headerPanel.Controls.Add(this.panel1);
            this.headerPanel.Controls.Add(this.panel6);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1078, 225);
            this.headerPanel.TabIndex = 3;
            // 
            // optionPanel
            // 
            this.optionPanel.Controls.Add(this.resetFiltre);
            this.optionPanel.Controls.Add(this.setFilter);
            this.optionPanel.Controls.Add(this.filtruTip);
            this.optionPanel.Controls.Add(this.labelVenit);
            this.optionPanel.Controls.Add(this.filtruSuma);
            this.optionPanel.Controls.Add(this.labelSuma);
            this.optionPanel.Controls.Add(this.filtruDescriere);
            this.optionPanel.Controls.Add(this.labelFiltru1);
            this.optionPanel.Controls.Add(this.labelData);
            this.optionPanel.Controls.Add(this.filtruData);
            this.optionPanel.Controls.Add(this.sortLabel);
            this.optionPanel.Location = new System.Drawing.Point(8, 123);
            this.optionPanel.Name = "optionPanel";
            this.optionPanel.Size = new System.Drawing.Size(1058, 99);
            this.optionPanel.TabIndex = 14;
            // 
            // labelSuma
            // 
            this.labelSuma.AutoSize = true;
            this.labelSuma.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelSuma.Location = new System.Drawing.Point(4, 59);
            this.labelSuma.Name = "labelSuma";
            this.labelSuma.Size = new System.Drawing.Size(61, 16);
            this.labelSuma.TabIndex = 9;
            this.labelSuma.Text = "Suma : ";
            // 
            // filtruDescriere
            // 
            this.filtruDescriere.Location = new System.Drawing.Point(100, 27);
            this.filtruDescriere.Name = "filtruDescriere";
            this.filtruDescriere.Size = new System.Drawing.Size(319, 20);
            this.filtruDescriere.TabIndex = 8;
            // 
            // labelFiltru1
            // 
            this.labelFiltru1.AutoSize = true;
            this.labelFiltru1.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelFiltru1.Location = new System.Drawing.Point(4, 27);
            this.labelFiltru1.Name = "labelFiltru1";
            this.labelFiltru1.Size = new System.Drawing.Size(90, 16);
            this.labelFiltru1.TabIndex = 7;
            this.labelFiltru1.Text = "Descriere : ";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(553, 27);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(52, 16);
            this.labelData.TabIndex = 6;
            this.labelData.Text = "Data :";
            // 
            // filtruData
            // 
            this.filtruData.CustomFormat = "";
            this.filtruData.Location = new System.Drawing.Point(623, 27);
            this.filtruData.Name = "filtruData";
            this.filtruData.Size = new System.Drawing.Size(200, 20);
            this.filtruData.TabIndex = 5;
            this.filtruData.ValueChanged += new System.EventHandler(this.filtruData_ValueChanged);
            // 
            // sortLabel
            // 
            this.sortLabel.AutoSize = true;
            this.sortLabel.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortLabel.Location = new System.Drawing.Point(478, 10);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(52, 18);
            this.sortLabel.TabIndex = 0;
            this.sortLabel.Text = "Filtre";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(8, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1058, 3);
            this.panel2.TabIndex = 13;
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.YellowGreen;
            this.titlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Controls.Add(this.pictureBox1);
            this.titlePanel.Controls.Add(this.findPicture2);
            this.titlePanel.Location = new System.Drawing.Point(8, 3);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1058, 54);
            this.titlePanel.TabIndex = 12;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.BackColor = System.Drawing.Color.YellowGreen;
            this.titleLabel.Font = new System.Drawing.Font("Verdana", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(70, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(918, 52);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Money Tracker";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.YellowGreen;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(994, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // findPicture2
            // 
            this.findPicture2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.findPicture2.BackColor = System.Drawing.Color.YellowGreen;
            this.findPicture2.Image = ((System.Drawing.Image)(resources.GetObject("findPicture2.Image")));
            this.findPicture2.Location = new System.Drawing.Point(0, 0);
            this.findPicture2.Name = "findPicture2";
            this.findPicture2.Size = new System.Drawing.Size(64, 56);
            this.findPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.findPicture2.TabIndex = 4;
            this.findPicture2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(8, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 5);
            this.panel1.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.btnEconomii);
            this.panel6.Controls.Add(this.btnVenituri);
            this.panel6.Controls.Add(this.btnCheltuieli);
            this.panel6.Controls.Add(this.btnStatisctica);
            this.panel6.Location = new System.Drawing.Point(8, 58);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1058, 63);
            this.panel6.TabIndex = 10;
            // 
            // btnEconomii
            // 
            this.btnEconomii.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEconomii.BackColor = System.Drawing.Color.White;
            this.btnEconomii.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEconomii.Image = ((System.Drawing.Image)(resources.GetObject("btnEconomii.Image")));
            this.btnEconomii.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEconomii.Location = new System.Drawing.Point(879, 9);
            this.btnEconomii.Name = "btnEconomii";
            this.btnEconomii.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEconomii.Size = new System.Drawing.Size(165, 43);
            this.btnEconomii.TabIndex = 4;
            this.btnEconomii.Text = "Economii";
            this.btnEconomii.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEconomii.UseVisualStyleBackColor = false;
            this.btnEconomii.Click += new System.EventHandler(this.btnEconomii_Click);
            // 
            // btnVenituri
            // 
            this.btnVenituri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVenituri.BackColor = System.Drawing.Color.White;
            this.btnVenituri.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenituri.Image = ((System.Drawing.Image)(resources.GetObject("btnVenituri.Image")));
            this.btnVenituri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenituri.Location = new System.Drawing.Point(296, 9);
            this.btnVenituri.Name = "btnVenituri";
            this.btnVenituri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVenituri.Size = new System.Drawing.Size(165, 43);
            this.btnVenituri.TabIndex = 2;
            this.btnVenituri.Text = "Venituri";
            this.btnVenituri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVenituri.UseVisualStyleBackColor = false;
            this.btnVenituri.Click += new System.EventHandler(this.btnVenituri_Click);
            // 
            // btnCheltuieli
            // 
            this.btnCheltuieli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheltuieli.BackColor = System.Drawing.Color.White;
            this.btnCheltuieli.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheltuieli.Image = ((System.Drawing.Image)(resources.GetObject("btnCheltuieli.Image")));
            this.btnCheltuieli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheltuieli.Location = new System.Drawing.Point(606, 9);
            this.btnCheltuieli.Name = "btnCheltuieli";
            this.btnCheltuieli.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCheltuieli.Size = new System.Drawing.Size(165, 43);
            this.btnCheltuieli.TabIndex = 3;
            this.btnCheltuieli.Text = "Cheltuieli";
            this.btnCheltuieli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheltuieli.UseVisualStyleBackColor = false;
            this.btnCheltuieli.Click += new System.EventHandler(this.btnCheltuieli_Click);
            // 
            // btnStatisctica
            // 
            this.btnStatisctica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatisctica.BackColor = System.Drawing.Color.White;
            this.btnStatisctica.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatisctica.Image = ((System.Drawing.Image)(resources.GetObject("btnStatisctica.Image")));
            this.btnStatisctica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatisctica.Location = new System.Drawing.Point(7, 9);
            this.btnStatisctica.Name = "btnStatisctica";
            this.btnStatisctica.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStatisctica.Size = new System.Drawing.Size(183, 43);
            this.btnStatisctica.TabIndex = 1;
            this.btnStatisctica.Text = "Statisctica";
            this.btnStatisctica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStatisctica.UseVisualStyleBackColor = false;
            this.btnStatisctica.Click += new System.EventHandler(this.btnStatisctica_Click);
            // 
            // DataView
            // 
            this.DataView.AllowUserToAddRows = false;
            this.DataView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataView.BackgroundColor = System.Drawing.Color.White;
            this.DataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.GridColor = System.Drawing.Color.Black;
            this.DataView.Location = new System.Drawing.Point(8, 231);
            this.DataView.MultiSelect = false;
            this.DataView.Name = "DataView";
            this.DataView.ReadOnly = true;
            this.DataView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataView.Size = new System.Drawing.Size(1058, 330);
            this.DataView.StandardTab = true;
            this.DataView.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.updateBtn);
            this.panel3.Controls.Add(this.deleteRecord);
            this.panel3.Controls.Add(this.addEconomii);
            this.panel3.Controls.Add(this.addVenituri);
            this.panel3.Controls.Add(this.addCheltuieli);
            this.panel3.Location = new System.Drawing.Point(8, 567);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1058, 54);
            this.panel3.TabIndex = 11;
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.updateBtn.BackColor = System.Drawing.Color.White;
            this.updateBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Image = ((System.Drawing.Image)(resources.GetObject("updateBtn.Image")));
            this.updateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBtn.Location = new System.Drawing.Point(708, 8);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.updateBtn.Size = new System.Drawing.Size(165, 43);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Modifica";
            this.updateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteRecord
            // 
            this.deleteRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteRecord.BackColor = System.Drawing.Color.White;
            this.deleteRecord.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRecord.Image = ((System.Drawing.Image)(resources.GetObject("deleteRecord.Image")));
            this.deleteRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteRecord.Location = new System.Drawing.Point(879, 8);
            this.deleteRecord.Name = "deleteRecord";
            this.deleteRecord.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deleteRecord.Size = new System.Drawing.Size(165, 43);
            this.deleteRecord.TabIndex = 6;
            this.deleteRecord.Text = "Sterge";
            this.deleteRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteRecord.UseVisualStyleBackColor = false;
            this.deleteRecord.Click += new System.EventHandler(this.deleteRecord_Click);
            // 
            // addEconomii
            // 
            this.addEconomii.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addEconomii.BackColor = System.Drawing.Color.White;
            this.addEconomii.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEconomii.Image = ((System.Drawing.Image)(resources.GetObject("addEconomii.Image")));
            this.addEconomii.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEconomii.Location = new System.Drawing.Point(425, 8);
            this.addEconomii.Name = "addEconomii";
            this.addEconomii.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addEconomii.Size = new System.Drawing.Size(203, 43);
            this.addEconomii.TabIndex = 4;
            this.addEconomii.Text = "Adauga Economii";
            this.addEconomii.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addEconomii.UseVisualStyleBackColor = false;
            this.addEconomii.Click += new System.EventHandler(this.addEconomii_Click);
            // 
            // addVenituri
            // 
            this.addVenituri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addVenituri.BackColor = System.Drawing.Color.White;
            this.addVenituri.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVenituri.Image = ((System.Drawing.Image)(resources.GetObject("addVenituri.Image")));
            this.addVenituri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addVenituri.Location = new System.Drawing.Point(7, 8);
            this.addVenituri.Name = "addVenituri";
            this.addVenituri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addVenituri.Size = new System.Drawing.Size(203, 43);
            this.addVenituri.TabIndex = 2;
            this.addVenituri.Text = "Adauga Venituri";
            this.addVenituri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addVenituri.UseVisualStyleBackColor = false;
            this.addVenituri.Click += new System.EventHandler(this.addVenituri_Click);
            // 
            // addCheltuieli
            // 
            this.addCheltuieli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addCheltuieli.BackColor = System.Drawing.Color.White;
            this.addCheltuieli.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCheltuieli.Image = ((System.Drawing.Image)(resources.GetObject("addCheltuieli.Image")));
            this.addCheltuieli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCheltuieli.Location = new System.Drawing.Point(216, 8);
            this.addCheltuieli.Name = "addCheltuieli";
            this.addCheltuieli.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addCheltuieli.Size = new System.Drawing.Size(203, 43);
            this.addCheltuieli.TabIndex = 3;
            this.addCheltuieli.Text = "Adauga Cheltuieli";
            this.addCheltuieli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addCheltuieli.UseVisualStyleBackColor = false;
            this.addCheltuieli.Click += new System.EventHandler(this.addCheltuieli_Click);
            // 
            // filtruSuma
            // 
            this.filtruSuma.Location = new System.Drawing.Point(100, 58);
            this.filtruSuma.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.filtruSuma.Name = "filtruSuma";
            this.filtruSuma.Size = new System.Drawing.Size(120, 20);
            this.filtruSuma.TabIndex = 10;
            // 
            // labelVenit
            // 
            this.labelVenit.AutoSize = true;
            this.labelVenit.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVenit.Location = new System.Drawing.Point(553, 58);
            this.labelVenit.Name = "labelVenit";
            this.labelVenit.Size = new System.Drawing.Size(38, 16);
            this.labelVenit.TabIndex = 11;
            this.labelVenit.Text = "Tip :";
            // 
            // filtruTip
            // 
            this.filtruTip.FormattingEnabled = true;
            this.filtruTip.Items.AddRange(new object[] {
            "Card",
            "Cash"});
            this.filtruTip.Location = new System.Drawing.Point(623, 54);
            this.filtruTip.Name = "filtruTip";
            this.filtruTip.Size = new System.Drawing.Size(200, 21);
            this.filtruTip.TabIndex = 12;
            // 
            // setFilter
            // 
            this.setFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.setFilter.BackColor = System.Drawing.Color.White;
            this.setFilter.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setFilter.Image = ((System.Drawing.Image)(resources.GetObject("setFilter.Image")));
            this.setFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setFilter.Location = new System.Drawing.Point(879, 4);
            this.setFilter.Name = "setFilter";
            this.setFilter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.setFilter.Size = new System.Drawing.Size(165, 45);
            this.setFilter.TabIndex = 13;
            this.setFilter.Text = "Filtreaza";
            this.setFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.setFilter.UseVisualStyleBackColor = false;
            this.setFilter.Click += new System.EventHandler(this.setFilter_Click);
            // 
            // resetFiltre
            // 
            this.resetFiltre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.resetFiltre.BackColor = System.Drawing.Color.White;
            this.resetFiltre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetFiltre.Image = ((System.Drawing.Image)(resources.GetObject("resetFiltre.Image")));
            this.resetFiltre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resetFiltre.Location = new System.Drawing.Point(879, 55);
            this.resetFiltre.Name = "resetFiltre";
            this.resetFiltre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resetFiltre.Size = new System.Drawing.Size(165, 41);
            this.resetFiltre.TabIndex = 14;
            this.resetFiltre.Text = "Reseteaza";
            this.resetFiltre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resetFiltre.UseVisualStyleBackColor = false;
            this.resetFiltre.Click += new System.EventHandler(this.resetFiltre_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 625);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.headerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1094, 664);
            this.MinimumSize = new System.Drawing.Size(1094, 664);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money Tracker";
            this.headerPanel.ResumeLayout(false);
            this.optionPanel.ResumeLayout(false);
            this.optionPanel.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findPicture2)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filtruSuma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button btnStatisctica;
        private System.Windows.Forms.Button btnCheltuieli;
        private System.Windows.Forms.Button btnVenituri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnEconomii;
        private System.Windows.Forms.PictureBox findPicture2;
        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel optionPanel;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.DateTimePicker filtruData;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button deleteRecord;
        private System.Windows.Forms.Button addEconomii;
        private System.Windows.Forms.Button addVenituri;
        private System.Windows.Forms.Button addCheltuieli;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label labelSuma;
        private System.Windows.Forms.TextBox filtruDescriere;
        private System.Windows.Forms.Label labelFiltru1;
        private System.Windows.Forms.NumericUpDown filtruSuma;
        private System.Windows.Forms.Label labelVenit;
        private System.Windows.Forms.ComboBox filtruTip;
        private System.Windows.Forms.Button setFilter;
        private System.Windows.Forms.Button resetFiltre;
    }
}

