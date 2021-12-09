
namespace AirportCorp
{
    partial class TravelRegForm
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
            this.cbvisa = new System.Windows.Forms.CheckBox();
            this.cblaggage = new System.Windows.Forms.CheckBox();
            this.lbtime = new System.Windows.Forms.Label();
            this.lbinfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbtime = new System.Windows.Forms.TextBox();
            this.tbsurnm = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.Submit_button = new System.Windows.Forms.Button();
            this.lbfrom = new System.Windows.Forms.ListBox();
            this.lbto = new System.Windows.Forms.ListBox();
            this.dtfrom = new System.Windows.Forms.DateTimePicker();
            this.dtback = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbvisa
            // 
            this.cbvisa.AutoSize = true;
            this.cbvisa.Location = new System.Drawing.Point(11, 197);
            this.cbvisa.Margin = new System.Windows.Forms.Padding(2);
            this.cbvisa.Name = "cbvisa";
            this.cbvisa.Size = new System.Drawing.Size(103, 17);
            this.cbvisa.TabIndex = 36;
            this.cbvisa.Text = "Наявність візи:";
            this.cbvisa.UseVisualStyleBackColor = true;
            this.cbvisa.CheckedChanged += new System.EventHandler(this.cbvisa_CheckedChanged);
            // 
            // cblaggage
            // 
            this.cblaggage.AutoSize = true;
            this.cblaggage.Location = new System.Drawing.Point(11, 176);
            this.cblaggage.Margin = new System.Windows.Forms.Padding(2);
            this.cblaggage.Name = "cblaggage";
            this.cblaggage.Size = new System.Drawing.Size(122, 17);
            this.cblaggage.TabIndex = 35;
            this.cblaggage.Text = "Квиток з багажом ";
            this.cblaggage.UseVisualStyleBackColor = true;
            // 
            // lbtime
            // 
            this.lbtime.AutoSize = true;
            this.lbtime.Location = new System.Drawing.Point(136, 198);
            this.lbtime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(154, 13);
            this.lbtime.TabIndex = 34;
            this.lbtime.Text = "Введіть тривалість подорожі:";
            // 
            // lbinfo
            // 
            this.lbinfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbinfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbinfo.Location = new System.Drawing.Point(601, 13);
            this.lbinfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbinfo.Name = "lbinfo";
            this.lbinfo.Size = new System.Drawing.Size(282, 510);
            this.lbinfo.TabIndex = 33;
            this.lbinfo.Text = "Ваш квиток: ";
            this.lbinfo.Click += new System.EventHandler(this.lbinfo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Введіть напрям:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Прізвище";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ім\'я";
            // 
            // tbtime
            // 
            this.tbtime.Location = new System.Drawing.Point(297, 194);
            this.tbtime.Margin = new System.Windows.Forms.Padding(2);
            this.tbtime.Name = "tbtime";
            this.tbtime.Size = new System.Drawing.Size(76, 20);
            this.tbtime.TabIndex = 28;
            // 
            // tbsurnm
            // 
            this.tbsurnm.Location = new System.Drawing.Point(104, 100);
            this.tbsurnm.Margin = new System.Windows.Forms.Padding(2);
            this.tbsurnm.Name = "tbsurnm";
            this.tbsurnm.Size = new System.Drawing.Size(76, 20);
            this.tbsurnm.TabIndex = 27;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(104, 66);
            this.tbname.Margin = new System.Windows.Forms.Padding(2);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(76, 20);
            this.tbname.TabIndex = 26;
            // 
            // Submit_button
            // 
            this.Submit_button.Location = new System.Drawing.Point(315, 280);
            this.Submit_button.Margin = new System.Windows.Forms.Padding(2);
            this.Submit_button.Name = "Submit_button";
            this.Submit_button.Size = new System.Drawing.Size(102, 24);
            this.Submit_button.TabIndex = 25;
            this.Submit_button.Text = "Submit";
            this.Submit_button.UseVisualStyleBackColor = true;
            this.Submit_button.Click += new System.EventHandler(this.Submit_button_Click);
            // 
            // lbfrom
            // 
            this.lbfrom.FormattingEnabled = true;
            this.lbfrom.Location = new System.Drawing.Point(277, 69);
            this.lbfrom.Name = "lbfrom";
            this.lbfrom.Size = new System.Drawing.Size(120, 30);
            this.lbfrom.TabIndex = 38;
            this.lbfrom.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbto
            // 
            this.lbto.FormattingEnabled = true;
            this.lbto.Location = new System.Drawing.Point(417, 69);
            this.lbto.Name = "lbto";
            this.lbto.Size = new System.Drawing.Size(120, 30);
            this.lbto.TabIndex = 40;
            this.lbto.SelectedIndexChanged += new System.EventHandler(this.lbto_SelectedIndexChanged);
            // 
            // dtfrom
            // 
            this.dtfrom.Location = new System.Drawing.Point(148, 248);
            this.dtfrom.Name = "dtfrom";
            this.dtfrom.Size = new System.Drawing.Size(200, 20);
            this.dtfrom.TabIndex = 41;
            // 
            // dtback
            // 
            this.dtback.Location = new System.Drawing.Point(369, 248);
            this.dtback.Name = "dtback";
            this.dtback.Size = new System.Drawing.Size(200, 20);
            this.dtback.TabIndex = 42;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(888, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 43;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TravelRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(930, 586);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtback);
            this.Controls.Add(this.dtfrom);
            this.Controls.Add(this.lbto);
            this.Controls.Add(this.lbfrom);
            this.Controls.Add(this.cbvisa);
            this.Controls.Add(this.cblaggage);
            this.Controls.Add(this.lbtime);
            this.Controls.Add(this.lbinfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbtime);
            this.Controls.Add(this.tbsurnm);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.Submit_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TravelRegForm";
            this.Text = "TravelRegForm";
            this.Load += new System.EventHandler(this.TravelRegForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbvisa;
        private System.Windows.Forms.CheckBox cblaggage;
        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.Label lbinfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbtime;
        private System.Windows.Forms.TextBox tbsurnm;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Button Submit_button;
        private System.Windows.Forms.ListBox lbfrom;
        private System.Windows.Forms.ListBox lbto;
        private System.Windows.Forms.DateTimePicker dtfrom;
        private System.Windows.Forms.DateTimePicker dtback;
        private System.Windows.Forms.Button button1;
    }
}