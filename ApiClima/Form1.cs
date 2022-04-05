using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net; 

namespace ApiClima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String ApiKey = "93e1d37e90618f18031fa2e07f14be47";

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        void GetWeather()
        {

            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}");


            }
        }

    }
}
