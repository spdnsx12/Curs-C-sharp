﻿namespace Money_Tracker.Forms
{
    partial class modificaEconomie
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
            this.warningLabel = new System.Windows.Forms.Label();
            this.confirmUpdate = new System.Windows.Forms.Button();
            this.labelTitlu = new System.Windows.Forms.Label();
            this.dataAdaugare = new System.Windows.Forms.DateTimePicker();
            this.suma = new System.Windows.Forms.NumericUpDown();
            this.labelData = new System.Windows.Forms.Label();
            this.textDescriere = new System.Windows.Forms.TextBox();
            this.descLabel = new System.Windows.Forms.Label();
            this.labelSuma = new System.Windows.Forms.Label();
            this.idValue = new System.Windows.Forms.NumericUpDown();
            this.labelId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.suma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idValue)).BeginInit();
            this.SuspendLayout();
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.warningLabel.Location = new System.Drawing.Point(191, 325);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 31);
            this.warningLabel.TabIndex = 43;
            // 
            // confirmUpdate
            // 
            this.confirmUpdate.Location = new System.Drawing.Point(299, 400);
            this.confirmUpdate.Name = "confirmUpdate";
            this.confirmUpdate.Size = new System.Drawing.Size(143, 23);
            this.confirmUpdate.TabIndex = 42;
            this.confirmUpdate.Text = "Confirm";
            this.confirmUpdate.UseVisualStyleBackColor = true;
            this.confirmUpdate.Click += new System.EventHandler(this.confirmUpdate_Click);
            // 
            // labelTitlu
            // 
            this.labelTitlu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlu.Location = new System.Drawing.Point(294, 27);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(198, 25);
            this.labelTitlu.TabIndex = 41;
            this.labelTitlu.Text = "Modica Economie";
            this.labelTitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataAdaugare
            // 
            this.dataAdaugare.Location = new System.Drawing.Point(196, 190);
            this.dataAdaugare.Name = "dataAdaugare";
            this.dataAdaugare.Size = new System.Drawing.Size(200, 20);
            this.dataAdaugare.TabIndex = 40;
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(196, 151);
            this.suma.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(199, 20);
            this.suma.TabIndex = 39;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(85, 196);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(33, 13);
            this.labelData.TabIndex = 38;
            this.labelData.Text = "Data:";
            // 
            // textDescriere
            // 
            this.textDescriere.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDescriere.Location = new System.Drawing.Point(196, 117);
            this.textDescriere.Name = "textDescriere";
            this.textDescriere.Size = new System.Drawing.Size(519, 20);
            this.textDescriere.TabIndex = 36;
            // 
            // descLabel
            // 
            this.descLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(85, 120);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(55, 13);
            this.descLabel.TabIndex = 35;
            this.descLabel.Text = "Descriere:";
            this.descLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSuma
            // 
            this.labelSuma.AutoSize = true;
            this.labelSuma.Location = new System.Drawing.Point(85, 153);
            this.labelSuma.Name = "labelSuma";
            this.labelSuma.Size = new System.Drawing.Size(37, 13);
            this.labelSuma.TabIndex = 37;
            this.labelSuma.Text = "Suma:";
            // 
            // idValue
            // 
            this.idValue.Location = new System.Drawing.Point(196, 80);
            this.idValue.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.idValue.Name = "idValue";
            this.idValue.ReadOnly = true;
            this.idValue.Size = new System.Drawing.Size(199, 20);
            this.idValue.TabIndex = 45;
            // 
            // labelId
            // 
            this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(85, 80);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 13);
            this.labelId.TabIndex = 44;
            this.labelId.Text = "ID:";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modificaEconomie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.idValue);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.confirmUpdate);
            this.Controls.Add(this.labelTitlu);
            this.Controls.Add(this.dataAdaugare);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.textDescriere);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.labelSuma);
            this.Name = "modificaEconomie";
            this.Text = "modificaEconomie";
            ((System.ComponentModel.ISupportInitialize)(this.suma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Button confirmUpdate;
        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.DateTimePicker dataAdaugare;
        private System.Windows.Forms.NumericUpDown suma;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textDescriere;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label labelSuma;
        private System.Windows.Forms.NumericUpDown idValue;
        private System.Windows.Forms.Label labelId;
    }
}