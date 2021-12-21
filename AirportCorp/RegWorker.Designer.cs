
namespace AirportCorp
{
    partial class RegWorker
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
            this.panreg = new System.Windows.Forms.Panel();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.tbsrname = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.lbairport = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panreg.SuspendLayout();
            this.SuspendLayout();
            // 
            // panreg
            // 
            this.panreg.Controls.Add(this.tbpass);
            this.panreg.Controls.Add(this.label5);
            this.panreg.Controls.Add(this.label4);
            this.panreg.Controls.Add(this.tbid);
            this.panreg.Controls.Add(this.btnsubmit);
            this.panreg.Controls.Add(this.tbsrname);
            this.panreg.Controls.Add(this.tbname);
            this.panreg.Controls.Add(this.lbairport);
            this.panreg.Controls.Add(this.label3);
            this.panreg.Controls.Add(this.label2);
            this.panreg.Controls.Add(this.label1);
            this.panreg.Location = new System.Drawing.Point(251, 117);
            this.panreg.Name = "panreg";
            this.panreg.Size = new System.Drawing.Size(298, 216);
            this.panreg.TabIndex = 22;
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(140, 153);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(119, 20);
            this.tbpass.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Введіть пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Введіть унікальний ID:";
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(140, 121);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(120, 20);
            this.tbid.TabIndex = 11;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(106, 179);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(80, 23);
            this.btnsubmit.TabIndex = 6;
            this.btnsubmit.Text = "Підтвердити";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // tbsrname
            // 
            this.tbsrname.Location = new System.Drawing.Point(140, 94);
            this.tbsrname.Name = "tbsrname";
            this.tbsrname.Size = new System.Drawing.Size(120, 20);
            this.tbsrname.TabIndex = 5;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(140, 60);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(120, 20);
            this.tbname.TabIndex = 4;
            // 
            // lbairport
            // 
            this.lbairport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbairport.FormattingEnabled = true;
            this.lbairport.Location = new System.Drawing.Point(140, 25);
            this.lbairport.Name = "lbairport";
            this.lbairport.Size = new System.Drawing.Size(119, 13);
            this.lbairport.TabIndex = 3;
            this.lbairport.SelectedIndexChanged += new System.EventHandler(this.lbairport_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Прізвище";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ім\'я";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Виберіть аеропорт:";
            // 
            // RegWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panreg);
            this.Name = "RegWorker";
            this.Text = "RegWorker";
            this.Load += new System.EventHandler(this.RegWorker_Load);
            this.panreg.ResumeLayout(false);
            this.panreg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panreg;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.TextBox tbsrname;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.ListBox lbairport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}