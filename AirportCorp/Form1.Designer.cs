
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
            this.label1 = new System.Windows.Forms.Label();
            this.trvbtn = new System.Windows.Forms.Button();
            this.bsnbtn = new System.Windows.Forms.Button();
            this.btAdmin = new System.Windows.Forms.Button();
            this.btclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label1.Location = new System.Drawing.Point(313, 288);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "AirportCompany";
            // 
            // trvbtn
            // 
            this.trvbtn.Location = new System.Drawing.Point(41, 551);
            this.trvbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trvbtn.Name = "trvbtn";
            this.trvbtn.Size = new System.Drawing.Size(263, 123);
            this.trvbtn.TabIndex = 1;
            this.trvbtn.Text = "Путешевствую";
            this.trvbtn.UseVisualStyleBackColor = true;
            this.trvbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // bsnbtn
            // 
            this.bsnbtn.Location = new System.Drawing.Point(731, 537);
            this.bsnbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bsnbtn.Name = "bsnbtn";
            this.bsnbtn.Size = new System.Drawing.Size(292, 137);
            this.bsnbtn.TabIndex = 2;
            this.bsnbtn.Text = "Я бизнесмен";
            this.bsnbtn.UseVisualStyleBackColor = true;
            this.bsnbtn.Click += new System.EventHandler(this.bsnbtn_Click);
            // 
            // btAdmin
            // 
            this.btAdmin.Location = new System.Drawing.Point(488, 715);
            this.btAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAdmin.Name = "btAdmin";
            this.btAdmin.Size = new System.Drawing.Size(100, 28);
            this.btAdmin.TabIndex = 3;
            this.btAdmin.Text = "AdminForm";
            this.btAdmin.UseVisualStyleBackColor = true;
            this.btAdmin.Click += new System.EventHandler(this.btAdmin_Click);
            // 
            // btclose
            // 
            this.btclose.BackColor = System.Drawing.SystemColors.MenuText;
            this.btclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btclose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btclose.ForeColor = System.Drawing.SystemColors.Window;
            this.btclose.Location = new System.Drawing.Point(1021, 15);
            this.btclose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(29, 28);
            this.btclose.TabIndex = 4;
            this.btclose.Text = "X";
            this.btclose.UseVisualStyleBackColor = false;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 758);
            this.Controls.Add(this.btclose);
            this.Controls.Add(this.btAdmin);
            this.Controls.Add(this.bsnbtn);
            this.Controls.Add(this.trvbtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button trvbtn;
        private System.Windows.Forms.Button bsnbtn;
        private System.Windows.Forms.Button btAdmin;
        private System.Windows.Forms.Button btclose;
    }
}

