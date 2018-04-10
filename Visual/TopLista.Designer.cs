namespace WindowsFormsApp5
{
    partial class TopLista
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
            this.btnok = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(0, 292);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(372, 33);
            this.btnok.TabIndex = 1;
            this.btnok.Text = "Плаче ми се";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(348, 264);
            this.listBox1.TabIndex = 2;
            // 
            // TopLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 337);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnok);
            this.Name = "TopLista";
            this.Text = "TopLista";
            this.Load += new System.EventHandler(this.TopLista_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.ListBox listBox1;
    }
}