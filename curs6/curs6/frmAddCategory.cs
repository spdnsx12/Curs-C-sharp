using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curs6
{
    public partial class frmAddCategory : Form
    {
        public category CategorieAdaugata { get; set; }
        public frmAddCategory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = (int) numericUpDown1.Value;
            string nume = textBox1.Text;
            string description = textBox2.Text;

            CategorieAdaugata = new category(id, nume, description);
            this.DialogResult = DialogResult.OK;
        }
    }
}
