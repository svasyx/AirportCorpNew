using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace AirportCorp
{
    public partial class AdminForm : Form
    {
        Stack<Worker<Airport>> workers = new Stack<Worker<Airport>>();
        List<Traveller> travellers = new List<Traveller>();
        Queue<Bussinesman> bussinesmens = new Queue<Bussinesman>();
        static  Airport airport = new Airport();
        int k;
        Worker<Airport> mainadmin = new Worker<Airport>("a", "a", "admin", "admin", airport);

        Point point = new Point(300, 150);
        Point point2 = new Point(80, 150);
        public AdminForm()
        {

            InitializeComponent();
            string[] routs = { "Киев", "Лондон", "Париж", "Камбоджа", "Маями" };
            lbairports.Items.AddRange(routs);
            lbairports.SelectedIndexChanged += lbairports_SelectedIndexChanged;

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            pnstart.Location = point;
        }

        private void lbairport_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            lbinfo_ab.Text = "";

            foreach (Worker<Airport> w in workers)
            {
                lbinfo_ab.Text = lbinfo_ab.Text + '\n' + $"{w.GetAll()} ;\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {             
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            lbinfo_ab.Text = "";



           BinaryFormatter binaryFormatter1 = new BinaryFormatter();
            using (FileStream fs = new FileStream("traveller.dat", FileMode.OpenOrCreate))
            {
                travellers = (List<Traveller>)binaryFormatter1.Deserialize(fs);


            }

            foreach (var item in travellers)
            {
                lbinfo_ab.Text = lbinfo_ab.Text  + '\n' + item.GetAll() + '\n';
            }
        }

        private void btreg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введіть ID та пароль головного адміна!");

            pnstart.Visible = false; 
            panadm.Location = point;
            panadm.Visible = true;

        }

        private void btsubmit_Click(object sender, EventArgs e)
        {
            if (mainadmin.Getid() == tbalog.Text && mainadmin.Getpas() == tbapass.Text)
            {
                panadm.Visible = false;
                RegWorker regWorker = new RegWorker();
                regWorker.Show();
            }
            else
            {
                MessageBox.Show("Wrong password or login");
                pnstart.Visible = false;

            }
        }

        private void btlog_Click(object sender, EventArgs e)
        {

            BinaryFormatter binaryFormatter1 = new BinaryFormatter();
            using (FileStream fs = new FileStream("worker1s.dat", FileMode.OpenOrCreate))
            {
                workers = (Stack<Worker<Airport>>)binaryFormatter1.Deserialize(fs);


            }

            pnstart.Visible = false;
            pnlogin.Visible = true;
            pnlogin.Location = point;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            

            foreach (Worker<Airport> w in workers)
            {
                if (tblogin.Text == w.Getid() && tppassword.Text == w.Getpas())
                {
                    pnlogin.Visible = false;
                    panwork.Visible = true;
                    panwork.Location = point2;

                    k++;
                }
            }

            if (k == 0)
            {
                MessageBox.Show("Wrong password or login");
            }
        }

        private void panwork_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnstart.Visible = true;    
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbairports_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (lbairports.SelectedItem == null)
            {
                MessageBox.Show("Виберіть аеропорт!");
            }
            else
            {
                lbinfo_ab.Text = "";
                foreach (Worker<Airport> w in workers)
                {


                    if (w.GetPlaceOfWork().GetTown() == lbairports.SelectedItem.ToString())
                    {
                        lbinfo_ab.Text += '\n' +  w.GetAll() + '\n';
                        continue;
                    }
                }
            }
        }

        private void pnstart_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter1 = new BinaryFormatter();
            using (FileStream fs = new FileStream("bussinesmans.dat", FileMode.OpenOrCreate))
            {
                bussinesmens = (Queue<Bussinesman>)binaryFormatter1.Deserialize(fs);


            }
            lbinfo_ab.Text = "";

            foreach (var item in bussinesmens)
            {
                lbinfo_ab.Text = lbinfo_ab.Text + '\n' + item.GetAll() + '\n';
            }
        }
    }
}
    