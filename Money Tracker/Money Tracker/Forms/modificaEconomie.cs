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
    public partial class modificaEconomie : Form
    {
        public modificaEconomie()
        {
            InitializeComponent();
        }

        private void confirmUpdate_Click(object sender, EventArgs e)
        {
            if (textDescriere.Text != "" && suma.Value > 0)
            {
                //create obiect
                Economii updateEconomie = new Economii();
                updateEconomie.ID = (int)idValue.Value;
                updateEconomie.Descriere = textDescriere.Text;
                updateEconomie.Suma = suma.Value;
                updateEconomie.DataAdaugare = dataAdaugare.Text;
                accessDatabase.UpdateEconomii(updateEconomie);
            }
            else
            {
                warningLabel.Text = "Toate campurile sunt obligatorii!";
            }
        }
    }
}
