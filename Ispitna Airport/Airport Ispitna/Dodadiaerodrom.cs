using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport_Ispitna
{
    public partial class Dodadiaerodrom : Form
    {
        
        public Dodadiaerodrom()
        {
            InitializeComponent();
        }
        public List<Airport> AirportList
        {
            get { return airports; }
        }
        List<Airport> airports = new List<Airport>();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnzacuvajaerodrom_Click(object sender, EventArgs e)
        {
            Airport airport = new Airport(txtgrad.Text, txtime.Text, txtkratenka.Text);
            airports.Add(airport);
            this.Close();
        }

        private void btnotkaziaerodrom_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Дали сигурно сакате да го откажете додавањето на нов аеродром?", "ОПОМЕНА!",
                MessageBoxButtons.YesNo, // vid na dijalogot 
                MessageBoxIcon.Question); // ikona na dijalogot
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
