namespace SalvareDateLocal
{
    partial class Form1
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
            this.btnRead = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pickBtn = new System.Windows.Forms.Button();
            this.writeBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.writeInFile = new System.Windows.Forms.Button();
            this.copyBtn = new System.Windows.Forms.Button();
            this.moveBtn = new System.Windows.Forms.Button();
            this.dltBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(529, 78);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Citeste Text";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(458, 223);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(43, 296);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(294, 117);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "\"fisiere txt | *.txt |iso files|*.iso|toate|*.*";
            // 
            // pickBtn
            // 
            this.pickBtn.Location = new System.Drawing.Point(529, 40);
            this.pickBtn.Name = "pickBtn";
            this.pickBtn.Size = new System.Drawing.Size(75, 23);
            this.pickBtn.TabIndex = 3;
            this.pickBtn.Text = "Pick File";
            this.pickBtn.UseVisualStyleBackColor = true;
            this.pickBtn.Click += new System.EventHandler(this.pickBtn_Click);
            // 
            // writeBtn
            // 
            this.writeBtn.Location = new System.Drawing.Point(529, 120);
            this.writeBtn.Name = "writeBtn";
            this.writeBtn.Size = new System.Drawing.Size(75, 23);
            this.writeBtn.TabIndex = 4;
            this.writeBtn.Text = "Scrie";
            this.writeBtn.UseVisualStyleBackColor = true;
            this.writeBtn.Click += new System.EventHandler(this.writeBtn_Click);
            // 
            // writeInFile
            // 
            this.writeInFile.Location = new System.Drawing.Point(529, 168);
            this.writeInFile.Name = "writeInFile";
            this.writeInFile.Size = new System.Drawing.Size(75, 23);
            this.writeInFile.TabIndex = 5;
            this.writeInFile.Text = "Scrie in fisier";
            this.writeInFile.UseVisualStyleBackColor = true;
            this.writeInFile.Click += new System.EventHandler(this.writeInFile_Click);
            // 
            // copyBtn
            // 
            this.copyBtn.Location = new System.Drawing.Point(529, 223);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(75, 23);
            this.copyBtn.TabIndex = 6;
            this.copyBtn.Text = "Copiaza Fisier";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // moveBtn
            // 
            this.moveBtn.Location = new System.Drawing.Point(529, 268);
            this.moveBtn.Name = "moveBtn";
            this.moveBtn.Size = new System.Drawing.Size(75, 23);
            this.moveBtn.TabIndex = 7;
            this.moveBtn.Text = "Muta";
            this.moveBtn.UseVisualStyleBackColor = true;
            this.moveBtn.Click += new System.EventHandler(this.moveBtn_Click);
            // 
            // dltBtn
            // 
            this.dltBtn.Location = new System.Drawing.Point(529, 318);
            this.dltBtn.Name = "dltBtn";
            this.dltBtn.Size = new System.Drawing.Size(75, 23);
            this.dltBtn.TabIndex = 8;
            this.dltBtn.Text = "Delete file";
            this.dltBtn.UseVisualStyleBackColor = true;
            this.dltBtn.Click += new System.EventHandler(this.dltBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dltBtn);
            this.Controls.Add(this.moveBtn);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.writeInFile);
            this.Controls.Add(this.writeBtn);
            this.Controls.Add(this.pickBtn);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button pickBtn;
        private System.Windows.Forms.Button writeBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button writeInFile;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Button moveBtn;
        private System.Windows.Forms.Button dltBtn;
    }
}

