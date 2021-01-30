using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Serialization;
using System.IO;
using Money_Tracker.Forms;

namespace Money_Tracker
{
    public partial class MainScreen : Form
    {
        public string categorie;
        public MainScreen()
        {
            InitializeComponent();
            filtruData.Checked = false;
        }

        List<Venituri> venit = new List<Venituri>();
        List<Cheltuieli> cheltuiala = new List<Cheltuieli>();
        List<Economii> economie = new List<Economii>();

        private void btnStatisctica_Click(object sender, EventArgs e)
        {
/*            chart.Titles.Add("Statistica");
            chart.Series["s1"].Points.AddXY("1", "30");
            chart.Series["s1"].Points.AddXY("2", "30");
            chart.Series["s1"].Points.AddXY("3", "30");*/
        }


        private void btnVenituri_Click(object sender, EventArgs e)
        {
            categorie = "venit";
            incarcaInfo(categorie);
            labelVenit.Visible = true;
            filtruTip.Visible = true;
        }

        private void btnCheltuieli_Click(object sender, EventArgs e)
        {
            categorie = "cheltuiala";
            incarcaInfo(categorie);
            labelVenit.Visible = true;
            filtruTip.Visible = true;
        }


        private void btnEconomii_Click(object sender, EventArgs e)
        {
            categorie = "economie";
            incarcaInfo(categorie);
            labelVenit.Visible = false;
            filtruTip.Visible = false;
        }


        private void addVenituri_Click(object sender, EventArgs e)
        {
            addVenituri addForm2 = new addVenituri();
            DialogResult result = addForm2.ShowDialog();
            if (result == DialogResult.OK)
            {
                categorie = "venit";
                incarcaInfo(categorie);
            }
        }

        private void addCheltuieli_Click(object sender, EventArgs e)
        {
            addCheltuieli addForm = new addCheltuieli();
            DialogResult result = addForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                categorie = "cheltuiala";
                incarcaInfo(categorie);
            }
        }

