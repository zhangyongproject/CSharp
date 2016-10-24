﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using webClientTestForm.WebServiceSample;

namespace webClientTestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new WebServiceSample.WebService1SoapClient();
            client.ReverseStringCompleted += client_ReverseStringCompleted;
            //textBox2.Text = client.ReverseString(textBox1.Text);
            client.ReverseStringAsync(textBox1.Text);

        }

        void client_ReverseStringCompleted(object sender, WebServiceSample.ReverseStringCompletedEventArgs e)
        {
            if(e.Error == null)
            {
                textBox2.Text = e.Result;
            }
            else
            {
                MessageBox.Show(e.Error.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var req = new GetWeatherRequest();
        }
    }
}
