namespace Pregled
{
    partial class NewMessage
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
            this.txtmessage = new System.Windows.Forms.RichTextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtmessage
            // 
            this.txtmessage.Location = new System.Drawing.Point(12, 12);
            this.txtmessage.MaxLength = 60;
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.Size = new System.Drawing.Size(333, 212);
            this.txtmessage.TabIndex = 0;
            this.txtmessage.Text = "";
            this.txtmessage.TextChanged += new System.EventHandler(this.txtmessage_TextChanged);
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(142, 230);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(105, 44);
            this.btnsend.TabIndex = 1;
            this.btnsend.Text = "SEND";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(253, 231);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(92, 44);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(48, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // NewMessage
            // 
            this.AcceptButton = this.btnsend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btncancel;
            this.ClientSize = new System.Drawing.Size(357, 279);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.txtmessage);
            this.KeyPreview = true;
            this.Name = "NewMessage";
            this.Text = "NewMessage";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewMessage_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtmessage;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label label1;
    }
}