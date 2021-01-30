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

namespace curs6
{
    
    public partial class Form1 : Form
    {
        private shop _cofeeShop;
        public Form1()
        {
            _cofeeShop = new shop();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            category category1 = new category(0,"tchibo","cafea proaspata");
            category category2 = new category(1, "Elite", "cafea boabe");
            category category3 = new category(2, "Nescafe", "cafea la kg");


            _cofeeShop.Categories.Add(new category(0, "tchibo", "cafea proaspata"));
            _cofeeShop.Categories.Add(new category(1, "Elite", "cafea boabe"));
            _cofeeShop.Categories.Add(new category(2, "Nescafe", "cafea la kg"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(category item in _cofeeShop.Categories)
            {
                label1.Text += item.nume + " ";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddCategory addForm = new frmAddCategory();
            DialogResult raspuns = addForm.ShowDialog();

            if(raspuns == DialogResult.OK)
            {
                _cofeeShop.Categories.Add(addForm.CategorieAdaugata);
            }

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void srlzBtn_Click(object sender, EventArgs e)
        {
            product product = new product();
            product.id = 0;
            product.nume = "bicicleta";
            product.descriere = "MTB";
            product.pret = 99.99M;

            product produs2 = new product();
            produs2.id = 0;
            produs2.nume = "bicicleta";
            produs2.descriere = "cursiera";
            produs2.pret = 99.99M;

            List<product> products = new List<product> { product, produs2 };


            XmlSerializer xml = new XmlSerializer(typeof(List<product>));

            StreamWriter stream = new StreamWriter("C:/Users/Sorin/Desktop/produse.xml");
            xml.Serialize(stream, products);
            stream.Close();

        }

        private void dsrlzBtn_Click(object sender, EventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<product>));
            StreamReader streamReader = new StreamReader("C:/Users/Sorin/Desktop/produse.xml");
            List<product> products = (List<product>)xml.Deserialize(streamReader);
            streamReader.Close();
            dataGridView1.DataSource = products;
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<product>));

            StreamWriter stream = new StreamWriter("C:/Users/Sorin/Desktop/produse.xml");
            xml.Serialize(stream, dataGridView1.DataSource);
            stream.Close();
        }
    }
}
