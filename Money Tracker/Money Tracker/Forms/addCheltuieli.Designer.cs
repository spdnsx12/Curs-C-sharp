﻿namespace Money_Tracker.Forms
{
    partial class addCheltuieli
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
            this.dataTranzactie = new System.Windows.Forms.DateTimePicker();
            this.sumaPlata = new System.Windows.Forms.NumericUpDown();
            this.labelData = new System.Windows.Forms.Label();
            this.tipPlata = new System.Windows.Forms.ComboBox();
            this.labelTipPlata = new System.Windows.Forms.Label();
            this.textDescriere = new System.Windows.Forms.TextBox();
            this.descLabel = new System.Windows.Forms.Label();
            this.labelSuma = new System.Windows.Forms.Label();
            this.labelTitlu = new System.Windows.Forms.Label();
            this.confirmAdd = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sumaPlata)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTranzactie
            // 
            this.dataTranzactie.Location = new System.Drawing.Point(204, 260);
            this.dataTranzactie.Name = "dataTranzactie";
            this.dataTranzactie.Size = new System.Drawing.Size(200, 20);
            this.dataTranzactie.TabIndex = 20;
            // 
            // sumaPlata
            // 
            this.sumaPlata.Location = new System.Drawing.Point(205, 166);
            this.sumaPlata.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.sumaPlata.Name = "sumaPlata";
            this.sumaPlata.Size = new System.Drawing.Size(199, 20);
            this.sumaPlata.TabIndex = 19;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(93, 260);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(33, 13);
            this.labelData.TabIndex = 18;
            this.labelData.Text = "Data:";
            // 
            // tipPlata
            // 
            this.tipPlata.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.tipPlata.Location = new System.Drawing.Point(204, 215);
            this.tipPlata.Name = "tipPlata";
            this.tipPlata.Size = new System.Drawing.Size(200, 21);
            this.tipPlata.TabIndex = 13;
            // 
            // labelTipPlata
            // 
            this.labelTipPlata.AutoSize = true;
            this.labelTipPlata.Location = new System.Drawing.Point(93, 218);
            this.labelTipPlata.Name = "labelTipPlata";
            this.labelTipPlata.Size = new System.Drawing.Size(52, 13);
            this.labelTipPlata.TabIndex = 17;
            this.labelTipPlata.Text = "Tip Plata:";
            this.labelTipPlata.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textDescriere
            // 
            this.textDescriere.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDescriere.Location = new System.Drawing.Point(204, 115);
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
            this.descLabel.Location = new System.Drawing.Point(93, 118);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(55, 13);
            this.descLabel.TabIndex = 14;
            this.descLabel.Text = "Descriere:";
            this.descLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSuma
            // 
            this.labelSuma.AutoSize = true;
            this.labelSuma.Location = new System.Drawing.Point(93, 173);
            this.labelSuma.Name = "labelSuma";
            this.labelSuma.Size = new System.Drawing.Size(37, 13);
            this.labelSuma.TabIndex = 16;
            this.labelSuma.Text = "Suma:";
            // 
            // labelTitlu
            // 
            this.labelTitlu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlu.Location = new System.Drawing.Point(302, 25);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(205, 25);
            this.labelTitlu.TabIndex = 21;
            this.labelTitlu.Text = "Adauga Cheltuiala";
            this.labelTitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmAdd
            // 
            this.confirmAdd.Location = new System.Drawing.Point(307, 398);
            this.confirmAdd.Name = "confirmAdd";
            this.confirmAdd.Size = new System.Drawing.Size(143, 23);
            this.confirmAdd.TabIndex = 22;
            this.confirmAdd.Text = "Confirm";
            this.confirmAdd.UseVisualStyleBackColor = true;
            this.confirmAdd.Click += new System.EventHandler(this.confirmAdd_Click_1);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.warningLabel.Location = new System.Drawing.Point(199, 323);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 31);
            this.warningLabel.TabIndex = 23;
            // 
            // addCheltuieli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.confirmAdd);
            this.Controls.Add(this.labelTitlu);
            this.Controls.Add(this.dataTranzactie);
            this.Controls.Add(this.sumaPlata);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.tipPlata);
            this.Controls.Add(this.labelTipPlata);
            this.Controls.Add(this.textDescriere);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.labelSuma);
            this.Name = "addCheltuieli";
            this.Text = "addCheltuieli";
            ((System.ComponentModel.ISupportInitialize)(this.sumaPlata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dataTranzactie;
        private System.Windows.Forms.NumericUpDown sumaPlata;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.ComboBox tipPlata;
        private System.Windows.Forms.Label labelTipPlata;
        private System.Windows.Forms.TextBox textDescriere;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label labelSuma;
        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.Button confirmAdd;
        private System.Windows.Forms.Label warningLabel;
    }
}