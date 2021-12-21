
namespace AirportCorp
{
    partial class BusinessForm
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
            this.tbreg = new System.Windows.Forms.TabControl();
            this.tbrev = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cball = new System.Windows.Forms.CheckBox();
            this.cbpeople = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.moneytb = new System.Windows.Forms.TextBox();
            this.surtb = new System.Windows.Forms.TextBox();
            this.nametb = new System.Windows.Forms.TextBox();
            this.btSubmit = new System.Windows.Forms.Button();
            this.lbinfo = new System.Windows.Forms.Label();
            this.tbreg.SuspendLayout();
            this.tbrev.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbreg
            // 
            this.tbreg.Controls.Add(this.tbrev);
            this.tbreg.Controls.Add(this.tabPage2);
            this.tbreg.Location = new System.Drawing.Point(12, 12);
            this.tbreg.Name = "tbreg";
            this.tbreg.SelectedIndex = 0;
            this.tbreg.Size = new System.Drawing.Size(750, 412);
            this.tbreg.TabIndex = 23;
            // 
            // tbrev
            // 
            this.tbrev.Controls.Add(this.cball);
            this.tbrev.Controls.Add(this.cbpeople);
            this.tbrev.Controls.Add(this.label2);
            this.tbrev.Controls.Add(this.label1);
            this.tbrev.Controls.Add(this.moneytb);
            this.tbrev.Controls.Add(this.surtb);
            this.tbrev.Controls.Add(this.nametb);
            this.tbrev.Controls.Add(this.btSubmit);
            this.tbrev.Location = new System.Drawing.Point(4, 22);
            this.tbrev.Name = "tbrev";
            this.tbrev.Padding = new System.Windows.Forms.Padding(3);
            this.tbrev.Size = new System.Drawing.Size(742, 386);
            this.tbrev.TabIndex = 0;
            this.tbrev.Text = "Реєстрація";
            this.tbrev.UseVisualStyleBackColor = true;
            this.tbrev.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbinfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(742, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Інформація про замовлення";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // cball
            // 
            this.cball.AutoSize = true;
            this.cball.Location = new System.Drawing.Point(199, 196);
            this.cball.Name = "cball";
            this.cball.Size = new System.Drawing.Size(131, 17);
            this.cball.TabIndex = 29;
            this.cball.Text = "Замовити весь літак";
            this.cball.UseVisualStyleBackColor = true;
            // 
            // cbpeople
            // 
            this.cbpeople.AutoSize = true;
            this.cbpeople.Location = new System.Drawing.Point(149, 170);
            this.cbpeople.Name = "cbpeople";
            this.cbpeople.Size = new System.Drawing.Size(97, 13);
            this.cbpeople.TabIndex = 26;
            this.cbpeople.Text = "Введіть к-сть осіб";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Введіть прізвище";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Введіть ім\'я:";
            // 
            // moneytb
            // 
            this.moneytb.Location = new System.Drawing.Point(252, 167);
            this.moneytb.Name = "moneytb";
            this.moneytb.Size = new System.Drawing.Size(100, 20);
            this.moneytb.TabIndex = 23;
            // 
            // surtb
            // 
            this.surtb.Location = new System.Drawing.Point(252, 141);
            this.surtb.Name = "surtb";
            this.surtb.Size = new System.Drawing.Size(100, 20);
            this.surtb.TabIndex = 24;
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(252, 115);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(100, 20);
            this.nametb.TabIndex = 25;
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(199, 228);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(132, 23);
            this.btSubmit.TabIndex = 22;
            this.btSubmit.Text = "Створити замовлення";
            this.btSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click_2);
            // 
            // lbinfo
            // 
            this.lbinfo.Location = new System.Drawing.Point(6, 3);
            this.lbinfo.Name = "lbinfo";
            this.lbinfo.Size = new System.Drawing.Size(733, 380);
            this.lbinfo.TabIndex = 0;
            this.lbinfo.Text = "Інформація про замовлення:";
            // 
            // BusinessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbreg);
            this.Name = "BusinessForm";
            this.Text = "BusinessForm";
            this.Load += new System.EventHandler(this.BusinessForm_Load);
            this.tbreg.ResumeLayout(false);
            this.tbrev.ResumeLayout(false);
            this.tbrev.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbreg;
        private System.Windows.Forms.TabPage tbrev;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox cball;
        private System.Windows.Forms.Label cbpeople;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox moneytb;
        private System.Windows.Forms.TextBox surtb;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Label lbinfo;
    }
}