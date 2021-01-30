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

namespace SalvareDateLocal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string path = "C:/Users/Sorin/Desktop/f1.txt";
            StreamReader streamReader = new StreamReader(path);
            string primaLinie = streamReader.ReadLine();
            richTextBox1.Text = primaLinie;

            streamReader.Close();


        }

        private void pickBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                StreamReader streamReader = new StreamReader(path);
                richTextBox2.Text = streamReader.ReadToEnd();
                streamReader.Close();


            }


        }

        private void writeBtn_Click(object sender, EventArgs e)
        {
            string path = "C:/Users/Sorin/Desktop/f1.txt";
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.Write(richTextBox2.Text);
            streamWriter.Close();

        }



        private void writeInFile_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                StreamReader stream = new StreamReader(path);
                string mesajInitial = stream.ReadToEnd();
                stream.Close();

                string mesajFinal = mesajInitial + richTextBox2.Text;
                StreamWriter streamWriter = new StreamWriter(path);
                
                streamWriter.WriteLine(mesajFinal);
                streamWriter.Close();

            }
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            string caleSursa = "C:/Users/Sorin/Desktop/f1.txt";
            string caleDestinatie = "C:/Users/Sorin/Documents/f1.txt";
            string caleSursa2 = "C:/Users/Sorin/Desktop/f2.txt";
            string caleDestinatie2 = "C:/Users/Sorin/Documents/f2.txt";
            File.Copy(caleSursa, caleDestinatie,true);

        }

        private void moveBtn_Click(object sender, EventArgs e)
        {
            string caleSursa2 = "C:/Users/Sorin/Desktop/f2.txt";
            string caleDestinatie2 = "C:/Users/Sorin/Documents/f2.txt";
            File.Move(caleSursa2, caleDestinatie2);
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            string caleDestinatieDelete = "C:/Users/Sorin/Documents/f2.txt";
            File.Delete(caleDestinatieDelete);
        }
    }
}
