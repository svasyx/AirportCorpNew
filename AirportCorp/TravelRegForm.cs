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
        //ініціалізація полів

        List<Traveller> travellers = new List<Traveller>();
        Traveller traveller;
        HashSet<Traveller> travellers1 = new HashSet<Traveller>();
        ITraveler tr;



        public int days = 0;
        

        public TravelRegForm()
        {
            InitializeComponent();

            // івент
            FormClosing += TravelRegForm_FormClosing;

            //заповнення маршрутів призначення

            string[] routs = { "Киев", "Лондон", "Париж", "Камбоджа", "Маями" };
            lbfrom.Items.AddRange(routs);
            lbto.Items.AddRange(routs);
            lbfrom.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            lbto.SelectedIndexChanged += listBox1_SelectedIndexChanged;

        }

        private void TravelRegForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            // сереалізація в файл

            BinaryFormatter binaryFormatter3 = new BinaryFormatter();


            using (FileStream fs = new FileStream("traveller.dat", FileMode.Create))
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
        

            this.Close();
        }

        public double Price(double distance, double price_of_travel, double visa_price)
        {
            //отримання ціни
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



            //створення об'єктів у відповідності з полями у формі


            try
            {
                if (cblaggage.Checked == true && cbvisa.Checked == true)
                {
                    traveller = new Traveller(tbname.Text, tbsurnm.Text, lbfrom.SelectedItem.ToString(), lbto.SelectedItem.ToString(), days, true, true, dtfrom.Value, dtback.Value, Price);
                }
                else if (cblaggage.Checked == false && cbvisa.Checked == false)
                {
                    traveller = new Traveller(tbname.Text, tbsurnm.Text, lbfrom.SelectedItem.ToString(), lbto.SelectedItem.ToString(), days, false, false, dtfrom.Value, dtback.Value, Price);
                }
                else if (cblaggage.Checked == true && cbvisa.Checked == false)
                {
                    traveller = new Traveller(tbname.Text, tbsurnm.Text, lbfrom.SelectedItem.ToString(), lbto.SelectedItem.ToString(), days, true, false, dtfrom.Value, dtback.Value, Price);
                }
                else if (cblaggage.Checked == false && cbvisa.Checked == true)
                {
                    traveller = new Traveller(tbname.Text, tbsurnm.Text, lbfrom.SelectedItem.ToString(), lbto.SelectedItem.ToString(), days, false, true, dtfrom.Value, dtback.Value, Price);
                }
                //traveller.PriceHandler += Price;

                // додавання у списки
                travellers.Add(traveller);
                travellers1.Add(traveller);
                tr = traveller;





            }
            //відслідковування виключень
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
            catch (NullReferenceException exp3)
            {
                MessageBox.Show(exp3.Message);
            }


            //вивід
            lbinfo.Text = "";
            lbinfo.Text = "Ваш квиток: " + tr.GetAll();


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
