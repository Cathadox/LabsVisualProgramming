using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class TopLista : Form
    {
        Form1 f { get; set; }
        public TopLista(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TopLista_Load(object sender, EventArgs e)
        {
            
            f.ListaIgrachi = f.ListaIgrachi.OrderByDescending(x => x.Points).ToList();
            foreach(Player igrach in f.ListaIgrachi)
            {
                listBox1.Items.Add(igrach);
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
