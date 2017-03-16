using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EobotAPI;
using Newtonsoft.Json.Linq;

namespace EobotManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_GetBalance_Click(object sender, EventArgs e)
        {

            //JObject myBalance = ;

            MessageBox.Show(String.Format("{0:F8}", GetBasics.GetRate( "EUR")));
            //MessageBox.Show(String.Format("{0:F8}",GetBasics.GetBalance(DemoConstant.UserID, "USD")));

            //GetBasics.SetMiningMode(DemoConstant.UserID, DemoConstant.email, DemoConstant.APIKey, "GHS");
            // MessageBox.Show(String.Format("{0:F8}",GetBasics.GetSpeed(DemoConstant.UserID, "CloudSHA-256")));
            //MessageBox.Show(GetBasics.EstimateFee("BTC", 1.20f, "EUR").AsString());

            //MessageBox.Show(String.Format(System.Globalization.CultureInfo.GetCultureInfo("en-EN"), "{0:F8}", 0.12345678945));
        }
    }
}
