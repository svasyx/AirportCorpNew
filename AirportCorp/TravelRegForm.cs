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
    
    public partial class TravelRegForm : Form
    {
        List<Traveller> travellers = new List<Traveller>();
        Traveller traveller;
        HashSet<Traveller> travellers1 = new HashSet<Traveller>();

        

        public int days = 0;
        

        public TravelRegForm()
        {
            InitializeComponent();
            FormClosing += TravelRegForm_FormClosing;
            string[] routs = { "Киев", "Лондон", "Париж", "Камбоджа", "Маями" };
            lbfrom.Items.AddRange(routs);
            lbto.Items.AddRange(routs);
            lbfrom.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            lbto.SelectedIndexChanged += listBox1_SelectedIndexChanged;

        }

        private void TravelRegForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter binaryFormatter3 = new BinaryFormatter();


            using (FileStream fs = new FileStream("travelle.dat", FileMode.Create))
            {

                binaryFormatter3.Serialize(fs, travellers);

            }

        }

        private void Submit_button_Click(object sender, EventArgs e)
        {

            


        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            
        }

       
        private void TravelRegForm_Load(object sender, EventArgs e)
        {
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btclear_Click(object sender, EventArgs e)
        {
     
        }

        private void lbinfo_Click(object sender, EventArgs e)
        {
            
        }

      
        private void cbvisa_CheckedChanged(object sender, EventArgs e)
        {
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //foreach (var item in travellers1)
            //{
            //    Console.WriteLine(item.GetAll());
            //}

            //using (StreamWriter writer = new StreamWriter("travellers.txt",false, System.Text.Encoding.UTF8))
            //{
            //    foreach (var item in travellers)
            //    {
            //        writer.WriteLine(item.GetAll());
            //    }

            //}

           

            this.Close();
        }

        public double Price(double distance, double price_of_travel, double visa_price)
        {
            return distance * price_of_travel + visa_price;
        }

        private void btwrte_Click(object sender, EventArgs e)
        {
           
        }

        private void lbto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void Submit_button_Click_1(object sender, EventArgs e)
        {






            try
            {

                if (cblaggage.Checked == true && cbvisa.Checked == true)
                {
                    traveller = new Traveller(tbname.Text, tbsurnm.Text, lbfrom.SelectedItem.ToString(), lbto.SelectedItem.ToString(), days, true, true, dtfrom.Value, dtback.Value);
                }
                else if (cblaggage.Checked == false && cbvisa.Checked == false)
                {
                    traveller = new Traveller(tbname.Text, tbsurnm.Text, lbfrom.SelectedItem.ToString(), lbto.SelectedItem.ToString(), days, false, false, dtfrom.Value, dtback.Value);
                }
                else if (cblaggage.Checked == true && cbvisa.Checked == false)
                {
                    traveller = new Traveller(tbname.Text, tbsurnm.Text, lbfrom.SelectedItem.ToString(), lbto.SelectedItem.ToString(), days, true, false, dtfrom.Value, dtback.Value);
                }
                else if (cblaggage.Checked == false && cbvisa.Checked == true)
                {
                    traveller = new Traveller(tbname.Text, tbsurnm.Text, lbfrom.SelectedItem.ToString(), lbto.SelectedItem.ToString(), days, false, true, dtfrom.Value, dtback.Value);
                }

                traveller.PriceHandler += Price;
                travellers.Add(traveller);
                travellers1.Add(traveller);




                //ITraveler tr = new Traveller(tbname.Text, tbsurnm.Text, lbfrom.SelectedItem.ToString(), lbto.SelectedItem.ToString(), days, false, true, dtfrom.Value, dtback.Value);
                //MessageBox.Show($"{tr.GetAll()}");

            }

            catch (minusException exp)
            {
                MessageBox.Show($"{exp.Message}, Ваша к-сть днів: {exp._value}!");
            }
            catch (cityException exp1)
            {
                MessageBox.Show($"{exp1.Message}, вибране місто: {exp1._city}");
            }
            catch (dateException exp2)
            {
                MessageBox.Show($"{exp2.Message}, вибрана дата: {exp2.date}");
            }



            lbinfo.Text = "";
            lbinfo.Text = "Ваш квиток: " + traveller.GetAll();


        }
    }
}
