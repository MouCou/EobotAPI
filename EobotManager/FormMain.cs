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
using EobotManager.Properties;

namespace EobotManager
{
    public partial class MainForm : Form
    {
        private EobotInfos FEobotInfos;
        private DataTable FDataCoin;
        private DataTable FDataAll;
        private DataTable FDataCloud;

        public MainForm()
        {
            InitializeComponent();

            //eUserId.Text = DemoConstant.UserID;
            //eEmail.Text = DemoConstant.email;
            //ePassword.Text = DemoConstant.APIKey;


            eUserId.Text = Settings.Default.UserId;
            eEmail.Text = Settings.Default.Email;
            ePassword.Text = Settings.Default.PassWord;
        }

        //private async void btn_GetBalance_Click(object sender, EventArgs e)
        //{

        //    JObject myBalance = ;

        //    MessageBox.Show(String.Format("{0:F8}", GetBasics.GetRate("EUR")));
        //    MessageBox.Show(String.Format("{0:F8}", GetBasics.GetBalance(DemoConstant.UserID, "USD")));

        //    GetBasics.SetMiningMode(DemoConstant.UserID, DemoConstant.email, DemoConstant.APIKey, "GHS");
        //    MessageBox.Show(String.Format("{0:F8}", GetBasics.GetSpeed(DemoConstant.UserID, "CloudSHA-256")));
        //    MessageBox.Show(GetBasics.EstimateFee("BTC", 1.20f, "EUR").AsString());

        //    MessageBox.Show(String.Format(System.Globalization.CultureInfo.GetCultureInfo("en-EN"), "{0:F8}", 0.12345678945));


        //    Double myVal = 0;
        //    var task = Task.Run(async () =>
        //    {
        //        myVal = await GetBasics.GetBalance(DemoConstant.UserID, "BTC");
        //    });
        //    var continuation = task.ContinueWith(antecedent => Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("en-EN"), "{0:F8}", myVal), TaskScheduler.FromCurrentSynchronizationContext());
        //    await task;

        //    if (FEobotInfos == null)
        //    {
        //        FEobotInfos = new EobotInfos(DemoConstant.UserID, DemoConstant.email, DemoConstant.Passwrd, DemoConstant.APIKey, "EUR");
        //    }
        //    else
        //    {
        //        FEobotInfos.Refresh();
        //    }



        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    eResult.Text = "COINS";
        //    eResult.AppendText(Environment.NewLine);
        //    var myCurrencies = FEobotInfos.Currencies.FindAll(item => (item.IsCoin));
        //    foreach (EobotCurrency myCurr in myCurrencies)
        //    {
        //        eResult.AppendText(String.Format("{0} : {1:F8} : {2:F8}", myCurr.Code, myCurr.Rate, myCurr.Balance));
        //        eResult.AppendText(Environment.NewLine);
        //    }
        //    eResult.AppendText(String.Format("TOTAL : {0:F8}", FEobotInfos.TotalBalance));

        //    if (FDataCoin == null)
        //    {
        //        FDataCoin = new DataTable();
        //        FDataCoin.Columns.Add("Code");
        //        FDataCoin.Columns.Add("Rate");
        //        FDataCoin.Columns.Add("Balance");

        //        DataColumn[] Key = new DataColumn[1];
        //        Key[0] = FDataCoin.Columns[0];

        //        FDataCoin.PrimaryKey = Key;

        //    }

        //    var myCurrencies = FEobotInfos.Currencies.FindAll(item => (item.IsCoin));
        //    DataRow myRow = null;
        //    foreach (EobotCurrency myCurr in myCurrencies)
        //    {
        //        myRow = FDataCoin.Rows.Find(myCurr.Code);
        //        if (myRow != null)
        //        {
        //            myRow["Rate"] = myCurr.Rate;
        //            myRow["Balance"] = myCurr.Balance;
        //        }
        //        else
        //        {
        //            myRow = FDataCoin.Rows.Add(myCurr.Code, myCurr.Rate, myCurr.Balance);
        //        }
        //    }

        //    gridCurr.DataSource = FDataCoin;

        //}

        private void RefreshRates()
        {
            if (FDataAll == null)
            {
                FDataAll = new DataTable();
                FDataAll.Columns.Add("Code");
                FDataAll.Columns.Add("Rate");
                FDataAll.Columns.Add("Balance");

                DataColumn[] Key = new DataColumn[1];
                Key[0] = FDataAll.Columns[0];

                FDataAll.PrimaryKey = Key;

            }

            var myCurrencies = FEobotInfos.Currencies;
            DataRow myRow = null;
            foreach (EobotCurrency myCurr in myCurrencies)
            {
                myRow = FDataAll.Rows.Find(myCurr.Code);
                if (myRow != null)
                {
                    myRow["Rate"] = myCurr.Rate;
                    myRow["Balance"] = myCurr.Balance;
                }
                else
                {
                    myRow = FDataAll.Rows.Add(myCurr.Code, myCurr.Rate, myCurr.Balance);

                    cFrom.Items.Add(myCurr.Code);
                    cTo.Items.Add(myCurr.Code);
                }
            }

            gridRates.DataSource = FDataAll;
        }

