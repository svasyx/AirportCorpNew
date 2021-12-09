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
        Bussinesman bussinesman;
        public int people_count = 0;
        
       
        List<Bussinesman> bussinesmens = new List<Bussinesman>();

        public BusinessForm()
        {
            InitializeComponent();
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
            try
            {
                people_count = Convert.ToInt32(moneytb.Text);
            }
            catch(FormatException exp)
            {
                MessageBox.Show($"{exp.Message}");
            }
            
            try
            {
                if (cball.Checked == true)
                {
                    bussinesman = new Bussinesman(nametb.Text, surtb.Text, true,people_count);
                    bussinesmens.Add(bussinesman);
                }
                if(cball.Checked == false)
                {
                    bussinesman = new Bussinesman(nametb.Text, surtb.Text, false, people_count);
                    bussinesmens.Add(bussinesman);
                }

                //IBusinesmann pr = new Bussinesman(nametb.Text, surtb.Text, false, people_count);
                //MessageBox.Show($"{pr.GetAll()}");

                infolb.Text ="Ваше замовлення: " + bussinesman.GetAll();
            }

            catch (minusException exp)
            {
                MessageBox.Show($"{exp.Message} Ваша к-сть грошей: {exp._value}");
            }
        }

        private void moneytb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btclose_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("bussinesmens.dat", FileMode.Append))
            {

                formatter.Serialize(fs, bussinesmens);

            }
            this.Close();
        }
    }
}
