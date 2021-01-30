using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listView1.GridLines = true;
            listView1.Columns.Add("Locatie",-2,HorizontalAlignment.Right);
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (textName.Text != "" && textPrenume.Text != "")
            {
                ListViewItem item = new ListViewItem(textName.Text);
                item.SubItems.Add(textPrenume.Text);
                item.SubItems.Add(datePick.Value.ToString());
                item.SubItems.Add(textPrenume.Text);
                item.SubItems.Add(textName.Text);
                listView1.Items.Add(item);
                item.Group = listView1.Groups[0];
                textName.Clear();
                textPrenume.Clear();
                warrningPrenume.Text = "";
                nameWarning.Text = "";
                infoLabel.Text = "";
                
            }
            else
            {
                infoLabel.Text = " Campurile marcate cu * sunt obligatorii";
                warrningPrenume.Text = "*";
                nameWarning.Text = "*";
            }


            
        }

        private void rmvBtn_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
                listView1.Items.Remove(listView1.SelectedItems[0]);
        }
    }
}
