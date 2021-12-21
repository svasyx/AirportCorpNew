
namespace AirportCorp
{
    partial class AdminForm
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
            this.btnprint = new System.Windows.Forms.Button();
            this.lbinfo_ab = new System.Windows.Forms.Label();
            this.btfis = new System.Windows.Forms.Button();
            this.btlog = new System.Windows.Forms.Button();
            this.btreg = new System.Windows.Forms.Button();
            this.tbalog = new System.Windows.Forms.TextBox();
            this.tbapass = new System.Windows.Forms.TextBox();
            this.lbida = new System.Windows.Forms.Label();
            this.ibpasa = new System.Windows.Forms.Label();
            this.panadm = new System.Windows.Forms.Panel();
            this.btsubmit = new System.Windows.Forms.Button();
            this.panwork = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.lbairports = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pnstart = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tblogin = new System.Windows.Forms.TextBox();
            this.tppassword = new System.Windows.Forms.TextBox();
            this.pnlogin = new System.Windows.Forms.Panel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.panadm.SuspendLayout();
            this.panwork.SuspendLayout();
            this.pnstart.SuspendLayout();
            this.pnlogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(33, 75);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(191, 23);
            this.btnprint.TabIndex = 7;
            this.btnprint.Text = "Вивести всіх співробітників:";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // lbinfo_ab
            // 
            this.lbinfo_ab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbinfo_ab.Location = new System.Drawing.Point(3, 158);
            this.lbinfo_ab.Name = "lbinfo_ab";
            this.lbinfo_ab.Size = new System.Drawing.Size(263, 104);
            this.lbinfo_ab.TabIndex = 8;
            this.lbinfo_ab.Text = "Всі робітники: ";
            // 
            // btfis
            // 
            this.btfis.Location = new System.Drawing.Point(33, 11);
            this.btfis.Margin = new System.Windows.Forms.Padding(2);
            this.btfis.Name = "btfis";
            this.btfis.Size = new System.Drawing.Size(191, 21);
            this.btfis.TabIndex = 10;
            this.btfis.Text = "Отримати всіх фізичних осіб: ";
            this.btfis.UseVisualStyleBackColor = true;
            this.btfis.Click += new System.EventHandler(this.button2_Click);
            // 
            // btlog
            // 
            this.btlog.Location = new System.Drawing.Point(7, 16);
            this.btlog.Name = "btlog";
            this.btlog.Size = new System.Drawing.Size(119, 46);
            this.btlog.TabIndex = 15;
            this.btlog.Text = "Login";
            this.btlog.UseVisualStyleBackColor = true;
            this.btlog.Click += new System.EventHandler(this.btlog_Click);
            // 
            // btreg
            // 
            this.btreg.Location = new System.Drawing.Point(132, 16);
            this.btreg.Name = "btreg";
            this.btreg.Size = new System.Drawing.Size(119, 46);
            this.btreg.TabIndex = 16;
            this.btreg.Text = "Registration";
            this.btreg.UseVisualStyleBackColor = true;
            this.btreg.Click += new System.EventHandler(this.btreg_Click);
            // 
            // tbalog
            // 
            this.tbalog.Location = new System.Drawing.Point(102, 12);
            this.tbalog.Name = "tbalog";
            this.tbalog.Size = new System.Drawing.Size(100, 20);
            this.tbalog.TabIndex = 17;
            // 
            // tbapass
            // 
            this.tbapass.Location = new System.Drawing.Point(102, 46);
            this.tbapass.Name = "tbapass";
            this.tbapass.Size = new System.Drawing.Size(100, 20);
            this.tbapass.TabIndex = 18;
            // 
            // lbida
            // 
            this.lbida.AutoSize = true;
            this.lbida.Location = new System.Drawing.Point(43, 19);
            this.lbida.Name = "lbida";
            this.lbida.Size = new System.Drawing.Size(37, 13);
            this.lbida.TabIndex = 19;
            this.lbida.Text = "Логін:";
            // 
            // ibpasa
            // 
            this.ibpasa.AutoSize = true;
            this.ibpasa.Location = new System.Drawing.Point(43, 46);
            this.ibpasa.Name = "ibpasa";
            this.ibpasa.Size = new System.Drawing.Size(48, 13);
            this.ibpasa.TabIndex = 20;
            this.ibpasa.Text = "Пароль:";
            // 
            // panadm
            // 
            this.panadm.Controls.Add(this.btsubmit);
            this.panadm.Controls.Add(this.ibpasa);
            this.panadm.Controls.Add(this.lbida);
            this.panadm.Controls.Add(this.tbapass);
            this.panadm.Controls.Add(this.tbalog);
            this.panadm.Location = new System.Drawing.Point(316, 12);
            this.panadm.Name = "panadm";
            this.panadm.Size = new System.Drawing.Size(234, 128);
            this.panadm.TabIndex = 22;
            this.panadm.Visible = false;
            // 
            // btsubmit
            // 
            this.btsubmit.Location = new System.Drawing.Point(88, 93);
            this.btsubmit.Name = "btsubmit";
            this.btsubmit.Size = new System.Drawing.Size(75, 23);
            this.btsubmit.TabIndex = 21;
            this.btsubmit.Text = "submit";
            this.btsubmit.UseVisualStyleBackColor = true;
            this.btsubmit.Click += new System.EventHandler(this.btsubmit_Click);
            // 
            // panwork
            // 
            this.panwork.AutoScroll = true;
            this.panwork.Controls.Add(this.button2);
            this.panwork.Controls.Add(this.lbairports);
            this.panwork.Controls.Add(this.button3);
            this.panwork.Controls.Add(this.btfis);
            this.panwork.Controls.Add(this.lbinfo_ab);
            this.panwork.Controls.Add(this.btnprint);
            this.panwork.Location = new System.Drawing.Point(32, 162);
            this.panwork.Name = "panwork";
            this.panwork.Size = new System.Drawing.Size(430, 276);
            this.panwork.TabIndex = 23;
            this.panwork.Visible = false;
            this.panwork.Paint += new System.Windows.Forms.PaintEventHandler(this.panwork_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Отримати всі чартерні рейси";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // lbairports
            // 
            this.lbairports.FormattingEnabled = true;
            this.lbairports.Location = new System.Drawing.Point(230, 110);
            this.lbairports.Name = "lbairports";
            this.lbairports.Size = new System.Drawing.Size(120, 30);
            this.lbairports.TabIndex = 12;
            this.lbairports.SelectedIndexChanged += new System.EventHandler(this.lbairports_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(33, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 36);
            this.button3.TabIndex = 11;
            this.button3.Text = "Вивести всіх працівників по аеропрту:";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // pnstart
            // 
            this.pnstart.Controls.Add(this.btreg);
            this.pnstart.Controls.Add(this.btlog);
            this.pnstart.Location = new System.Drawing.Point(47, 42);
            this.pnstart.Name = "pnstart";
            this.pnstart.Size = new System.Drawing.Size(263, 80);
            this.pnstart.TabIndex = 24;
            this.pnstart.Paint += new System.Windows.Forms.PaintEventHandler(this.pnstart_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Введіть логін:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Введіть пароль:";
            // 
            // tblogin
            // 
            this.tblogin.Location = new System.Drawing.Point(96, 12);
            this.tblogin.Name = "tblogin";
            this.tblogin.Size = new System.Drawing.Size(100, 20);
            this.tblogin.TabIndex = 27;
            // 
            // tppassword
            // 
            this.tppassword.Location = new System.Drawing.Point(96, 39);
            this.tppassword.Name = "tppassword";
            this.tppassword.Size = new System.Drawing.Size(100, 20);
            this.tppassword.TabIndex = 28;
            // 
            // pnlogin
            // 
            this.pnlogin.Controls.Add(this.btnlogin);
            this.pnlogin.Controls.Add(this.tppassword);
            this.pnlogin.Controls.Add(this.tblogin);
            this.pnlogin.Controls.Add(this.label7);
            this.pnlogin.Controls.Add(this.label6);
            this.pnlogin.Location = new System.Drawing.Point(562, 12);
            this.pnlogin.Name = "pnlogin";
            this.pnlogin.Size = new System.Drawing.Size(226, 131);
            this.pnlogin.TabIndex = 29;
            this.pnlogin.Visible = false;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(71, 86);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 29;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlogin);
            this.Controls.Add(this.pnstart);
            this.Controls.Add(this.panwork);
            this.Controls.Add(this.panadm);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panadm.ResumeLayout(false);
            this.panadm.PerformLayout();
            this.panwork.ResumeLayout(false);
            this.pnstart.ResumeLayout(false);
            this.pnlogin.ResumeLayout(false);
            this.pnlogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Label lbinfo_ab;
        private System.Windows.Forms.Button btfis;
        private System.Windows.Forms.Button btlog;
        private System.Windows.Forms.Button btreg;
        private System.Windows.Forms.TextBox tbalog;
        private System.Windows.Forms.TextBox tbapass;
        private System.Windows.Forms.Label lbida;
        private System.Windows.Forms.Label ibpasa;
        private System.Windows.Forms.Panel panadm;
        private System.Windows.Forms.Button btsubmit;
        private System.Windows.Forms.Panel panwork;
        private System.Windows.Forms.Panel pnstart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tblogin;
        private System.Windows.Forms.TextBox tppassword;
        private System.Windows.Forms.Panel pnlogin;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.ListBox lbairports;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}