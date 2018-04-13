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
    public partial class Form1 : Form
    {
        Dodadiaerodrom aerodromform;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btndodadiaerodrom_Click(object sender, EventArgs e)
        {
            //go povikuvame dijalogot na dodadiaerodrom
            aerodromform = new Dodadiaerodrom();
            aerodromform.Show();
            aerodromform.btnzacuvajaerodrom.Click += new EventHandler(aerodromformbtnzacuvaj_Click);
            //lbaerodromi.DisplayMember = "blbala";
            //pravime eventhandler koga kopcheto zachuvaj na dodadiaerodrom kje se klikne
        }

        private void aerodromformbtnzacuvaj_Click(object sender, EventArgs e)
        {   //listata od aerodromi ja prenesuvame na displej na listbox
            foreach (Airport airports in aerodromform.AirportList)
            {
                lbaerodromi.Items.Add(airports);
            }
        }

        private void btnbrisidestinacija_Click(object sender, EventArgs e)
        {
            dodadidestinacija destinacijaform = new dodadidestinacija();
            destinacijaform.Show();
        }

        private void btnbrisiaerodrom_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selecteditems = new ListBox.SelectedObjectCollection(lbaerodromi);
            selecteditems = lbaerodromi.SelectedItems;
            if (lbaerodromi.SelectedIndex != -1)
            {
                for (int i = selecteditems.Count - 1; i >= 0; i--)
                    lbaerodromi.Items.Remove(selecteditems[i]);
            }
            else
                MessageBox.Show("Не сте избрале аеродром!");


        }

        private void lbaerodromi_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Airport airport in aerodromform.AirportList)
            {
                if (lbaerodromi.SelectedItem == airport)
                { lbdestinacii.DataSource = airport.destinations; }
            }
            
        }
    }
}
