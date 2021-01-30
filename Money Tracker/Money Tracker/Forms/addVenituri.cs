using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Money_Tracker
{
    public partial class addVenituri : Form
    {
        public addVenituri()
        {
            InitializeComponent();
        }

        private void confirmAdd_Click(object sender, EventArgs e)
        {
            if (textDescriere.Text != "" && sumaVenit.Value > 0 && listaPlata.Text != "")
            {
                //create obiect
                Venituri venit = new Venituri();
                venit.Descriere = textDescriere.Text;
                venit.Suma = sumaVenit.Value;
                venit.TipVenit = listaPlata.Text;
                venit.DataVenit = date.Text;

                //write in database
                accessDatabase.salveazaVenituri(venit);

                //refresh screen
                warningLabel.Text = "";
                textDescriere.Text = "";
                sumaVenit.Value = 0;
                listaPlata.Text = "";
                date.Value = DateTime.Now;
                this.DialogResult = DialogResult.OK;


            }
            else
            {
                warningLabel.Text = "Toate campurile sunt obligatorii!";
            }

        }
    }
}
