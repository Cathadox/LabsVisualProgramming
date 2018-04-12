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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnaddcontact_Click(object sender, EventArgs e)
        {
            Contacts contact = new Contacts(txtname.Text, maskednumber.Text);
            contactlist.Items.Add(contact);
            txtname.Text = null;
            maskednumber.Text = null;
            con.Add(contact);
        }
        public void ShowMessages()
        {
            messagelist.Items.Clear();
            Contacts c = contactlist.SelectedItem as Contacts;
            if(contactlist.SelectedItem!=null && c.Messages.Count>0)
            {
                foreach(string m in c.Messages)
                {
                    messagelist.Items.Add(m);
                }
            }
        }
        List<Contacts> con = new List<Contacts>();
        private void btnmessage_Click(object sender, EventArgs e)
        {
            NewMessage form = new NewMessage();
            if(form.ShowDialog()==DialogResult.OK)
            {
                Contacts c = contactlist.SelectedItem as Contacts;
                c.newMessage(form.Message);
            }
            ShowMessages();
        }

        private void contactlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowMessages();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            ShowContacts();
        }
        public void ShowContacts()
        {
            contactlist.Items.Clear();
            if(txtsearch.Text != null)
            foreach(Contacts c in con)
            {
                    if (c.Name.Equals(txtsearch.Text.Trim()))
                        contactlist.Items.Add(c);
            }
            else
            {
                foreach(Contacts c in con)
                {
                    contactlist.Items.Add(c);
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }
    }
}