        private void addEconomii_Click(object sender, EventArgs e)
        {
            addEconomii addForm = new addEconomii();
            DialogResult result  = addForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                categorie = "economie";
                incarcaInfo(categorie);
            }
        }

        private void deleteRecord_Click(object sender, EventArgs e)
        {
            if (categorie == "venit")
            {
                if (DataView.SelectedCells[0].Value.ToString() != "" && 
                    DataView.SelectedCells[1].Value.ToString() != "" &&
                    DataView.SelectedCells[2].Value.ToString() != "" &&
                    DataView.SelectedCells[3].Value.ToString() != "" &&
                    DataView.SelectedCells[4].Value.ToString() != "")
                {
                    //create obiect
                    Venituri venits = new Venituri();
                    venits.ID = (int)DataView.SelectedCells[0].Value;
                    venits.Descriere = DataView.SelectedCells[1].Value.ToString();
                    venits.Suma = (decimal)DataView.SelectedCells[2].Value;
                    venits.TipVenit = DataView.SelectedCells[3].Value.ToString();
                    venits.DataVenit = DataView.SelectedCells[4].Value.ToString();
                    accessDatabase.DeleteVenituri(venits);
                    venit = accessDatabase.incarcaVenituri();
                    DataView.DataSource = venit;
                    incarcaInfo(categorie);
                }
                else
                {
                    return;
                }

            }
            else if(categorie == "cheltuiala")
            {
                //create obiect
                Cheltuieli expenses = new Cheltuieli();
                expenses.ID = (int)DataView.SelectedCells[0].Value;
                expenses.Descriere = DataView.SelectedCells[1].Value.ToString();
                expenses.Suma = (decimal)DataView.SelectedCells[2].Value;
                expenses.TipPlata = DataView.SelectedCells[3].Value.ToString();
                expenses.DataTranzactie = DataView.SelectedCells[4].Value.ToString();
                accessDatabase.DeleteCheltuieli(expenses);
                cheltuiala = accessDatabase.incarcaCheltuieli();
                DataView.DataSource = cheltuiala;
            }
            else if (categorie == "economie")
            {
                //create obiect
                Economii saves = new Economii();
                saves.ID = (int)DataView.SelectedCells[0].Value;
                saves.Descriere = DataView.SelectedCells[1].Value.ToString();
                saves.Suma = (decimal)DataView.SelectedCells[2].Value;
                saves.DataAdaugare = DataView.SelectedCells[3].Value.ToString();
                accessDatabase.DeleteEconomii(saves);
                economie = accessDatabase.incarcaEconomii();
                DataView.DataSource = economie;
            }


        }

        private void incarcaInfo(string categorie)
        {
            if (categorie == "venit")
            {
                venit = accessDatabase.incarcaVenituri();
                DataView.DataSource = venit;
            }
            else if (categorie == "cheltuiala")
            {
                cheltuiala = accessDatabase.incarcaCheltuieli();
                DataView.DataSource = cheltuiala;
            }
            else if (categorie == "economie")
            {
                economie = accessDatabase.incarcaEconomii();
                DataView.DataSource = economie;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (categorie == "venit")
            {
                modificaVenituri UpdateForm = new modificaVenituri();
                DialogResult result = UpdateForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    incarcaInfo(categorie);
                }
                /*                                   
                                //create obiect
                                Venituri updateVenit = new Venituri();
                                updateVenit.ID = (int)DataView.SelectedCells[0].Value;
                                updateVenit.Descriere = DataView.SelectedCells[1].Value.ToString();
                                updateVenit.Suma = (decimal)DataView.SelectedCells[2].Value;
                                updateVenit.TipVenit = DataView.SelectedCells[3].Value.ToString();
                                updateVenit.DataVenit = DataView.SelectedCells[4].Value.ToString();
                                accessDatabase.UpdateVenituri(updateVenit);
                                venit = accessDatabase.incarcaVenituri();
                                DataView.DataSource = venit;*/
            }
            else if (categorie == "cheltuiala")
            {
                modificaCheltuieli UpdateForm = new modificaCheltuieli();
                DialogResult result = UpdateForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    incarcaInfo(categorie);
                }
                /*                //create obiect
                                Cheltuieli updateCheltuieli = new Cheltuieli();
                                updateCheltuieli.ID = (int)DataView.SelectedCells[0].Value;
                                updateCheltuieli.Descriere = DataView.SelectedCells[1].Value.ToString();
                                updateCheltuieli.Suma = (decimal)DataView.SelectedCells[2].Value;
                                updateCheltuieli.TipPlata = DataView.SelectedCells[3].Value.ToString();
                                updateCheltuieli.DataTranzactie = DataView.SelectedCells[4].Value.ToString();
                                accessDatabase.UpdateCheltuieli(updateCheltuieli);
                                cheltuiala = accessDatabase.incarcaCheltuieli();
                                DataView.DataSource = cheltuiala;*/
            }
            else if (categorie == "economie")
            {
                modificaEconomie UpdateForm = new modificaEconomie();
                DialogResult result = UpdateForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    incarcaInfo(categorie);
                }
                /*                //create obiect
                                Economii updateEconomie= new Economii();
                                updateEconomie.ID = (int)DataView.SelectedCells[0].Value;
                                updateEconomie.Descriere = DataView.SelectedCells[1].Value.ToString();
                                updateEconomie.Suma = (decimal)DataView.SelectedCells[2].Value;
                                updateEconomie.DataAdaugare = DataView.SelectedCells[3].Value.ToString();
                                accessDatabase.UpdateEconomii(updateEconomie);
                                economie = accessDatabase.incarcaEconomii();
                                DataView.DataSource = economie;*/
            }

        }
        private void filtruData_ValueChanged(object sender, EventArgs e)
        {
            filtruData.Checked = true;
        }
        private void setFilter_Click(object sender, EventArgs e)
        {

            if (categorie == "venit")
            {
                //filtruData.Text == DateTime.Now.ToLongDateString()

                //filtru descriere
                if (filtruDescriere.Text != "" && (decimal)filtruSuma.Value == 0 &&
                    filtruData.Checked == false && filtruTip.Text == "")
                {
                    venit = accessDatabase.FiltruDescriereVenit(filtruDescriere.Text);
                    DataView.DataSource = venit;
                }
                //filtru suma
                else if (filtruDescriere.Text == "" && (decimal)filtruSuma.Value > 0 &&
                         filtruData.Checked == false && filtruTip.Text == "")
                {
                    venit = accessDatabase.FiltruSumaVenit(filtruSuma.Value);
                    DataView.DataSource = venit;
                }
                //filtru Data
                else if ((filtruDescriere.Text == "" && (decimal)filtruSuma.Value == 0 &&
                         filtruData.Checked == true && filtruData.Text != DateTime.Now.ToLongDateString() && filtruTip.Text == "")
                        ||
                        (filtruDescriere.Text == "" && (decimal)filtruSuma.Value == 0 &&
                         filtruData.Checked == true && filtruData.Text == DateTime.Now.ToLongDateString() && filtruTip.Text == ""))
                {
                    venit = accessDatabase.FiltruDataVenit(filtruData.Text);
                    DataView.DataSource = venit;
                }
                //filtru tipVenit
                else if (filtruDescriere.Text == "" && (decimal)filtruSuma.Value == 0 &&
                         filtruData.Checked == false && filtruTip.Text != "")
                {
                    venit = accessDatabase.FiltruTipVenit(filtruTip.Text);
                    DataView.DataSource = venit;
                }
                //filtru descriere + suma
                else if (filtruDescriere.Text != "" && (decimal)filtruSuma.Value > 0 &&
                         filtruData.Checked == false && filtruTip.Text == "")
                {
                    venit = accessDatabase.FiltruDescriereSumaVenit(filtruDescriere.Text, filtruSuma.Value);
                    DataView.DataSource = venit;
                }
                //filtru descriere + suma + tip
                else if (filtruDescriere.Text != "" && (decimal)filtruSuma.Value > 0 &&
                        filtruData.Checked == false && filtruTip.Text != "")
                {
                    venit = accessDatabase.FiltruDescriereSumaTipVenit(filtruDescriere.Text, filtruSuma.Value, filtruTip.Text);
                    DataView.DataSource = venit;
                }
                //filtru descriere + suma + data
                else if ((filtruDescriere.Text != "" && (decimal)filtruSuma.Value > 0 &&
                        filtruData.Checked == true && filtruData.Text != DateTime.Now.ToLongDateString() && filtruTip.Text == "")
                        ||
                        (filtruDescriere.Text != "" && (decimal)filtruSuma.Value > 0 &&
                         filtruData.Checked == true && filtruData.Text == DateTime.Now.ToLongDateString() && filtruTip.Text == ""))
                {
                    venit = accessDatabase.FiltruDescriereSumaTipVenit(filtruDescriere.Text, filtruSuma.Value, filtruTip.Text);
                    DataView.DataSource = venit;
                }
                //filtru descriere + suma + data + tip
                else if ((filtruDescriere.Text != "" && (decimal)filtruSuma.Value > 0 &&
                        filtruData.Checked == true && filtruData.Text != DateTime.Now.ToLongDateString() && filtruTip.Text != "")
                        ||
                        (filtruDescriere.Text != "" && (decimal)filtruSuma.Value > 0 &&
                         filtruData.Checked == true && filtruData.Text == DateTime.Now.ToLongDateString() && filtruTip.Text != ""))
                {
                    venit = accessDatabase.FiltruDescriereSumaDataTipVenit(filtruDescriere.Text, filtruSuma.Value, filtruData.Text, filtruTip.Text);
                    DataView.DataSource = venit;
                }
                //filtru descriere + data + tip
                else if ((filtruDescriere.Text != "" && (decimal)filtruSuma.Value == 0 &&
                        filtruData.Checked == true && filtruData.Text != DateTime.Now.ToLongDateString() && filtruTip.Text != "")
                        ||
                        (filtruDescriere.Text != "" && (decimal)filtruSuma.Value == 0 &&
                         filtruData.Checked == true && filtruData.Text == DateTime.Now.ToLongDateString() && filtruTip.Text != ""))
                {
                    venit = accessDatabase.FiltruDescriereDataTipVenit(filtruDescriere.Text, filtruData.Text, filtruTip.Text);
                    DataView.DataSource = venit;
                }
                //filtru descriere + data
                else if ((filtruDescriere.Text != "" && (decimal)filtruSuma.Value == 0 &&
                        filtruData.Checked == true && filtruData.Text != DateTime.Now.ToLongDateString() && filtruTip.Text == "")
                        ||
                        (filtruDescriere.Text != "" && (decimal)filtruSuma.Value == 0 &&
                         filtruData.Checked == true && filtruData.Text == DateTime.Now.ToLongDateString() && filtruTip.Text == ""))
                {
                    venit = accessDatabase.FiltruDescriereDataVenit(filtruDescriere.Text, filtruData.Text);
                    DataView.DataSource = venit;
                }
                //filtru descriere + tip
                else if ((filtruDescriere.Text != "" && (decimal)filtruSuma.Value == 0 &&
                        filtruData.Checked == false && filtruTip.Text != ""))
                {
                    venit = accessDatabase.FiltruDescriereTipVenit(filtruDescriere.Text, filtruTip.Text);
                    DataView.DataSource = venit;
                }
                //filtru suma + tip
                else if (filtruDescriere.Text == "" && (decimal)filtruSuma.Value > 0 &&
                        filtruData.Checked == false && filtruTip.Text != "")
                {
                    venit = accessDatabase.FiltruSumaTipVenit(filtruSuma.Value, filtruTip.Text);
                    DataView.DataSource = venit;
                }
                //filtru suma + data
                else if ((filtruDescriere.Text == "" && (decimal)filtruSuma.Value > 0 &&
                        filtruData.Checked == true && filtruData.Text != DateTime.Now.ToLongDateString() && filtruTip.Text == "")
                        ||
                        (filtruDescriere.Text == "" && (decimal)filtruSuma.Value > 0 &&
                         filtruData.Checked == true && filtruData.Text == DateTime.Now.ToLongDateString() && filtruTip.Text == ""))
                {
                    venit = accessDatabase.FiltruSumaDataVenit(filtruSuma.Value, filtruData.Text);
                    DataView.DataSource = venit;
                }
                //filtru suma + data + tip
                else if ((filtruDescriere.Text == "" && (decimal)filtruSuma.Value > 0 &&
                        filtruData.Checked == true && filtruData.Text != DateTime.Now.ToLongDateString() && filtruTip.Text != "")
                        ||
                        (filtruDescriere.Text == "" && (decimal)filtruSuma.Value > 0 &&
                         filtruData.Checked == true && filtruData.Text == DateTime.Now.ToLongDateString() && filtruTip.Text != ""))
                {
                    venit = accessDatabase.FiltruSumaDataTipVenit(filtruSuma.Value, filtruData.Text, filtruTip.Text);
                    DataView.DataSource = venit;
                }
                //filtru data + tip
                else if ((filtruDescriere.Text == "" && (decimal)filtruSuma.Value == 0 &&
                        filtruData.Checked == true && filtruData.Text != DateTime.Now.ToLongDateString() && filtruTip.Text != "")
                        ||
                        (filtruDescriere.Text == "" && (decimal)filtruSuma.Value == 0 &&
                         filtruData.Checked == true && filtruData.Text == DateTime.Now.ToLongDateString() && filtruTip.Text != ""))
                {
                    venit = accessDatabase.FiltruDataTipVenit(filtruData.Text, filtruTip.Text);
                    DataView.DataSource = venit;
                }
            }

            //FILTRARE PENTRU CHELTUIELI
            else if (categorie == "cheltuiala")
            {
                //filtruData.Text == DateTime.Now.ToLongDateString()

                //filtru descriere
                if (filtruDescriere.Text != "" && (decimal)filtruSuma.Value == 0 &&
                    filtruData.Checked == false && filtruTip.Text == "")
                {
                    cheltuiala = accessDatabase.FiltruDescriereCheltuiala(filtruDescriere.Text);
                    DataView.DataSource = cheltuiala;
                }
                //filtru suma
                else if (filtruDescriere.Text == "" && (decimal)filtruSuma.Value > 0 &&
                         filtruData.Checked == false && filtruTip.Text == "")
                {
                    cheltuiala = accessDatabase.FiltruSumaCheltuiala(filtruSuma.Value);
                    DataView.DataSource = cheltuiala;
                }
                //filtru Data
                else if ((filtruDescriere.Text == "" && (decimal)filtruSuma.Value == 0 &&
                         filtruData.Checked == true && filtruData.Text != DateTime.Now.ToLongDateString() && filtruTip.Text == "")
                        ||
                        (filtruDescriere.Text == "" && (decimal)filtruSuma.Value == 0 &&
                         filtruData.Checked == true && filtruData.Text == DateTime.Now.ToLongDateString() && filtruTip.Text == ""))
                {
                    cheltuiala = accessDatabase.FiltruDataCheltuiala(filtruData.Text);
                    DataView.DataSource = cheltuiala;
                }
                //filtru tipVenit
                else if (filtruDescriere.Text == "" && (decimal)filtruSuma.Value == 0 &&
                         filtruData.Checked == false && filtruTip.Text != "")
                {
                    cheltuiala = accessDatabase.FiltruTipCheltuiala(filtruTip.Text);
                    DataView.DataSource = cheltuiala;
                }
                //filtru descriere + suma
                else if (filtruDescriere.Text != "" && (decimal)filtruSuma.Value > 0 &&
                         filtruData.Checked == false && filtruTip.Text == "")
                {
                    cheltuiala = accessDatabase.FiltruDescriereSumaCheltuiala(filtruDescriere.Text, filtruSuma.Value);
                    DataView.DataSource = cheltuiala;
                }
                //filtru descriere + suma + tip
                else if (filtruDescriere.Text != "" && (decimal)filtruSuma.Value > 0 &&
                        filtruData.Checked == false && filtruTip.Text != "")
                {
                    cheltuiala = accessDatabase.FiltruDescriereSumaTipCheltuiala(filtruDescriere.Text, filtruSuma.Value, filtruTip.Text);
                    DataView.DataSource = cheltuiala;
                }
                //filtru descriere + suma + data
                else if ((filtruDescriere.Text != "" && (decimal)filtruSuma.Value > 0 &&
                        filtruData.Checked == true && filtruData.Text != DateTime.Now.ToLongDateString() && filtruTip.Text == "")
                        ||
                        (filtruDescriere.Text != "" && (decimal)filtruSuma.Value > 0 &&
                         filtruData.Checked == true && filtruData.Text == DateTime.Now.ToLongDateString() && filtruTip.Text == ""))
                {
                    cheltuiala = accessDatabase.FiltruDescriereSumaTipCheltuiala(filtruDescriere.Text, filtruSuma.Value, filtruTip.Text);
                    DataView.DataSource = cheltuiala;
                }
                //filtru descriere + suma + data + tip
                else if ((filtruDescriere.Text != "" && (decimal)filtruSuma.Value > 0 &&
                        filtruData.Checked == true && filtruData.Text != DateTime.Now.ToLongDateString() && filtruTip.Text != "")
                        ||
                        (filtruDescriere.Text != "" && (decimal)filtruSuma.Value > 0 &&
                         filtruData.Checked == true && filtruData.Text == DateTime.Now.ToLongDateString() && filtruTip.Text != ""))
                {
                    cheltuiala = accessDatabase.FiltruDescriereSumaDataTipCheltuiala(filtruDescriere.Text, filtruSuma.Value, filtruData.Text, filtruTip.Text);
                    DataView.DataSource = cheltuiala;
                }
                //filtru descriere + data + tip
                else if ((filtruDescriere.Text != "" && (decimal)filtruSuma.Value == 0 &&
                        filtruData.Checked == true && filtruData.Text != DateTime.Now.ToLongDateString() && filtruTip.Text != "")
                        ||
                        (filtruDescriere.Text != "" && (decimal)filtruSuma.Value == 0 &&
                         filtruData.Checked == true && filtruData.Text == DateTime.Now.ToLongDateString() && filtruTip.Text != ""))
                {
                    cheltuiala = accessDatabase.FiltruDescriereDataTipCheltuiala(filtruDescriere.Text, filtruData.Text, filtruTip.Text);
                    DataView.DataSource = cheltuiala;
                }
                //filtru descriere + data
                else if ((filtruDescriere.Text != "" && (decimal)filtruSuma.Value == 0 &&
                        filtruData.Checked == true && filtruData.Text != DateTime.Now.ToLongDateString() && filtruTip.Text == "")
                        ||
                        (filtruDescriere.Text != "" && (decimal)filtruSuma.Value == 0 &&
                         filtruData.Checked == true && filtruData.Text == DateTime.Now.ToLongDateString() && filtruTip.Text == ""))
                {
                    cheltuiala = accessDatabase.FiltruDescriereDataCheltuiala(filtruDescriere.Text, filtruData.Text);
                    DataView.DataSource = cheltuiala;
                }
                //filtru descriere + tip
                else if ((filtruDescriere.Text != "" && (decimal)filtruSuma.Value == 0 &&
                        filtruData.Checked == false && filtruTip.Text != ""))
                {
                    cheltuiala = accessDatabase.FiltruDescriereTipCheltuiala(filtruDescriere.Text, filtruTip.Text);
                    DataView.DataSource = cheltuiala;
                }
                //filtru suma + tip
                else if (filtruDescriere.Text == "" && (decimal)filtruSuma.Value > 0 &&
                        filtruData.Checked == false && filtruTip.Text != "")
                {
                    cheltuiala = accessDatabase.FiltruSumaTipCheltuiala(filtruSuma.Value, filtruTip.Text);
                    DataView.DataSource = cheltuiala;
                }
                //filtru suma + data
                else if ((filtruDescriere.Text == "" && (decimal)filtruSuma.Value > 0 &&
                        filtruData.Checked == true && filtruData.Text != DateTime.Now.ToLongDateString() && filtruTip.Text == "")
                        ||
                        (filtruDescriere.Text == "" && (decimal)filtruSuma.Value > 0 &&
                         filtruData.Checked == true && filtruData.Text == DateTime.Now.ToLongDateString() && filtruTip.Text == ""))
                {
                    cheltuiala = accessDatabase.FiltruSumaDataCheltuiala(filtruSuma.Value, filtruData.Text);
                    DataView.DataSource = cheltuiala;
                }
                //filtru suma + data + tip
                else if ((filtruDescriere.Text == "" && (decimal)filtruSuma.Value > 0 &&
                        filtruData.Checked == true && filtruData.Text != DateTime.Now.ToLongDateString() && filtruTip.Text != "")
                        ||
                        (filtruDescriere.Text == "" && (decimal)filtruSuma.Value > 0 &&
                         filtruData.Checked == true && filtruData.Text == DateTime.Now.ToLongDateString() && filtruTip.Text != ""))
                {
                    cheltuiala = accessDatabase.FiltruSumaDataTipCheltuiala(filtruSuma.Value, filtruData.Text, filtruTip.Text);
                    DataView.DataSource = cheltuiala;
                }
                //filtru data + tip
                else if ((filtruDescriere.Text == "" && (decimal)filtruSuma.Value == 0 &&
                        filtruData.Checked == true && filtruData.Text != DateTime.Now.ToLongDateString() && filtruTip.Text != "")
                        ||
                        (filtruDescriere.Text == "" && (decimal)filtruSuma.Value == 0 &&
                         filtruData.Checked == true && filtruData.Text == DateTime.Now.ToLongDateString() && filtruTip.Text != ""))
                {
                    cheltuiala = accessDatabase.FiltruDataTipCheltuiala(filtruData.Text, filtruTip.Text);
                    DataView.DataSource = cheltuiala;
                }
            }
            //FILTRARE PENTRU ECONOMII
            else if (categorie == "economie")
            {
                //filtruData.Text == DateTime.Now.ToLongDateString()

                //filtru descriere
                if (filtruDescriere.Text != "" && (decimal)filtruSuma.Value == 0 &&
                    filtruData.Checked == false)
                {
                    economie = accessDatabase.FiltruDescriereEconomie(filtruDescriere.Text);
                    DataView.DataSource = economie;
                }
                //filtru suma
                else if (filtruDescriere.Text == "" && (decimal)filtruSuma.Value > 0 &&
                         filtruData.Checked == false)
                {
                    economie = accessDatabase.FiltruSumaEconomie(filtruSuma.Value);
                    DataView.DataSource = economie;
                }
                //filtru Data
                else if ((filtruDescriere.Text == "" && (decimal)filtruSuma.Value == 0 &&
                         filtruData.Checked == true && filtruData.Text != DateTime.Now.ToLongDateString())
                        ||
                        (filtruDescriere.Text == "" && (decimal)filtruSuma.Value == 0 &&
                         filtruData.Checked == true && filtruData.Text == DateTime.Now.ToLongDateString()))
                {
                    economie = accessDatabase.FiltruDataEconomie(filtruData.Text);
                    DataView.DataSource = economie;
                }

                //filtru descriere + suma
                else if (filtruDescriere.Text != "" && (decimal)filtruSuma.Value > 0 &&
                         filtruData.Checked == false)
                {
                    economie = accessDatabase.FiltruDescriereSumaEconomie(filtruDescriere.Text, filtruSuma.Value);
                    DataView.DataSource = economie;
                }

                //filtru descriere + suma + data
                else if ((filtruDescriere.Text != "" && (decimal)filtruSuma.Value > 0 &&
                        filtruData.Checked == true && filtruData.Text != DateTime.Now.ToLongDateString())
                        ||
                        (filtruDescriere.Text != "" && (decimal)filtruSuma.Value > 0 &&
                         filtruData.Checked == true && filtruData.Text == DateTime.Now.ToLongDateString()))
                {
                    economie = accessDatabase.FiltruDescriereSumaDataEconomie(filtruDescriere.Text, filtruSuma.Value, filtruData.Text);
                    DataView.DataSource = economie;
                }

                //filtru descriere + data
                else if ((filtruDescriere.Text != "" && (decimal)filtruSuma.Value == 0 &&
                        filtruData.Checked == true && filtruData.Text != DateTime.Now.ToLongDateString())
                        ||
                        (filtruDescriere.Text != "" && (decimal)filtruSuma.Value == 0 &&
                         filtruData.Checked == true && filtruData.Text == DateTime.Now.ToLongDateString()))
                {
                    economie = accessDatabase.FiltruDescriereDataEconomie(filtruDescriere.Text, filtruData.Text);
                    DataView.DataSource = economie;
                }
                //filtru suma + data
                else if ((filtruDescriere.Text == "" && (decimal)filtruSuma.Value > 0 &&
                        filtruData.Checked == true && filtruData.Text != DateTime.Now.ToLongDateString())
                        ||
                        (filtruDescriere.Text == "" && (decimal)filtruSuma.Value > 0 &&
                         filtruData.Checked == true && filtruData.Text == DateTime.Now.ToLongDateString()))
                {
                    economie = accessDatabase.FiltruSumaDataEconomie(filtruSuma.Value, filtruData.Text);
                    DataView.DataSource = economie;
                }
            }
        }

        private void resetFiltre_Click(object sender, EventArgs e)
        {
             if (categorie == "venit")
            {
                incarcaInfo(categorie);
                labelVenit.Visible = true;
                filtruTip.Visible = true;
            }
            else if (categorie == "cheltuiala")
            {
                incarcaInfo(categorie);
                labelVenit.Visible = true;
                filtruTip.Visible = true;

            }
            else if (categorie == "economie")
            {
                incarcaInfo(categorie);
                labelVenit.Visible = false;
                filtruTip.Visible = true;
            }

            filtruDescriere.Text = "";
            filtruSuma.Value = 0;
            filtruData.Value = DateTime.Now;
            filtruTip.Text = "";
            filtruData.Checked = false;
        }
    }
}
