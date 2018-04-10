using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public List<Player> ListaIgrachi { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        
        Equation eq = new Equation();
        public int interval;
        public int pointscounter;
        Player Igrach;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        void NewGame()
        {

            txtplayername.Enabled = false;
            lblpoints.Text = "0";
            lbltime.Text = "1:00";
            pbtime.Value = 0;
            pbpoints.Value = 0;
            interval = 59;
            pointscounter = 1;
            Igrach = new Player(txtplayername.Text.Trim());
            LoadGameValues();
            Tiker = new System.Windows.Forms.Timer();
            Tiker.Enabled = true;
            Tiker.Start();
            Tiker.Interval = 1000;
            Tiker.Tick += new EventHandler(Tiker_tick);
           // btnguess.Click += new EventHandler(btnguess_click)
            
            


        }

        private void Tiker_tick(object sender, EventArgs e)
        {
            this.pbtime.Increment(1);
            if (pbtime.Value == 60)
            {   
              int k = 0;
              int.TryParse(lblpoints.Text, out k);
              Igrach.Points = k;
              ListaIgrachi.Add(Igrach);
                txtplayername.Enabled = true;
              this.Tiker.Stop();
            }
            if (pbtime.Value == 0)
                lbltime.Text = "1:00";
            else
                lbltime.Text = "0:" + (interval--).ToString();
            
        }

        void LoadGameValues()
        {
            eq.Randomize();
            txtvalue1.Text = eq.firstNumber.ToString();
            txtoperation.Text = eq.Operation.ToString();
            txtvalue2.Text = eq.secondNumber.ToString();
            txtresult.Text = "";

        }

        private void btnguess_Click(object sender, EventArgs e)
        {
            
            int i = 0;
            int.TryParse(txtresult.Text, out i);
            if (eq.result == i)
            {
                if (pointscounter%10 == 0)
                {
                    this.pbtime.Maximum = this.pbtime.Maximum + 10;
                    interval += 10;
                }
                lblpoints.Text = (pointscounter++).ToString();
                this.pbpoints.Increment(1);
            }
            LoadGameValues();
        }

        

        private void btnnew_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbtime.Maximum = 60;
            ListaIgrachi = new List<Player>();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbest_Click(object sender, EventArgs e)
        {
            TopLista f2 = new TopLista(this);
            f2.ShowDialog();
        }
    }
}
