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
    public partial class modificaCheltuieli : Form
    {
        public modificaCheltuieli()
        {
            InitializeComponent();
        }

        private void confirmUpdate_Click(object sender, EventArgs e)
        {
            if (textDescriere.Text != "" && sumaPlata.Value > 0 && tipPlata.Text != "")
            {
                //create obiect
                Cheltuieli updateCheltuiala = new Cheltuieli();

                updateCheltuiala.ID = (int)idValue.Value;
                updateCheltuiala.Descriere = textDescriere.Text;
                updateCheltuiala.Suma = sumaPlata.Value;
                updateCheltuiala.TipPlata = tipPlata.Text;
                updateCheltuiala.DataTranzactie = dataTranzactie.Text;
                accessDatabase.UpdateCheltuieli(updateCheltuiala);
            }
            else
            {
                warningLabel.Text = "Toate campurile sunt obligatorii!";
            }
        }
    }
}
