using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using System.Net.Http.Formatting;
using System.Threading;

namespace EobotAPI
{
    public class EobotSpeed
    {
        private string FName = "";
        private double FSpeed = 0;

        public string Name { get => FName; set { FName = value; } }
        public double Speed { get => FSpeed; set { FSpeed = value; } }

        public EobotSpeed(string aName, double aSpeed)
        {
            Name = aName;
            Speed = aSpeed;
        }

    }

    public class EobotCloudInfos
    {
        private List<EobotSpeed> FSpeeds;
        private string FUserId;

        public List<EobotSpeed> Speeds { get => FSpeeds; }

        public EobotCloudInfos(string aUserId)
        {
            FUserId = aUserId;
            FSpeeds = new List<EobotSpeed>();
        }

        public void Refresh()
        {
            JObject mySpeeds = GetBasics.GetSpeeds(FUserId).AsJsonObject().Result;

            foreach (var myElem in mySpeeds)
            {
                EobotSpeed mySpeed = FSpeeds.Find(item => item.Name == myElem.Key);
                if (mySpeed == null)
                {
                    FSpeeds.Add(new EobotSpeed(myElem.Key, Convert.ToDouble(myElem.Value)));
                }
                else
                {
                    mySpeed.Speed = Convert.ToDouble(myElem.Value);
                }
            }
        }
    }

    public class EobotCurrency
    {
        private string FName="";
        private string FCode = "";
        private double FBalance = 0;
        private double FRate = 0;
        private bool FIsCoin = true;
        private string FLogo;

        public string Name { get => FName; set { FName = value; } }
        public string Code { get => FCode; set { FCode = value; } }
        public double Balance { get => FBalance; set { FBalance = value; } }
        public double Rate { get => FRate; set { FRate = value; } }
        public bool IsCoin { get => FIsCoin; set { FIsCoin = value; } }
        public string Logo { get => FLogo;set { FLogo = value; } }

        public EobotCurrency(string aCode, double aRate, bool aIsCoin)
        {
            Code = aCode;
            Rate = aRate;
            IsCoin = aIsCoin;
        }
    }

    public class EobotInfos
    {
        private List<EobotCurrency> FCurrencies;
        private string FUserId;
        private string FEmail;
        private string FPassword;
        private string FBaseCurrency;
        private double FTotalBalance;
        private EobotCurrency FCurrentMinning;
        private EobotCloudInfos FCloudInfos;

        public List<EobotCurrency> Currencies { get => FCurrencies; }
        public string UserId { get => FUserId; }
        public string Email { get => FEmail; }
        public string Password { get => FPassword; }
        public string BaseCurrency { get => FBaseCurrency; }
        public double TotalBalance { get => FTotalBalance; set { FTotalBalance = ConvertFrom(value, "USD"); } }
        public EobotCurrency CurrentMinning { get => FCurrentMinning; }
        public EobotCloudInfos CloudInfos { get => FCloudInfos; }

        public EobotInfos(string aUserId, string aEmail, string aPassword, string aBaseCurrency)
        {
            FUserId = aUserId;
            FEmail = aEmail;
            FPassword = aPassword;
            FCurrencies = new List<EobotCurrency>();
            FBaseCurrency = aBaseCurrency;

            Refresh();
        }

        public async Task Refresh()
        {
            JObject lstCoins = new JObject();
            var task = Task.Run(async () => {
                lstCoins = await GetBasics.GetSupportedCoins(FBaseCurrency);
            });


            var continuation = task.ContinueWith((antecedent) =>
            {
                foreach (var myElem in lstCoins)
                {
                    EobotCurrency myCoin = FCurrencies.Find(item => item.Code == myElem.Key & item.IsCoin);
                    if (myCoin == null)
                    {
                        FCurrencies.Add(new EobotCurrency(myElem.Key, myElem.Value["Price"].Value<double>(), true));
                        myCoin = FCurrencies.Last();
                        myCoin.Logo = myElem.Value["Image"].Value<string>();
                    }
                    else
                    {
                        myCoin.Rate = myElem.Value["Price"].Value<double>();
                    }
                }

                JObject lstBalance = new JObject();
                var task3 = Task.Run(async () => {
                    lstBalance = await GetBasics.GetBalances(UserId).AsJsonObject();
                });


                var continuation3 = task3.ContinueWith((antecedent2) =>
                {
                    foreach (var myElem in lstBalance)
                    {
                        if (myElem.Key == "Total")
                        {
                            TotalBalance = myElem.Value.Value<double>();
                        }
                        else
                        {

                            EobotCurrency myCoin = FCurrencies.Find(item => item.Code == myElem.Key & item.IsCoin);
                            if (myCoin == null)
                            {
                                double myRate = GetBasics.GetRate(myElem.Key);
                                FCurrencies.Add(new EobotCurrency(myElem.Key, myRate, true));

                                myCoin = FCurrencies.Find(item => item.Code == myElem.Key & item.IsCoin);
                            }

                            myCoin.Balance = Convert.ToDouble(myElem.Value);

                        }
                    }
                }
                , TaskScheduler.FromCurrentSynchronizationContext());

            }
            , TaskScheduler.FromCurrentSynchronizationContext());

            JObject lstFiat = new JObject();
            var task2 = Task.Run(async () => {
                lstFiat = await GetBasics.GetSupportedFiat(FBaseCurrency);
            });


            var continuation2 = task.ContinueWith((antecedent) =>
            {
                foreach (var myElem in lstFiat)
                {

                    EobotCurrency myCoin = FCurrencies.Find(item => item.Code == myElem.Key & item.IsCoin);
                    if (myCoin == null)
                    {
                        FCurrencies.Add(new EobotCurrency(myElem.Key, myElem.Value["Price"].Value<double>(), false));
                    }
                    else
                    {
                        myCoin.Rate = myElem.Value["Price"].Value<double>();
                    }

                }
            }
            , TaskScheduler.FromCurrentSynchronizationContext());
        }

