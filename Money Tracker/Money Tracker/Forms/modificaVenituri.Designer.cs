namespace Money_Tracker.Forms
{
    partial class modificaVenituri
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
            this.date = new System.Windows.Forms.DateTimePicker();
            this.warningLabel = new System.Windows.Forms.Label();
            this.labelTitlu = new System.Windows.Forms.Label();
            this.confirmAdd = new System.Windows.Forms.Button();
            this.sumaVenit = new System.Windows.Forms.NumericUpDown();
            this.labelData = new System.Windows.Forms.Label();
            this.listaPlata = new System.Windows.Forms.ComboBox();
            this.labelTipVenit = new System.Windows.Forms.Label();
            this.textDescriere = new System.Windows.Forms.TextBox();
            this.descLabel = new System.Windows.Forms.Label();
            this.labelSuma = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.idValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.sumaVenit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idValue)).BeginInit();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(197, 278);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 23;
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.warningLabel.Location = new System.Drawing.Point(191, 319);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 31);
            this.warningLabel.TabIndex = 22;
            // 
            // labelTitlu
            // 
            this.labelTitlu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlu.Location = new System.Drawing.Point(303, 43);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(162, 25);
            this.labelTitlu.TabIndex = 21;
            this.labelTitlu.Text = "Modifica Venit";
            this.labelTitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmAdd
            // 
            this.confirmAdd.Location = new System.Drawing.Point(308, 385);
            this.confirmAdd.Name = "confirmAdd";
            this.confirmAdd.Size = new System.Drawing.Size(143, 23);
            this.confirmAdd.TabIndex = 20;
            this.confirmAdd.Text = "Confirm";
            this.confirmAdd.UseVisualStyleBackColor = true;
            this.confirmAdd.Click += new System.EventHandler(this.confirmAdd_Click);
            // 
            // sumaVenit
            // 
            this.sumaVenit.Location = new System.Drawing.Point(198, 184);
            this.sumaVenit.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.sumaVenit.Name = "sumaVenit";
            this.sumaVenit.Size = new System.Drawing.Size(199, 20);
            this.sumaVenit.TabIndex = 19;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(86, 278);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(33, 13);
            this.labelData.TabIndex = 18;
            this.labelData.Text = "Data:";
            // 
            // listaPlata
            // 
            this.listaPlata.FormattingEnabled = true;
            this.listaPlata.Items.AddRange(new object[] {
            "Card",
            "Cash"});
            this.listaPlata.Location = new System.Drawing.Point(197, 233);
            this.listaPlata.Name = "listaPlata";
            this.listaPlata.Size = new System.Drawing.Size(200, 21);
            this.listaPlata.Sorted = true;
            this.listaPlata.TabIndex = 13;
            // 
            // labelTipVenit
            // 
            this.labelTipVenit.AutoSize = true;
            this.labelTipVenit.Location = new System.Drawing.Point(86, 236);
            this.labelTipVenit.Name = "labelTipVenit";
            this.labelTipVenit.Size = new System.Drawing.Size(52, 13);
            this.labelTipVenit.TabIndex = 17;
            this.labelTipVenit.Text = "Tip Venit:";
            // 
            // textDescriere
            // 
            this.textDescriere.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDescriere.Location = new System.Drawing.Point(197, 144);
            this.textDescriere.Name = "textDescriere";
            this.textDescriere.Size = new System.Drawing.Size(519, 20);
            this.textDescriere.TabIndex = 15;
            // 
            // descLabel
            // 
            this.descLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(86, 147);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(55, 13);
            this.descLabel.TabIndex = 14;
            this.descLabel.Text = "Descriere:";
            this.descLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSuma
            // 
            this.labelSuma.AutoSize = true;
            this.labelSuma.Location = new System.Drawing.Point(86, 191);
            this.labelSuma.Name = "labelSuma";
            this.labelSuma.Size = new System.Drawing.Size(37, 13);
            this.labelSuma.TabIndex = 16;
            this.labelSuma.Text = "Suma:";
            // 
            // labelId
            // 
            this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(86, 105);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 13);
            this.labelId.TabIndex = 24;
            this.labelId.Text = "ID:";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idValue
            // 
            this.idValue.Location = new System.Drawing.Point(197, 105);
            this.idValue.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.idValue.Name = "idValue";
            this.idValue.ReadOnly = true;
            this.idValue.Size = new System.Drawing.Size(199, 20);
            this.idValue.TabIndex = 25;
            // 
            // modificaVenituri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.idValue);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.date);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.labelTitlu);
            this.Controls.Add(this.confirmAdd);
            this.Controls.Add(this.sumaVenit);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.listaPlata);
            this.Controls.Add(this.labelTipVenit);
            this.Controls.Add(this.textDescriere);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.labelSuma);
            this.Name = "modificaVenituri";
            this.Text = "modificaVenituri";
            ((System.ComponentModel.ISupportInitialize)(this.sumaVenit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.Button confirmAdd;
        private System.Windows.Forms.NumericUpDown sumaVenit;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.ComboBox listaPlata;
        private System.Windows.Forms.Label labelTipVenit;
        private System.Windows.Forms.TextBox textDescriere;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label labelSuma;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.NumericUpDown idValue;
    }
}