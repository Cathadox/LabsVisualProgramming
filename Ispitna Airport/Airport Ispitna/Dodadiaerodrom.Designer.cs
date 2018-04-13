namespace Airport_Ispitna
{
    partial class Dodadiaerodrom
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnotkaziaerodrom = new System.Windows.Forms.Button();
            this.btnzacuvajaerodrom = new System.Windows.Forms.Button();
            this.txtkratenka = new System.Windows.Forms.TextBox();
            this.txtime = new System.Windows.Forms.TextBox();
            this.txtgrad = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnotkaziaerodrom);
            this.groupBox1.Controls.Add(this.btnzacuvajaerodrom);
            this.groupBox1.Controls.Add(this.txtkratenka);
            this.groupBox1.Controls.Add(this.txtime);
            this.groupBox1.Controls.Add(this.txtgrad);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додади аеродром";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Кратенка:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Име:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Град:";
            // 
            // btnotkaziaerodrom
            // 
            this.btnotkaziaerodrom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnotkaziaerodrom.Location = new System.Drawing.Point(140, 162);
            this.btnotkaziaerodrom.Name = "btnotkaziaerodrom";
            this.btnotkaziaerodrom.Size = new System.Drawing.Size(127, 23);
            this.btnotkaziaerodrom.TabIndex = 4;
            this.btnotkaziaerodrom.Text = "Откажи";
            this.btnotkaziaerodrom.UseVisualStyleBackColor = true;
            this.btnotkaziaerodrom.Click += new System.EventHandler(this.btnotkaziaerodrom_Click);
            // 
            // btnzacuvajaerodrom
            // 
            this.btnzacuvajaerodrom.Location = new System.Drawing.Point(6, 162);
            this.btnzacuvajaerodrom.Name = "btnzacuvajaerodrom";
            this.btnzacuvajaerodrom.Size = new System.Drawing.Size(128, 23);
            this.btnzacuvajaerodrom.TabIndex = 3;
            this.btnzacuvajaerodrom.Text = "Зачувај";
            this.btnzacuvajaerodrom.UseVisualStyleBackColor = true;
            this.btnzacuvajaerodrom.Click += new System.EventHandler(this.btnzacuvajaerodrom_Click);
            // 
            // txtkratenka
            // 
            this.txtkratenka.Location = new System.Drawing.Point(6, 128);
            this.txtkratenka.Name = "txtkratenka";
            this.txtkratenka.Size = new System.Drawing.Size(128, 20);
            this.txtkratenka.TabIndex = 2;
            // 
            // txtime
            // 
            this.txtime.Location = new System.Drawing.Point(6, 85);
            this.txtime.Name = "txtime";
            this.txtime.Size = new System.Drawing.Size(261, 20);
            this.txtime.TabIndex = 1;
            this.txtime.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtgrad
            // 
            this.txtgrad.Location = new System.Drawing.Point(6, 38);
            this.txtgrad.Name = "txtgrad";
            this.txtgrad.Size = new System.Drawing.Size(261, 20);
            this.txtgrad.TabIndex = 0;
            // 
            // Dodadiaerodrom
            // 
            this.AcceptButton = this.btnzacuvajaerodrom;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnotkaziaerodrom;
            this.ClientSize = new System.Drawing.Size(320, 224);
            this.Controls.Add(this.groupBox1);
            this.Name = "Dodadiaerodrom";
            this.Text = "Нов аеродром";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtime;
        private System.Windows.Forms.TextBox txtgrad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnotkaziaerodrom;
        private System.Windows.Forms.TextBox txtkratenka;
        public System.Windows.Forms.Button btnzacuvajaerodrom;
    }
}