        public async Task<string> WalletAddress(string aCurrency)
        {
            JObject Wallet = await GetBasics.GetDepositAddress(UserId, aCurrency).AsJsonObject();
            
            return Wallet[aCurrency].Value<string>();            
        }

        public double ConvertFrom(double aAmount, string aCurrency)
        {
            JObject myFee = GetBasics.EstimateFee(BaseCurrency, aAmount, aCurrency).AsJsonObject().Result;
            return myFee["Result"].Value<double>();
        }

        public void RefreshMinning()
        {
            string code = GetBasics.GetMiningMode(UserId).AsString();

            EobotCurrency myCoin = FCurrencies.Find(item => item.Code == code & item.IsCoin);

            if (FCurrentMinning == null)
            {
                FCurrentMinning = new EobotCurrency(myCoin.Code, myCoin.Rate, true);
            }
            FCurrentMinning.Code = myCoin.Code;
            FCurrentMinning.Balance = myCoin.Balance;
            FCurrentMinning.IsCoin = myCoin.IsCoin;
            FCurrentMinning.Logo = myCoin.Logo;
            FCurrentMinning.Name = myCoin.Name;
            FCurrentMinning.Rate = myCoin.Rate;
        }

        public void ChangeMinning(string aCurrency)
        {
            GetBasics.SetMiningMode(UserId, Email, Password, aCurrency);
        }

        public void SetAutomaticWithdraw(string aCurrency, double aAmount, string aWallet)
        {
            GetBasics.SetAutomaticWithdraw(UserId, Email, Password, aCurrency, aAmount, aWallet);
        }

        public void SetManualWithdraw(string aCurrency, double aAmount, string aWallet)
        {
            GetBasics.SetManualWithdraw(UserId, Email, Password, aCurrency, aAmount, aWallet);
        }

        public void ByCloud(string aCurrencyFrom, float aAmount, string aCurrencyTo)
        {
            GetBasics.BuyCloud(UserId,Email, Password,  aCurrencyFrom,  aAmount,  aCurrencyTo);
        }


        public void RefreshCloudInfos()
        {
            if (FCloudInfos == null)
            {
                FCloudInfos = new EobotCloudInfos(UserId);
            }
            FCloudInfos.Refresh();

        }

    }

    public static class GetBasics
    {
        private static string aBaseUrl = @"https://www.eobot.com/api.aspx";
        private static string aGetBalanceParams = "?total={0}";
        private static string aGetMiningModeParams = "?idmining={0}";
        private static string aGetSpeedParams = "?idspeed={0}";
        private static string aGetDepositAddressParams = "?id={0}&deposit={1}";
        private static string aSetMiningModeParams = "?id={0}&email={1}&password={2}&mining={3}";
        private static string aSetAutoWithdrawParms = "?id={0}&email={1}&password={2}&withdraw={3}&amount={4:F8}&wallet={5}";

        private static string aSetManualWithdrawParms =
            "?id={0}&email={1}&password={2}&manualwithdraw={3}&amount={4:F8}&wallet={5}";

        private static string aBuyCloudParams = "?id={0}&email{1}&password={3}&amount={4:F8}&convertto={5}";
        private static string aEstimateParams = "?exchangefee=true&convertfrom={0}&amount={1:F8}&convertto={2}";
        private static string aRateParams = "?coin={0}";

