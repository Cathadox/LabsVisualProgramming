namespace Airport_Ispitna
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbaerodromi = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbdestinacii = new System.Windows.Forms.ListBox();
            this.btndodadiaerodrom = new System.Windows.Forms.Button();
            this.btnbrisiaerodrom = new System.Windows.Forms.Button();
            this.btnbrisidestinacija = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsrednadolzina = new System.Windows.Forms.TextBox();
            this.txtskapo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbaerodromi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Аеродроми";
            // 
            // lbaerodromi
            // 
            this.lbaerodromi.FormattingEnabled = true;
            this.lbaerodromi.Location = new System.Drawing.Point(6, 16);
            this.lbaerodromi.Name = "lbaerodromi";
            this.lbaerodromi.Size = new System.Drawing.Size(273, 290);
            this.lbaerodromi.TabIndex = 0;
            this.lbaerodromi.SelectedIndexChanged += new System.EventHandler(this.lbaerodromi_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbdestinacii);
            this.groupBox2.Location = new System.Drawing.Point(303, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 312);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дестинации";
            // 
            // lbdestinacii
            // 
            this.lbdestinacii.FormattingEnabled = true;
            this.lbdestinacii.Location = new System.Drawing.Point(10, 16);
            this.lbdestinacii.Name = "lbdestinacii";
            this.lbdestinacii.Size = new System.Drawing.Size(273, 290);
            this.lbdestinacii.TabIndex = 1;
            // 
            // btndodadiaerodrom
            // 
            this.btndodadiaerodrom.Location = new System.Drawing.Point(18, 337);
            this.btndodadiaerodrom.Name = "btndodadiaerodrom";
            this.btndodadiaerodrom.Size = new System.Drawing.Size(279, 22);
            this.btndodadiaerodrom.TabIndex = 2;
            this.btndodadiaerodrom.Text = "Додади аеродром";
            this.btndodadiaerodrom.UseVisualStyleBackColor = true;
            this.btndodadiaerodrom.Click += new System.EventHandler(this.btndodadiaerodrom_Click);
            // 
            // btnbrisiaerodrom
            // 
            this.btnbrisiaerodrom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnbrisiaerodrom.Location = new System.Drawing.Point(18, 383);
            this.btnbrisiaerodrom.Name = "btnbrisiaerodrom";
            this.btnbrisiaerodrom.Size = new System.Drawing.Size(279, 22);
            this.btnbrisiaerodrom.TabIndex = 3;
            this.btnbrisiaerodrom.Text = "Избриши аеродром";
            this.btnbrisiaerodrom.UseVisualStyleBackColor = true;
            this.btnbrisiaerodrom.Click += new System.EventHandler(this.btnbrisiaerodrom_Click);
            // 
            // btnbrisidestinacija
            // 
            this.btnbrisidestinacija.Location = new System.Drawing.Point(18, 429);
            this.btnbrisidestinacija.Name = "btnbrisidestinacija";
            this.btnbrisidestinacija.Size = new System.Drawing.Size(279, 22);
            this.btnbrisidestinacija.TabIndex = 4;
            this.btnbrisidestinacija.Text = "Додади дестинација";
            this.btnbrisidestinacija.UseVisualStyleBackColor = true;
            this.btnbrisidestinacija.Click += new System.EventHandler(this.btnbrisidestinacija_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtsrednadolzina);
            this.groupBox3.Controls.Add(this.txtskapo);
            this.groupBox3.Location = new System.Drawing.Point(313, 331);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 120);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Дестинации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Просечна должина на дестинациите";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Најскапа дестинација";
            // 
            // txtsrednadolzina
            // 
            this.txtsrednadolzina.Location = new System.Drawing.Point(6, 79);
            this.txtsrednadolzina.Name = "txtsrednadolzina";
            this.txtsrednadolzina.ReadOnly = true;
            this.txtsrednadolzina.Size = new System.Drawing.Size(271, 20);
            this.txtsrednadolzina.TabIndex = 1;
            this.txtsrednadolzina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtskapo
            // 
            this.txtskapo.Location = new System.Drawing.Point(6, 37);
            this.txtskapo.Name = "txtskapo";
            this.txtskapo.ReadOnly = true;
            this.txtskapo.Size = new System.Drawing.Size(271, 20);
            this.txtskapo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AcceptButton = this.btndodadiaerodrom;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnbrisiaerodrom;
            this.ClientSize = new System.Drawing.Size(608, 467);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnbrisidestinacija);
            this.Controls.Add(this.btnbrisiaerodrom);
            this.Controls.Add(this.btndodadiaerodrom);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Аеродроми";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btndodadiaerodrom;
        private System.Windows.Forms.Button btnbrisiaerodrom;
        private System.Windows.Forms.Button btnbrisidestinacija;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsrednadolzina;
        private System.Windows.Forms.TextBox txtskapo;
        public System.Windows.Forms.ListBox lbaerodromi;
        public System.Windows.Forms.ListBox lbdestinacii;
    }
}

