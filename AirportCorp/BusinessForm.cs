using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
    
namespace AirportCorp
{
    public partial class BusinessForm : Form
    {
        //ініціалізація полей
        Bussinesman bussinesman;
        public int people_count = 0;
       
        
        Queue<Bussinesman> bussinesmens = new Queue<Bussinesman>();

        public BusinessForm()
        {
            InitializeComponent();
            FormClosing += BusinessForm_FormClosing;
        }

        private void BusinessForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            //серіалізація у файл

            BinaryFormatter binaryFormatter3 = new BinaryFormatter();


            using (FileStream fs = new FileStream("bussinesmans.dat", FileMode.Create))
            {

                binaryFormatter3.Serialize(fs, bussinesmens);

            }
        }

        private void BusinessForm_Load(object sender, EventArgs e)
        {
            

        }

        private void btprint_Click(object sender, EventArgs e)
        {
            
            
           
        }

        private void infolb_Click(object sender, EventArgs e)
        {

        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            
        }

        private void moneytb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btclose_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void infolb_Click_1(object sender, EventArgs e)
        {

        }

        private void btSubmit_Click_1(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void btSubmit_Click_2(object sender, EventArgs e)
        {
            
            try
            {
                people_count = Convert.ToInt32(moneytb.Text);
            }
            //відслідковування помилок
            catch (FormatException exp)
            {
                MessageBox.Show($"{exp.Message}");
            }
            //створення об'єктів з даними з форми

            try
            {
                if (cball.Checked == true)
                {
                    bussinesman = new Bussinesman(nametb.Text, surtb.Text, true, people_count);
                    //додавання об'єкту у чергу
                    bussinesmens.Enqueue(bussinesman);

                }
                if (cball.Checked == false)
                {
                    bussinesman = new Bussinesman(nametb.Text, surtb.Text, false, people_count);
                    bussinesmens.Enqueue(bussinesman);
                }
                //використання інтерфейсу
                //IBusinesmann pr = new Bussinesman(nametb.Text, surtb.Text, false, people_count);
                //MessageBox.Show($"{pr.GetAll()}");

                lbinfo.Text = "Ваше замовлення: " + bussinesman.GetAll();
            }
            //відслідковування помилок
            catch (minusException exp)
            {
                MessageBox.Show($"{exp.Message} Ваша к-сть грошей: {exp._value}");
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