        private static string aSupportedCoins = "?supportedcoins=true&currency={0}";
        private static string aSupportedFiat = "?supportedfiat=true";

        private static string aJsonUrl = "&json=true";



        public static async Task<string> GetURLResult(string aUrl, bool aDebug = false, bool json = false)
        {
            if (json)
            {
                aUrl = aUrl + aJsonUrl;
            }

            if (aDebug)
            {
                return aUrl;
            }
            else
            {

                return
                    await RequestAPI();

                async Task<string> RequestAPI()
                {
                    WebRequest myRequest = WebRequest.Create(aUrl);

                    Stream myStream = myRequest.GetResponse().GetResponseStream();

                    StreamReader myReader = new StreamReader(myStream);

                    string myResult = "";

                    while (!myReader.EndOfStream)
                    {
                        myResult = myResult + myReader.ReadLine();
                    }

                    return myResult;
                }
            }
        }

        public static string GetBalances(string aUserId) => aBaseUrl + String.Format(aGetBalanceParams, aUserId);

        public static string GetMiningMode(string aUserId) => aBaseUrl + String.Format(aGetMiningModeParams, aUserId);

        public static string GetSpeeds(string aUserId) => aBaseUrl + String.Format(aGetSpeedParams, aUserId);

        public static string GetDepositAddress(string aUserId, string aCurrency) => aBaseUrl + String.Format(aGetDepositAddressParams, aUserId, aCurrency);

        public static string SetMiningMode(string aUserId, string aEmail, string aPassword, string aCurrency) => GetURLResult( aBaseUrl + String.Format(aSetMiningModeParams, aUserId, aEmail, aPassword, aCurrency)).Result;

        public static string SetAutomaticWithdraw(string aUserId, string aEMail, string aPassword, string aCurrency,
            double aAmount, string aWallet) => GetURLResult(aBaseUrl +
                       String.Format(System.Globalization.CultureInfo.GetCultureInfo("en-EN"), aSetAutoWithdrawParms, aUserId, aEMail, aPassword, aCurrency, aAmount, aWallet)).Result;

        public static string SetManualWithdraw(string aUserId, string aEMail, string aPassword, string aCurrency,
            double aAmount, string aWallet) => GetURLResult(aBaseUrl +
                       String.Format(System.Globalization.CultureInfo.GetCultureInfo("en-EN"), aSetManualWithdrawParms, aUserId, aEMail, aPassword, aCurrency, aAmount, aWallet)).Result;

        public static string BuyCloud(string aUserId, string aEMail, string aPassword, string aCurrencyFrom,
            float aAmount, string aCurrencyTo) => GetURLResult(aBaseUrl + String.Format(System.Globalization.CultureInfo.GetCultureInfo("en-EN"), aBuyCloudParams, aUserId, aEMail, aPassword, aCurrencyFrom, aAmount, aCurrencyTo)).Result;

        public static string EstimateFee(string aCurrencyFrom, double aAmount, string aCurrencTo) => aBaseUrl + String.Format(System.Globalization.CultureInfo.GetCultureInfo("en-EN"), aEstimateParams, aCurrencyFrom, aAmount, aCurrencTo);

        public static double GetRate(string aCurrency) => JObject.Parse(GetURLResult(aBaseUrl + String.Format(aRateParams, aCurrency), false, true).Result)[aCurrency].Value<Double>();

        //public static double GetBalance(string aUserId, string aCurrency) => GetBalances(aUserId).AsJsonObject().Result[aCurrency].Value<double>();

        public static async Task<double> GetBalance(string aUserId, string aCurrency)
        {
            JObject myVal = await AsJsonObject(GetBalances(aUserId));

            return myVal[aCurrency].Value<double>();
        }

        public static double GetSpeed(string aUserId, string aMiningType) => GetSpeeds(aUserId).AsJsonObject().Result[aMiningType].Value<double>();
        
        public static string AsString(this string aUrl) => GetURLResult(aUrl).Result;

        public static async Task<JObject> AsJsonObject(this string aUrl)
        {
            string myResult = await GetURLResult(aUrl, false, true);

            return JObject.Parse(myResult);
        }

        public static async Task<JObject> GetSupportedCoins(string aBaseCurrency)
        {
            string myResult = await GetURLResult(aBaseUrl + String.Format(aSupportedCoins, aBaseCurrency), false, true);

            JObject Coins = JObject.Parse(myResult);
            return Coins;
        }

        public static async Task<JObject> GetSupportedFiat(string aBaseCurrency)
        {
            string myResult = await GetURLResult(aBaseUrl + String.Format(aSupportedFiat, aBaseCurrency), false, true);

            JObject Coins = JObject.Parse(myResult);
            return Coins;
        }
    }
}
