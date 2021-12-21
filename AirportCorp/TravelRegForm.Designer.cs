
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravelRegForm));
            this.cbvisa = new System.Windows.Forms.CheckBox();
            this.cblaggage = new System.Windows.Forms.CheckBox();
            this.lbinfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbsurnm = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.Submit_button = new System.Windows.Forms.Button();
            this.lbfrom = new System.Windows.Forms.ListBox();
            this.lbto = new System.Windows.Forms.ListBox();
            this.dtfrom = new System.Windows.Forms.DateTimePicker();
            this.dtback = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbvisa
            // 
            this.cbvisa.AutoSize = true;
            this.cbvisa.Location = new System.Drawing.Point(595, 129);
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
            this.cblaggage.Location = new System.Drawing.Point(595, 150);
            this.cblaggage.Margin = new System.Windows.Forms.Padding(2);
            this.cblaggage.Name = "cblaggage";
            this.cblaggage.Size = new System.Drawing.Size(122, 17);
            this.cblaggage.TabIndex = 35;
            this.cblaggage.Text = "Квиток з багажом ";
            this.cblaggage.UseVisualStyleBackColor = true;
            // 
            // lbinfo
            // 
            this.lbinfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbinfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbinfo.Location = new System.Drawing.Point(427, 363);
            this.lbinfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbinfo.Name = "lbinfo";
            this.lbinfo.Size = new System.Drawing.Size(282, 214);
            this.lbinfo.TabIndex = 33;
            this.lbinfo.Text = "Ваш квиток: ";
            this.lbinfo.Click += new System.EventHandler(this.lbinfo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Введіть напрям:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Прізвище";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ім\'я";
            // 
            // tbsurnm
            // 
            this.tbsurnm.Location = new System.Drawing.Point(124, 130);
            this.tbsurnm.Margin = new System.Windows.Forms.Padding(2);
            this.tbsurnm.Name = "tbsurnm";
            this.tbsurnm.Size = new System.Drawing.Size(141, 20);
            this.tbsurnm.TabIndex = 27;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(124, 101);
            this.tbname.Margin = new System.Windows.Forms.Padding(2);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(141, 20);
            this.tbname.TabIndex = 26;
            // 
            // Submit_button
            // 
            this.Submit_button.Location = new System.Drawing.Point(719, 494);
            this.Submit_button.Margin = new System.Windows.Forms.Padding(2);
            this.Submit_button.Name = "Submit_button";
            this.Submit_button.Size = new System.Drawing.Size(200, 81);
            this.Submit_button.TabIndex = 25;
            this.Submit_button.Text = "Забронювати квиток";
            this.Submit_button.UseVisualStyleBackColor = true;
            this.Submit_button.Click += new System.EventHandler(this.Submit_button_Click);
            // 
            // lbfrom
            // 
            this.lbfrom.FormattingEnabled = true;
            this.lbfrom.Location = new System.Drawing.Point(159, 293);
            this.lbfrom.Name = "lbfrom";
            this.lbfrom.Size = new System.Drawing.Size(120, 108);
            this.lbfrom.TabIndex = 38;
            this.lbfrom.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbto
            // 
            this.lbto.FormattingEnabled = true;
            this.lbto.Location = new System.Drawing.Point(159, 170);
            this.lbto.Name = "lbto";
            this.lbto.Size = new System.Drawing.Size(120, 108);
            this.lbto.TabIndex = 40;
            this.lbto.SelectedIndexChanged += new System.EventHandler(this.lbto_SelectedIndexChanged);
            // 
            // dtfrom
            // 
            this.dtfrom.Location = new System.Drawing.Point(431, 85);
            this.dtfrom.Name = "dtfrom";
            this.dtfrom.Size = new System.Drawing.Size(200, 20);
            this.dtfrom.TabIndex = 41;
            // 
            // dtback
            // 
            this.dtback.Location = new System.Drawing.Point(657, 85);
            this.dtback.Name = "dtback";
            this.dtback.Size = new System.Drawing.Size(200, 20);
            this.dtback.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Дата відправлення";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(716, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Зворотній квиток";
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(2, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(476, 77);
            this.label6.TabIndex = 46;
            this.label6.Text = "Online booking";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(15, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(15, 293);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // TravelRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(930, 586);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtback);
            this.Controls.Add(this.dtfrom);
            this.Controls.Add(this.lbto);
            this.Controls.Add(this.lbfrom);
            this.Controls.Add(this.cbvisa);
            this.Controls.Add(this.cblaggage);
            this.Controls.Add(this.lbinfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbsurnm);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.Submit_button);
            this.Name = "TravelRegForm";
            this.Text = "TravelRegForm";
            this.Load += new System.EventHandler(this.TravelRegForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbvisa;
        private System.Windows.Forms.CheckBox cblaggage;
        private System.Windows.Forms.Label lbinfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbsurnm;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Button Submit_button;
        private System.Windows.Forms.ListBox lbfrom;
        private System.Windows.Forms.ListBox lbto;
        private System.Windows.Forms.DateTimePicker dtfrom;
        private System.Windows.Forms.DateTimePicker dtback;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}