using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularCovid
{
    public partial class declaratieCovid : Form
    {
        public declaratieCovid()
        {
            InitializeComponent();
        }

        public void fillInfo()
        {
            if (nameBox.Text != "" && prenumeBox.Text != ""
                && dataNasteriiBox.Text != "" && adressBox.Text != "" &&
                deplasareBox.Text != "" && dataDepBox.Text != "")
            {
                numeAfis.Text = nameBox.Text;
                prenumeAfis.Text = prenumeBox.Text;
                dataAfis.Text = dataNasteriiBox.Text;
                adresaAfis.Text = adressBox.Text;
                deplasareAfis.Text = deplasareBox.Text;
                dataDec.Text = dataDepBox.Text;
                warning.Text = "";
            }
            else
            {
                warning.Text = "Toate campurile sunt obligatorii!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fillInfo();
        }
    }
}
