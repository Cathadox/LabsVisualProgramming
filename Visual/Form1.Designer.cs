namespace WindowsFormsApp5
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
            this.components = new System.ComponentModel.Container();
            this.txtplayername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbpoints = new System.Windows.Forms.ProgressBar();
            this.btnnew = new System.Windows.Forms.Button();
            this.txtvalue1 = new System.Windows.Forms.TextBox();
            this.txtoperation = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btnbest = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.pbtime = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.txtvalue2 = new System.Windows.Forms.TextBox();
            this.btnguess = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.lblpoints = new System.Windows.Forms.Label();
            this.Tiker = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtplayername
            // 
            this.txtplayername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtplayername.Location = new System.Drawing.Point(83, 28);
            this.txtplayername.Name = "txtplayername";
            this.txtplayername.Size = new System.Drawing.Size(184, 27);
            this.txtplayername.TabIndex = 0;
            this.txtplayername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Играч:";
            // 
            // pbpoints
            // 
            this.pbpoints.Location = new System.Drawing.Point(8, 160);
            this.pbpoints.Name = "pbpoints";
            this.pbpoints.Size = new System.Drawing.Size(729, 45);
            this.pbpoints.TabIndex = 2;
            // 
            // btnnew
            // 
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnnew.Location = new System.Drawing.Point(12, 325);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(133, 52);
            this.btnnew.TabIndex = 3;
            this.btnnew.Text = "Нова игра";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // txtvalue1
            // 
            this.txtvalue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtvalue1.Location = new System.Drawing.Point(16, 79);
            this.txtvalue1.Name = "txtvalue1";
            this.txtvalue1.ReadOnly = true;
            this.txtvalue1.Size = new System.Drawing.Size(147, 27);
            this.txtvalue1.TabIndex = 5;
            // 
            // txtoperation
            // 
            this.txtoperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtoperation.Location = new System.Drawing.Point(202, 81);
            this.txtoperation.Name = "txtoperation";
            this.txtoperation.ReadOnly = true;
            this.txtoperation.Size = new System.Drawing.Size(50, 27);
            this.txtoperation.TabIndex = 6;
            // 
            // txtresult
            // 
            this.txtresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtresult.Location = new System.Drawing.Point(525, 81);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(100, 27);
            this.txtresult.TabIndex = 7;
            // 
            // btnbest
            // 
            this.btnbest.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnbest.Location = new System.Drawing.Point(311, 325);
            this.btnbest.Name = "btnbest";
            this.btnbest.Size = new System.Drawing.Size(133, 52);
            this.btnbest.TabIndex = 8;
            this.btnbest.Text = "Најдобри играчи";
            this.btnbest.UseVisualStyleBackColor = true;
            this.btnbest.Click += new System.EventHandler(this.btnbest_Click);
            // 
            // btnexit
            // 
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnexit.Location = new System.Drawing.Point(604, 325);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(133, 52);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "Исклучи";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // pbtime
            // 
            this.pbtime.Location = new System.Drawing.Point(8, 247);
            this.pbtime.Name = "pbtime";
            this.pbtime.Size = new System.Drawing.Size(729, 45);
            this.pbtime.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(472, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "=";
            // 
            // txtvalue2
            // 
            this.txtvalue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtvalue2.Location = new System.Drawing.Point(297, 79);
            this.txtvalue2.Name = "txtvalue2";
            this.txtvalue2.ReadOnly = true;
            this.txtvalue2.Size = new System.Drawing.Size(147, 27);
            this.txtvalue2.TabIndex = 12;
            // 
            // btnguess
            // 
            this.btnguess.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnguess.Location = new System.Drawing.Point(657, 72);
            this.btnguess.Name = "btnguess";
            this.btnguess.Size = new System.Drawing.Size(80, 40);
            this.btnguess.TabIndex = 13;
            this.btnguess.Text = "Погоди";
            this.btnguess.UseVisualStyleBackColor = true;
            this.btnguess.Click += new System.EventHandler(this.btnguess_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Поени:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(12, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Преостанато време: ";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbltime.Location = new System.Drawing.Point(227, 222);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(0, 22);
            this.lbltime.TabIndex = 16;
            // 
            // lblpoints
            // 
            this.lblpoints.AutoSize = true;
            this.lblpoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblpoints.Location = new System.Drawing.Point(111, 135);
            this.lblpoints.Name = "lblpoints";
            this.lblpoints.Size = new System.Drawing.Size(0, 22);
            this.lblpoints.TabIndex = 17;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnguess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnexit;
            this.ClientSize = new System.Drawing.Size(749, 405);
            this.Controls.Add(this.lblpoints);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnguess);
            this.Controls.Add(this.txtvalue2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbtime);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnbest);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtoperation);
            this.Controls.Add(this.txtvalue1);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.pbpoints);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtplayername);
            this.Name = "Form1";
            this.Text = "Math Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtplayername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbpoints;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.TextBox txtvalue1;
        private System.Windows.Forms.TextBox txtoperation;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btnbest;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ProgressBar pbtime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtvalue2;
        private System.Windows.Forms.Button btnguess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lblpoints;
        private System.Windows.Forms.Timer Tiker;
    }
}

