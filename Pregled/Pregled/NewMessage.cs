using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pregled
{
    public partial class NewMessage : Form
    {
        public NewMessage()
        {
            InitializeComponent();
        }
        public string Message { get; set; }
        private void btnsend_Click(object sender, EventArgs e)
        {
            Message = txtmessage.Text;
            DialogResult = DialogResult.OK;

        }

        private void txtmessage_TextChanged(object sender, EventArgs e)
        {
            int k = 0;
            k = txtmessage.Text.Length;
            
            if (k < 60)
            {
                label1.ForeColor = System.Drawing.Color.Blue;
                label1.Text = k.ToString();
            }
            else
            {
                label1.ForeColor = System.Drawing.Color.Red;
                label1.Text = k.ToString();
                
            }
            
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewMessage_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.KeyValue == (char)8)
            //{
            //    txtmessage.Enabled = true;
            //    txtmessage.TextChanged += new EventHandler(txtmessage_TextChanged);
            //}
            
        }
    }
}
