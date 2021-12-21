﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace AirportCorp
{
    public partial class RegWorker : Form
    {
        Worker<Airport> worker;
        Stack<Worker<Airport>> workers = new Stack<Worker<Airport>>();

        public RegWorker()
        {
            InitializeComponent();
            FormClosing += RegWorker_FormClosing;
            string[] airports = { "Киев", "Лондон", "Париж", "Камбоджа", "Маями" };
            lbairport.Items.AddRange(airports);
            lbairport.SelectedIndexChanged += lbairport_SelectedIndexChanged;
        }

        private void RegWorker_FormClosing(object sender, FormClosingEventArgs e)
        {

            BinaryFormatter binaryFormatter3 = new BinaryFormatter();


            using (FileStream fs = new FileStream("worker1s.dat", FileMode.Create))
            {

                binaryFormatter3.Serialize(fs, workers);

            }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                worker = new Worker<Airport>(tbname.Text, tbsrname.Text, tbid.Text, tbpass.Text, new Airport(lbairport.SelectedItem.ToString()));
                workers.Push(worker);
                

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
            this.Close();

        }
    }
}
