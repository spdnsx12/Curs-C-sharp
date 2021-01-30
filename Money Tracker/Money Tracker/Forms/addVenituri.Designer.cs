namespace Money_Tracker
{
    partial class addVenituri
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
        public void InitializeComponent()
        {
            this.descLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.warningLabel = new System.Windows.Forms.Label();
            this.labelTitlu = new System.Windows.Forms.Label();
            this.confirmAdd = new System.Windows.Forms.Button();
            this.sumaVenit = new System.Windows.Forms.NumericUpDown();
            this.labelData = new System.Windows.Forms.Label();
            this.listaPlata = new System.Windows.Forms.ComboBox();
            this.labelTipVenit = new System.Windows.Forms.Label();
            this.textDescriere = new System.Windows.Forms.TextBox();
            this.labelSuma = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumaVenit)).BeginInit();
            this.SuspendLayout();
            // 
            // descLabel
            // 
            this.descLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(72, 103);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(55, 13);
            this.descLabel.TabIndex = 0;
            this.descLabel.Text = "Descriere:";
            this.descLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.warningLabel);
            this.panel1.Controls.Add(this.labelTitlu);
            this.panel1.Controls.Add(this.confirmAdd);
            this.panel1.Controls.Add(this.sumaVenit);
            this.panel1.Controls.Add(this.labelData);
            this.panel1.Controls.Add(this.listaPlata);
            this.panel1.Controls.Add(this.labelTipVenit);
            this.panel1.Controls.Add(this.textDescriere);
            this.panel1.Controls.Add(this.descLabel);
            this.panel1.Controls.Add(this.labelSuma);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 426);
            this.panel1.TabIndex = 1;
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.warningLabel.Location = new System.Drawing.Point(178, 315);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 31);
            this.warningLabel.TabIndex = 11;
            // 
            // labelTitlu
            // 
            this.labelTitlu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlu.Location = new System.Drawing.Point(290, 32);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(153, 25);
            this.labelTitlu.TabIndex = 10;
            this.labelTitlu.Text = "Adauga Venit";
            this.labelTitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmAdd
            // 
            this.confirmAdd.Location = new System.Drawing.Point(295, 374);
            this.confirmAdd.Name = "confirmAdd";
            this.confirmAdd.Size = new System.Drawing.Size(143, 23);
            this.confirmAdd.TabIndex = 9;
            this.confirmAdd.Text = "Confirm";
            this.confirmAdd.UseVisualStyleBackColor = true;
            this.confirmAdd.Click += new System.EventHandler(this.confirmAdd_Click);
            // 
            // sumaVenit
            // 
            this.sumaVenit.Location = new System.Drawing.Point(184, 151);
            this.sumaVenit.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.sumaVenit.Name = "sumaVenit";
            this.sumaVenit.Size = new System.Drawing.Size(199, 20);
            this.sumaVenit.TabIndex = 8;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(72, 245);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(33, 13);
            this.labelData.TabIndex = 6;
            this.labelData.Text = "Data:";
            // 
            // listaPlata
            // 
            this.listaPlata.FormattingEnabled = true;
            this.listaPlata.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.listaPlata.Location = new System.Drawing.Point(183, 200);
            this.listaPlata.Name = "listaPlata";
            this.listaPlata.Size = new System.Drawing.Size(200, 21);
            this.listaPlata.TabIndex = 0;
            // 
            // labelTipVenit
            // 
            this.labelTipVenit.AutoSize = true;
            this.labelTipVenit.Location = new System.Drawing.Point(72, 203);
            this.labelTipVenit.Name = "labelTipVenit";
            this.labelTipVenit.Size = new System.Drawing.Size(52, 13);
            this.labelTipVenit.TabIndex = 5;
            this.labelTipVenit.Text = "Tip Venit:";
            // 
            // textDescriere
            // 
            this.textDescriere.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDescriere.Location = new System.Drawing.Point(183, 100);
            this.textDescriere.Name = "textDescriere";
            this.textDescriere.Size = new System.Drawing.Size(519, 20);
            this.textDescriere.TabIndex = 1;
            // 
            // labelSuma
            // 
            this.labelSuma.AutoSize = true;
            this.labelSuma.Location = new System.Drawing.Point(72, 158);
            this.labelSuma.Name = "labelSuma";
            this.labelSuma.Size = new System.Drawing.Size(37, 13);
            this.labelSuma.TabIndex = 2;
            this.labelSuma.Text = "Suma:";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(183, 245);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 12;
            // 
            // addVenituri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "addVenituri";
            this.Text = "Add";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumaVenit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSuma;
        private System.Windows.Forms.TextBox textDescriere;
        private System.Windows.Forms.ComboBox listaPlata;
        private System.Windows.Forms.Label labelTipVenit;
        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.Button confirmAdd;
        private System.Windows.Forms.NumericUpDown sumaVenit;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.DateTimePicker date;
    }
}