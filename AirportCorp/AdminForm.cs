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
    public partial class AdminForm : Form
    {
        List<Worker<string>> workers = new List<Worker<string>>();
        List<Traveller> travellers = new List<Traveller>();
        
        int k;
        Worker<string> mainadmin = new Worker<string>("a", "a", "admin", "admin","Kiev");
        Point point = new Point(400, 225);
        public AdminForm()
        {
            InitializeComponent();
           
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            BinaryFormatter formatter12 = new BinaryFormatter();


            using (FileStream fs = new FileStream("workers.dat", FileMode.OpenOrCreate))
            {
                workers = (List<Worker<string>>)formatter12.Deserialize(fs);
            }


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

            foreach(Worker<string> w in workers)
            {
                lbinfo_ab.Text = lbinfo_ab.Text + $"{w.GetAll()} ;\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter3 = new BinaryFormatter();


            using (FileStream fs = new FileStream("workers1.dat", FileMode.Append))
            {

                binaryFormatter3.Serialize(fs, workers);

            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbinfo_ab.Text = "";
            BinaryFormatter binaryFormatter2 = new BinaryFormatter();
            using (FileStream fs = new FileStream("traveller.dat", FileMode.Open))
            {
                travellers = (List<Traveller>)binaryFormatter2.Deserialize(fs);
            }
            foreach (Traveller p in travellers)
            {
                lbinfo_ab.Text = lbinfo_ab.Text + p.GetAll();
            }
        }

        private void btreg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введіть ID та пароль головного адміна!");

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
            }
        }

        private void btlog_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter1 = new BinaryFormatter();

            using (FileStream fs = new FileStream("workers.dat", FileMode.OpenOrCreate))
            {
                workers = (List<Worker<string>>)binaryFormatter1.Deserialize(fs);


            }


            pnstart.Visible = false;
            pnlogin.Visible = true;
            pnlogin.Location = point;

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            

            foreach( Worker<string> w in workers)
            {
                if (tblogin.Text == w.Getid() && tppassword.Text == w.Getpas())
                {
                    pnlogin.Visible = false;
                    panwork.Visible = true;
                    panwork.Location = point;
                    k++;

                }
                
                
            }

            if(k==0)
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
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("workers1.dat", FileMode.Append))
            {

                binaryFormatter.Serialize(fs, workers);
                

            }
        }
    }
}
