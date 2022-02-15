using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Currency Converter";
        }

        private void convButtonClicked(object sender, EventArgs e)
        {
            //Get current rate data by using ExchangeRate-API
            string url =
                //Modified url for uploading the file. *This url doesn't exist
                "https://v6.exchangerate-api.com/v6/<APIkey>/latest/USD";
            HttpClient client = new HttpClient();
            string result = client.GetStringAsync(url).Result;

            //Extract USD-JPY rate from JSON
            JObject jobj = JObject.Parse(result);

            double currentRate = (double)((jobj["conversion_rates"]["JPY"] as JValue).Value);
            this.rate.Text = currentRate.ToString();

            int price;
            bool success = int.TryParse(this.usdBox.Text, out price);

            if (success)
            {
                int priceYen = (int)(price * currentRate);
                this.jpyBox.Text = String.Format("{0:#,0}", priceYen);
            }
            else
            {
                MessageBox.Show("Please enter valid price");
            }
        }
    }
}
