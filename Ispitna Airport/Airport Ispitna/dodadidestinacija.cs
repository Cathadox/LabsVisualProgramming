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
    
    public partial class dodadidestinacija : Form
    {
        Form1 frm;
        Dodadiaerodrom aerodromform;
        public dodadidestinacija()
        {
            InitializeComponent();
        }
        List<Destination> destinations = new List<Destination>();
        private void btnotkazidestinacija_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Дали сигурно сакате да го откажете додавањето на нова дестинација?", "ОПОМЕНА!",
                MessageBoxButtons.YesNo, // vid na dijalogot 
                MessageBoxIcon.Question); // ikona na dijalogot
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btndodadidestinacija_Click(object sender, EventArgs e)
        {
            frm = new Form1();
            aerodromform = new Dodadiaerodrom();
            int d = 0, b = 0;
            int.TryParse(txtdolzina.Text, out d);
            int.TryParse(txtcena.Text, out b);
            Destination destination = new Destination(txtime.Text,d,b);
            foreach (Airport airport in aerodromform.AirportList)
            {
                if(frm.lbaerodromi.SelectedItem == airport )
                {
                    airport.AddDestination(destination);
                    MessageBox.Show(airport.ToString());
                }
            }
            this.Close();
            
        }
    }
}
