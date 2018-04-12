namespace Pregled
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contactlist = new System.Windows.Forms.ListBox();
            this.messagelist = new System.Windows.Forms.ListBox();
            this.btnaddcontact = new System.Windows.Forms.Button();
            this.maskednumber = new System.Windows.Forms.MaskedTextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnmessage = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // contactlist
            // 
            this.contactlist.FormattingEnabled = true;
            this.contactlist.Location = new System.Drawing.Point(12, 44);
            this.contactlist.Name = "contactlist";
            this.contactlist.Size = new System.Drawing.Size(241, 303);
            this.contactlist.TabIndex = 0;
            this.contactlist.SelectedIndexChanged += new System.EventHandler(this.contactlist_SelectedIndexChanged);
            // 
            // messagelist
            // 
            this.messagelist.FormattingEnabled = true;
            this.messagelist.Location = new System.Drawing.Point(285, 12);
            this.messagelist.Name = "messagelist";
            this.messagelist.Size = new System.Drawing.Size(523, 511);
            this.messagelist.TabIndex = 1;
            // 
            // btnaddcontact
            // 
            this.btnaddcontact.Location = new System.Drawing.Point(12, 438);
            this.btnaddcontact.Name = "btnaddcontact";
            this.btnaddcontact.Size = new System.Drawing.Size(241, 33);
            this.btnaddcontact.TabIndex = 2;
            this.btnaddcontact.Text = "New Contact";
            this.btnaddcontact.UseVisualStyleBackColor = true;
            this.btnaddcontact.Click += new System.EventHandler(this.btnaddcontact_Click);
            // 
            // maskednumber
            // 
            this.maskednumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.maskednumber.Location = new System.Drawing.Point(12, 353);
            this.maskednumber.Mask = "(999) 000-000";
            this.maskednumber.Name = "maskednumber";
            this.maskednumber.Size = new System.Drawing.Size(241, 27);
            this.maskednumber.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtname.Location = new System.Drawing.Point(12, 405);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(241, 27);
            this.txtname.TabIndex = 4;
            // 
            // btnmessage
            // 
            this.btnmessage.Location = new System.Drawing.Point(12, 498);
            this.btnmessage.Name = "btnmessage";
            this.btnmessage.Size = new System.Drawing.Size(241, 30);
            this.btnmessage.TabIndex = 5;
            this.btnmessage.Text = "New Message";
            this.btnmessage.UseVisualStyleBackColor = true;
            this.btnmessage.Click += new System.EventHandler(this.btnmessage_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtsearch.Location = new System.Drawing.Point(12, 12);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(240, 27);
            this.txtsearch.TabIndex = 6;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnaddcontact;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 540);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnmessage);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.maskednumber);
            this.Controls.Add(this.btnaddcontact);
            this.Controls.Add(this.messagelist);
            this.Controls.Add(this.contactlist);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Messages";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox contactlist;
        private System.Windows.Forms.ListBox messagelist;
        private System.Windows.Forms.Button btnaddcontact;
        private System.Windows.Forms.MaskedTextBox maskednumber;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnmessage;
        private System.Windows.Forms.TextBox txtsearch;
    }
}

