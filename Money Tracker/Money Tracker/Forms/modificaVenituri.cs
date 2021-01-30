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
    public partial class modificaVenituri : Form
    {
        public modificaVenituri()
        {
            InitializeComponent();
        }
          
        public void UpdateInfo(int id, string descriere, decimal suma, string tipVenit, string dataVenit)
        {

            idValue.Text = id.ToString();
            textDescriere.Text = descriere;
            sumaVenit.Value = suma;
            listaPlata.Text = tipVenit;
            date.Text = dataVenit;
        }

        public void confirmAdd_Click(object sender, EventArgs e)
        {
            if (textDescriere.Text != "" && sumaVenit.Value > 0 && listaPlata.Text != "")
            {
                Venituri updatedVenit = new Venituri();
                updatedVenit.ID = (int)idValue.Value; 
                updatedVenit.Descriere = textDescriere.Text;
                updatedVenit.Suma = sumaVenit.Value;
                updatedVenit.TipVenit = listaPlata.Text;
                updatedVenit.DataVenit = date.Text;
                accessDatabase.UpdateVenituri(updatedVenit);
            }
            else
            {
                warningLabel.Text = "Toate campurile sunt obligatorii!";
            }
        }


    }
}
