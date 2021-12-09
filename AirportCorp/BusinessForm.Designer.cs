
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
            this.btSubmit = new System.Windows.Forms.Button();
            this.infolb = new System.Windows.Forms.Label();
            this.nametb = new System.Windows.Forms.TextBox();
            this.surtb = new System.Windows.Forms.TextBox();
            this.moneytb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbpeople = new System.Windows.Forms.Label();
            this.cball = new System.Windows.Forms.CheckBox();
            this.btclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(407, 244);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 23);
            this.btSubmit.TabIndex = 0;
            this.btSubmit.Text = "Submit";
            this.btSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // infolb
            // 
            this.infolb.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.infolb.Location = new System.Drawing.Point(1, 341);
            this.infolb.Name = "infolb";
            this.infolb.Size = new System.Drawing.Size(802, 113);
            this.infolb.TabIndex = 2;
            this.infolb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.infolb.Click += new System.EventHandler(this.infolb_Click);
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(396, 141);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(100, 20);
            this.nametb.TabIndex = 3;
            // 
            // surtb
            // 
            this.surtb.Location = new System.Drawing.Point(396, 167);
            this.surtb.Name = "surtb";
            this.surtb.Size = new System.Drawing.Size(100, 20);
            this.surtb.TabIndex = 3;
            // 
            // moneytb
            // 
            this.moneytb.Location = new System.Drawing.Point(396, 193);
            this.moneytb.Name = "moneytb";
            this.moneytb.Size = new System.Drawing.Size(100, 20);
            this.moneytb.TabIndex = 3;
            this.moneytb.TextChanged += new System.EventHandler(this.moneytb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter surname";
            // 
            // cbpeople
            // 
            this.cbpeople.AutoSize = true;
            this.cbpeople.Location = new System.Drawing.Point(273, 196);
            this.cbpeople.Name = "cbpeople";
            this.cbpeople.Size = new System.Drawing.Size(109, 13);
            this.cbpeople.TabIndex = 4;
            this.cbpeople.Text = "Enter count of people";
            this.cbpeople.Click += new System.EventHandler(this.label3_Click);
            // 
            // cball
            // 
            this.cball.AutoSize = true;
            this.cball.Location = new System.Drawing.Point(343, 222);
            this.cball.Name = "cball";
            this.cball.Size = new System.Drawing.Size(131, 17);
            this.cball.TabIndex = 5;
            this.cball.Text = "Замовити весь літак";
            this.cball.UseVisualStyleBackColor = true;
            // 
            // btclose
            // 
            this.btclose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btclose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btclose.Location = new System.Drawing.Point(768, 12);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(19, 20);
            this.btclose.TabIndex = 7;
            this.btclose.Text = "X";
            this.btclose.UseVisualStyleBackColor = false;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // BusinessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btclose);
            this.Controls.Add(this.cball);
            this.Controls.Add(this.cbpeople);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moneytb);
            this.Controls.Add(this.surtb);
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.infolb);
            this.Controls.Add(this.btSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BusinessForm";
            this.Text = "BusinessForm";
            this.Load += new System.EventHandler(this.BusinessForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Label infolb;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.TextBox surtb;
        private System.Windows.Forms.TextBox moneytb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cbpeople;
        private System.Windows.Forms.CheckBox cball;
        private System.Windows.Forms.Button btclose;
    }
}