using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportCorp
{
    public partial class MainForm : Form
    {
        

        

        public MainForm()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void prntbtn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        

        private void Submit_button_Click(object sender, EventArgs e)
        {
           
           
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //відкриття форми по кліку
            TravelRegForm regForm = new TravelRegForm();
            regForm.Show();
        }

        private void bsnbtn_Click(object sender, EventArgs e)
        {
            //відкриття форми по кліку

            BusinessForm businessForm = new BusinessForm();
            businessForm.Show();
        }

        private void btAdmin_Click(object sender, EventArgs e)
        {
            //відкриття форми по кліку

            AdminForm adForm = new AdminForm();
            adForm.Show();
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            //закриття форми по кліку

            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
