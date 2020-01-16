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

namespace CountryList
{


    partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            //this.CountryList.SelectionMode = SelectionMode.One;
            ReadingFile();

        }
        private void ReadingFile()
        {

            string[] headers = new string[6]; //column headers#

            const int MAX_LINES_FILE = 50000;

            string[] AllLines = new string[MAX_LINES_FILE];

            //reads from bin/DEBUG subdirectory of project directory
            AllLines = File.ReadAllLines("countries.csv");


            foreach (string line in AllLines)
            {

                if (line.StartsWith("Country")) //found first line - headers
                {
                    headers = line.Split(',');
                }

                else
                {
                    //split data using commas
                    string[] columns = line.Split(',');
                    Console.Write(columns[0] + ","); //first string in line;
                    Console.Write(columns[1] + ","); //2nd string in line;

                    string[] partners = columns[5].Split(';', '[', ']');
                    foreach (string tradePartner in partners)
                    {
                        if (tradePartner != "")
                        {
                            Console.Write(":" + tradePartner);

                        }
                    }
                }
            }
        }


        //clicks for the design
    





        private void Country_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Check_Click(object sender, EventArgs e)
        {

        }

        private void CountryList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GDP_Click(object sender, EventArgs e)
        {

        }

        private void Inflation_Click(object sender, EventArgs e)
        {

        }

        private void HDI_Click(object sender, EventArgs e)
        {

        }

        private void Partners_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainpartnersText_TextChanged(object sender, EventArgs e)
        {

        }

        private void HDItext_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void SearchByName_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Box1_Enter(object sender, EventArgs e)
        {

        }

        private void Remove_Click(object sender, EventArgs e)
        {

        }

       private void button2_Click(object sender, EventArgs e)
        {

        }

        private void GoTo_Click(object sender, EventArgs e)
        {

        }

        private void SNamePArtnersText_Click(object sender, EventArgs e)
        {

        }

        private void SearchNPBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Namettextbox_Click(object sender, EventArgs e)
        {

        }

        private void GDGTextBox_Click(object sender, EventArgs e)
        {

        }

        private void InflationTextBox_Click(object sender, EventArgs e)
        {

        }

        private void HDITextBox_Click(object sender, EventArgs e)
        {

        }

        private void TradebalanceBox_Click(object sender, EventArgs e)
        {

        }

        private void PartnersBox_Click(object sender, EventArgs e)
        {

        }

        private void RemoveBox_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void Unordered_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OrderedTick_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addasanewcountry_Click(object sender, EventArgs e)
        {

        }
    }
}

