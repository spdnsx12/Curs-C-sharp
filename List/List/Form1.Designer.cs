

using System.Drawing;
using System.Windows.Forms;

namespace List
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
        public void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Admin", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Standard", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Sorin",
            "Iulian"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Iulian",
            "Sorin"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Data Nasterii");
            this.addBtn = new System.Windows.Forms.Button();
            this.rmvBtn = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrenume = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.textPrenume = new System.Windows.Forms.TextBox();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.infoLabel = new System.Windows.Forms.Label();
            this.nameWarning = new System.Windows.Forms.Label();
            this.warrningPrenume = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.c1Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c1Prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c1Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(449, 35);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add User";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // rmvBtn
            // 
            this.rmvBtn.Location = new System.Drawing.Point(153, 403);
            this.rmvBtn.Name = "rmvBtn";
            this.rmvBtn.Size = new System.Drawing.Size(111, 23);
            this.rmvBtn.TabIndex = 2;
            this.rmvBtn.Text = "Remove User";
            this.rmvBtn.UseVisualStyleBackColor = true;
            this.rmvBtn.Click += new System.EventHandler(this.rmvBtn_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(560, 100);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(200, 21);
            this.textName.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(427, 100);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Nume:";
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Location = new System.Drawing.Point(427, 154);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(53, 13);
            this.labelPrenume.TabIndex = 5;
            this.labelPrenume.Text = "Prenume:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(427, 208);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(73, 13);
            this.labelData.TabIndex = 6;
            this.labelData.Text = "Data Nasterii:";
            // 
            // textPrenume
            // 
            this.textPrenume.Location = new System.Drawing.Point(560, 147);
            this.textPrenume.Name = "textPrenume";
            this.textPrenume.Size = new System.Drawing.Size(200, 21);
            this.textPrenume.TabIndex = 7;
            // 
            // datePick
            // 
            this.datePick.Location = new System.Drawing.Point(560, 208);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(200, 21);
            this.datePick.TabIndex = 8;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(430, 319);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 13);
            this.infoLabel.TabIndex = 9;
            // 
            // nameWarning
            // 
            this.nameWarning.AutoSize = true;
            this.nameWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameWarning.ForeColor = System.Drawing.Color.Red;
            this.nameWarning.Location = new System.Drawing.Point(410, 100);
            this.nameWarning.Name = "nameWarning";
            this.nameWarning.Size = new System.Drawing.Size(0, 24);
            this.nameWarning.TabIndex = 10;
            // 
            // warrningPrenume
            // 
            this.warrningPrenume.AutoSize = true;
            this.warrningPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warrningPrenume.ForeColor = System.Drawing.Color.Red;
            this.warrningPrenume.Location = new System.Drawing.Point(410, 154);
            this.warrningPrenume.Name = "warrningPrenume";
            this.warrningPrenume.Size = new System.Drawing.Size(0, 24);
            this.warrningPrenume.TabIndex = 11;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c1Name,
            this.c1Prenume,
            this.c1Data});
            this.listView1.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.listView1.ForeColor = System.Drawing.Color.Maroon;
            listViewGroup1.Header = "Admin";
            listViewGroup1.Name = "Admin";
            listViewGroup2.Header = "Standard";
            listViewGroup2.Name = "Standard";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listView1.HideSelection = false;
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup2;
            listViewItem3.Group = listViewGroup2;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(23, 35);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(387, 213);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // c1Name
            // 
            this.c1Name.Text = "name";
            this.c1Name.Width = 101;
            // 
            // c1Prenume
            // 
            this.c1Prenume.Text = "Prenume";
            this.c1Prenume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.c1Prenume.Width = 82;
            // 
            // c1Data
            // 
            this.c1Data.Text = "DataNasterii";
            this.c1Data.Width = 102;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(493, 315);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.warrningPrenume);
            this.Controls.Add(this.nameWarning);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.datePick);
            this.Controls.Add(this.textPrenume);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelPrenume);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.rmvBtn);
            this.Controls.Add(this.addBtn);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button addBtn;
        private Button rmvBtn;
        private TextBox textName;
        private Label labelName;
        private Label labelPrenume;
        private Label labelData;
        private TextBox textPrenume;
        private DateTimePicker datePick;
        private Label infoLabel;
        private Label nameWarning;
        private Label warrningPrenume;
        private ListView listView1;
        private ColumnHeader c1Name;
        private ColumnHeader c1Prenume;
        private ColumnHeader c1Data;
        private CheckBox checkBox1;
    }



}

