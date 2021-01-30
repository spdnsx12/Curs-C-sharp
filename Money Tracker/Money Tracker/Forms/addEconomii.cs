using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money_Tracker.Forms
{
    public partial class addEconomii : Form
    {
        public addEconomii()
        {
            InitializeComponent();
        }

        private void confirmAdd_Click(object sender, EventArgs e)
        {
            if (textDescriere.Text != "" && suma.Value > 0)
            {
                //create obiect
                Economii economie = new Economii();
                economie.Descriere = textDescriere.Text;
                economie.Suma = suma.Value;
                economie.DataAdaugare = dataAdaugare.Text;

                //write in database
                accessDatabase.salveazaEconomii(economie);

                //refresh screen
                warningLabel.Text = "";
                textDescriere.Text = "";
                suma.Value = 0;
                dataAdaugare.Value = DateTime.Now;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                warningLabel.Text = "Toate campurile sunt obligatorii!";
            }
        }
    }
}
