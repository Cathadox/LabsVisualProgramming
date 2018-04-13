namespace Airport_Ispitna
{
    partial class dodadidestinacija
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcena = new System.Windows.Forms.TextBox();
            this.txtdolzina = new System.Windows.Forms.TextBox();
            this.btnotkazidestinacija = new System.Windows.Forms.Button();
            this.btndodadidestinacija = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtime = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcena);
            this.groupBox1.Controls.Add(this.txtdolzina);
            this.groupBox1.Controls.Add(this.btnotkazidestinacija);
            this.groupBox1.Controls.Add(this.btndodadidestinacija);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtime);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додади дестинација";
            // 
            // txtcena
            // 
            this.txtcena.Location = new System.Drawing.Point(9, 119);
            this.txtcena.Name = "txtcena";
            this.txtcena.Size = new System.Drawing.Size(111, 20);
            this.txtcena.TabIndex = 9;
            // 
            // txtdolzina
            // 
            this.txtdolzina.Location = new System.Drawing.Point(9, 81);
            this.txtdolzina.Name = "txtdolzina";
            this.txtdolzina.Size = new System.Drawing.Size(111, 20);
            this.txtdolzina.TabIndex = 8;
            // 
            // btnotkazidestinacija
            // 
            this.btnotkazidestinacija.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnotkazidestinacija.Location = new System.Drawing.Point(153, 145);
            this.btnotkazidestinacija.Name = "btnotkazidestinacija";
            this.btnotkazidestinacija.Size = new System.Drawing.Size(105, 23);
            this.btnotkazidestinacija.TabIndex = 7;
            this.btnotkazidestinacija.Text = "Откажи";
            this.btnotkazidestinacija.UseVisualStyleBackColor = true;
            this.btnotkazidestinacija.Click += new System.EventHandler(this.btnotkazidestinacija_Click);
            // 
            // btndodadidestinacija
            // 
            this.btndodadidestinacija.Location = new System.Drawing.Point(7, 145);
            this.btndodadidestinacija.Name = "btndodadidestinacija";
            this.btndodadidestinacija.Size = new System.Drawing.Size(113, 23);
            this.btndodadidestinacija.TabIndex = 6;
            this.btndodadidestinacija.Text = "Додади";
            this.btndodadidestinacija.UseVisualStyleBackColor = true;
            this.btndodadidestinacija.Click += new System.EventHandler(this.btndodadidestinacija_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Должина";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Име:";
            // 
            // txtime
            // 
            this.txtime.Location = new System.Drawing.Point(7, 34);
            this.txtime.Name = "txtime";
            this.txtime.Size = new System.Drawing.Size(251, 20);
            this.txtime.TabIndex = 0;
            // 
            // dodadidestinacija
            // 
            this.AcceptButton = this.btndodadidestinacija;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnotkazidestinacija;
            this.ClientSize = new System.Drawing.Size(311, 204);
            this.Controls.Add(this.groupBox1);
            this.Name = "dodadidestinacija";
            this.Text = "Нова дестинација";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnotkazidestinacija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtime;
        private System.Windows.Forms.TextBox txtcena;
        private System.Windows.Forms.TextBox txtdolzina;
        public System.Windows.Forms.Button btndodadidestinacija;
    }
}