namespace GuessTheNumber
{
    partial class GuessTheNumber
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
            this.infoMsg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonDa = new System.Windows.Forms.RadioButton();
            this.radioButtonNu = new System.Windows.Forms.RadioButton();
            this.gameInfo = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // infoMsg
            // 
            this.infoMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoMsg.ForeColor = System.Drawing.SystemColors.Highlight;
            this.infoMsg.Location = new System.Drawing.Point(27, 206);
            this.infoMsg.Name = "infoMsg";
            this.infoMsg.Size = new System.Drawing.Size(479, 36);
            this.infoMsg.TabIndex = 0;
            this.infoMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PeachPuff;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(27, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numar:";
            // 
            // numberBox
            // 
            this.numberBox.AcceptsReturn = true;
            this.numberBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBox.Location = new System.Drawing.Point(130, 154);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(56, 35);
            this.numberBox.TabIndex = 2;
            // 
            // guessButton
            // 
            this.guessButton.BackColor = System.Drawing.Color.Navy;
            this.guessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.guessButton.Location = new System.Drawing.Point(162, 301);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(210, 36);
            this.guessButton.TabIndex = 3;
            this.guessButton.Text = "Ghiceste";
            this.guessButton.UseVisualStyleBackColor = false;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(70, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 55);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ghiceste numarul";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonDa
            // 
            this.radioButtonDa.AutoSize = true;
            this.radioButtonDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDa.Location = new System.Drawing.Point(162, 255);
            this.radioButtonDa.Name = "radioButtonDa";
            this.radioButtonDa.Size = new System.Drawing.Size(58, 30);
            this.radioButtonDa.TabIndex = 5;
            this.radioButtonDa.TabStop = true;
            this.radioButtonDa.Text = "Da";
            this.radioButtonDa.UseVisualStyleBackColor = true;
            this.radioButtonDa.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButtonNu
            // 
            this.radioButtonNu.AutoSize = true;
            this.radioButtonNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNu.Location = new System.Drawing.Point(314, 255);
            this.radioButtonNu.Name = "radioButtonNu";
            this.radioButtonNu.Size = new System.Drawing.Size(58, 30);
            this.radioButtonNu.TabIndex = 6;
            this.radioButtonNu.TabStop = true;
            this.radioButtonNu.Text = "Nu";
            this.radioButtonNu.UseVisualStyleBackColor = true;
            this.radioButtonNu.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // gameInfo
            // 
            this.gameInfo.AutoSize = true;
            this.gameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameInfo.ForeColor = System.Drawing.Color.Red;
            this.gameInfo.Location = new System.Drawing.Point(202, 161);
            this.gameInfo.Name = "gameInfo";
            this.gameInfo.Size = new System.Drawing.Size(214, 20);
            this.gameInfo.TabIndex = 7;
            this.gameInfo.Text = "Numarul este intre 0 si 10";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(91, 206);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // GuessTheNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(542, 349);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.gameInfo);
            this.Controls.Add(this.radioButtonNu);
            this.Controls.Add(this.radioButtonDa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.infoMsg);
            this.Name = "GuessTheNumber";
            this.Text = "GuessTheNumber";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonDa;
        private System.Windows.Forms.RadioButton radioButtonNu;
        private System.Windows.Forms.Label gameInfo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

