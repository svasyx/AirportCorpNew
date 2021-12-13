
namespace AirportCorp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.trvbtn = new System.Windows.Forms.Button();
            this.bsnbtn = new System.Windows.Forms.Button();
            this.btAdmin = new System.Windows.Forms.Button();
            this.btclose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // trvbtn
            // 
            this.trvbtn.BackColor = System.Drawing.Color.Wheat;
            this.trvbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.trvbtn.Location = new System.Drawing.Point(31, 436);
            this.trvbtn.Name = "trvbtn";
            this.trvbtn.Size = new System.Drawing.Size(203, 111);
            this.trvbtn.TabIndex = 1;
            this.trvbtn.Text = "Путешевствую";
            this.trvbtn.UseVisualStyleBackColor = false;
            this.trvbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // bsnbtn
            // 
            this.bsnbtn.BackColor = System.Drawing.Color.Wheat;
            this.bsnbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bsnbtn.Location = new System.Drawing.Point(554, 436);
            this.bsnbtn.Name = "bsnbtn";
            this.bsnbtn.Size = new System.Drawing.Size(219, 111);
            this.bsnbtn.TabIndex = 2;
            this.bsnbtn.Text = "Я бизнесмен";
            this.bsnbtn.UseVisualStyleBackColor = false;
            this.bsnbtn.Click += new System.EventHandler(this.bsnbtn_Click);
            // 
            // btAdmin
            // 
            this.btAdmin.BackColor = System.Drawing.Color.Wheat;
            this.btAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdmin.Location = new System.Drawing.Point(366, 581);
            this.btAdmin.Name = "btAdmin";
            this.btAdmin.Size = new System.Drawing.Size(75, 23);
            this.btAdmin.TabIndex = 3;
            this.btAdmin.Text = "AdminForm";
            this.btAdmin.UseVisualStyleBackColor = false;
            this.btAdmin.Click += new System.EventHandler(this.btAdmin_Click);
            // 
            // btclose
            // 
            this.btclose.BackColor = System.Drawing.SystemColors.MenuText;
            this.btclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btclose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btclose.ForeColor = System.Drawing.SystemColors.Window;
            this.btclose.Location = new System.Drawing.Point(766, 12);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(22, 23);
            this.btclose.TabIndex = 4;
            this.btclose.Text = "X";
            this.btclose.UseVisualStyleBackColor = false;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AirportCorp.Properties.Resources.i_loveAfrika_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(175, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 153);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btclose);
            this.Controls.Add(this.btAdmin);
            this.Controls.Add(this.bsnbtn);
            this.Controls.Add(this.trvbtn);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button trvbtn;
        private System.Windows.Forms.Button bsnbtn;
        private System.Windows.Forms.Button btAdmin;
        private System.Windows.Forms.Button btclose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