        private void RefreshBalances()
        {
            if (FDataCoin == null)
            {
                FDataCoin = new DataTable();
                FDataCoin.Columns.Add("Code");
                FDataCoin.Columns.Add("Rate");
                FDataCoin.Columns.Add("Balance");

                DataColumn[] Key = new DataColumn[1];
                Key[0] = FDataCoin.Columns[0];

                FDataCoin.PrimaryKey = Key;

            }

            var myCurrencies = FEobotInfos.Currencies.FindAll(item => (item.IsCoin));
            DataRow myRow = null;
            foreach (EobotCurrency myCurr in myCurrencies)
            {
                myRow = FDataCoin.Rows.Find(myCurr.Code);
                if (myRow != null)
                {
                    myRow["Rate"] = myCurr.Rate;
                    myRow["Balance"] = myCurr.Balance;
                }
                else
                {
                    myRow = FDataCoin.Rows.Add(myCurr.Code, myCurr.Rate, myCurr.Balance);

                    // Ajout dans la liste pour changer de currency à miner
                    cSelectMinning.Items.Add(myCurr.Code);
                    cCoinWallet.Items.Add(myCurr.Code);
                }



            }

            gridBalances.DataSource = FDataCoin;
        }

        private void RefreshCloudInfos()
        {
            if (FDataCloud == null)
            {
                FDataCloud = new DataTable();
                FDataCloud.Columns.Add("Name");
                FDataCloud.Columns.Add("Speed");

                DataColumn[] Key = new DataColumn[1];
                Key[0] = FDataCloud.Columns[0];

                FDataCloud.PrimaryKey = Key;

            }

            FEobotInfos.RefreshCloudInfos();

            var mySpeeds = FEobotInfos.CloudInfos.Speeds;
            DataRow myRow = null;
            foreach (EobotSpeed mySpeed in mySpeeds)
            {
                myRow = FDataCloud.Rows.Find(mySpeed.Name);
                if (myRow != null)
                {
                    myRow["Speed"] = mySpeed.Speed;
                }
                else
                {
                    myRow = FDataCloud.Rows.Add(mySpeed.Name, mySpeed.Speed);

                }

            }

            gridCloud.DataSource = FDataCloud;
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            Settings.Default.UserId = eUserId.Text;
            Settings.Default.Email = eEmail.Text;
            Settings.Default.PassWord = ePassword.Text;


            FEobotInfos = new EobotInfos(eUserId.Text, eEmail.Text, ePassword.Text, "EUR");

            TimerLog.Enabled = true;
        }

        private void TimerLog_Tick(object sender, EventArgs e)
        {
            pLogin.Visible = false;
            tabEobot.Visible = true;
            tabEobot.BringToFront();

            RefreshMinningCurrency();

            TimerLog.Enabled = false;

            RefreshBalances();
            RefreshRates();

            RefreshCloudInfos();
        }

        private void RefreshMinningCurrency()
        {
            FEobotInfos.RefreshMinning();
            pCoin.Load(FEobotInfos.CurrentMinning.Logo);
            lBalance.Text = String.Format("{0:F8}", FEobotInfos.CurrentMinning.Balance);
            lRate.Text = String.Format("{0:F8}", FEobotInfos.CurrentMinning.Rate);
            lCode.Text = FEobotInfos.CurrentMinning.Code;
        }

        private void gridBalances_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimerChangeMinning.Enabled = false;
            TimerChangeMinning.Enabled = true;
        }

        private void TimerChangeMinning_Tick(object sender, EventArgs e)
        {
            TimerChangeMinning.Enabled = false;
            TimerGetMinning.Enabled = false;
            TimerGetMinning.Enabled = true;

            FEobotInfos.ChangeMinning(cSelectMinning.GetItemText(cSelectMinning.SelectedItem));
        }

        private void TimerGetMinning_Tick(object sender, EventArgs e)
        {
            TimerGetMinning.Enabled = false;
            RefreshMinningCurrency();
        }

        private void bEstimate_Click(object sender, EventArgs e)
        {
            JObject myRes = GetBasics.EstimateFee(cFrom.GetItemText(cFrom.SelectedItem), Convert.ToDouble(eAmount.Text), cTo.GetItemText(cTo.SelectedItem)).AsJsonObject().Result;
            eEstimate.Text = myRes["Result"].Value<string>();
        }

        private async void cCoinWallet_SelectedIndexChanged(object sender, EventArgs e)
        {
            eWalletAddress.Text = await FEobotInfos.WalletAddress(cCoinWallet.GetItemText(cCoinWallet.SelectedItem));
        }
    }
}
