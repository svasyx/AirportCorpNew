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
    public partial class RegWorker : Form
    {
        Worker<string> worker;
        List<Worker<string>> workers = new List<Worker<string>>();

        public RegWorker()
        {
            InitializeComponent();
            string[] airports = { "Киев", "Одеса", "Харьков", "Полтава", "Винница" };
            lbairport.Items.AddRange(airports);
            lbairport.SelectedIndexChanged += lbairport_SelectedIndexChanged;
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                worker = new Worker<string>(tbname.Text, tbsrname.Text, tbid.Text, tbpass.Text, lbairport.SelectedItem.ToString());
                workers.Add(worker);

            }
            catch (emptyException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (FormatException exp2)
            {
                MessageBox.Show(exp2.Message);
            }


        }

        private void RegWorker_Load(object sender, EventArgs e)
        {

        }

        private void lbairport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter3 = new BinaryFormatter();


            using (FileStream fs = new FileStream("workers.dat", FileMode.Append))
            {

                binaryFormatter3.Serialize(fs, workers);

            }
            this.Close();
        }
    }
}
