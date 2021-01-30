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
    public partial class addCheltuieli : Form
    {

        public addCheltuieli()
        {
           
            InitializeComponent();
        }

        private void confirmAdd_Click_1(object sender, EventArgs e)
        {
            if (textDescriere.Text != "" && sumaPlata.Value > 0 && tipPlata.Text != "")
            {
                //create obiect
                Cheltuieli cheltuiala = new Cheltuieli();
                cheltuiala.Descriere = textDescriere.Text;
                cheltuiala.Suma = sumaPlata.Value;
                cheltuiala.TipPlata = tipPlata.Text;
                cheltuiala.DataTranzactie = dataTranzactie.Text;

                //write in database
                accessDatabase.salveazaCheltuieli(cheltuiala);

                //refresh screen
                warningLabel.Text = "";
                textDescriere.Text = "";
                sumaPlata.Value = 0;
                tipPlata.Text = "";
                dataTranzactie.Value = DateTime.Now;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                warningLabel.Text = "Toate campurile sunt obligatorii!";
            }
        }
    }
}
