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

namespace EobotAPI
{
    public static class GetBasics
    {
        private static string aBaseUrl = @"https://www.eobot.com/api.aspx?";
        private static string aGetBalanceParams = "total={0}";
        private static string aGetMiningModeParams = "idmining={0}";
        private static string aGetSpeedParams = "idspeed={0}";
        private static string aGetDepositAddressParams = "id={0}&deposit={1}";
        private static string aSetMiningModeParams = "id={0}&email={1}&password={2}&mining={3}";
        private static string aSetAutoWithdrawParms = "id={0}&email={1}&password={2}&withdraw={3}&amount={4:F8}&wallet={5}";

        private static string aSetManualWithdrawParms =
            "id={0}&email={1}&password={2}&manualwithdraw={3}&amount={4:F8}&wallet={5}";

        private static string aBuyCloudParams = "id={0}&email{1}&password={3}&amount={4:F8}&convertto={5}";
        private static string aEstimateParams = "exchangefee=true&convertfrom={0}&amount={1:F8}&convertto={2}";
        private static string aRateParams = "&coin={0}";

        private static string aJsonUrl = "&json=true";
     


        public static string GetRestResult(string aUrl, bool aDebug=false, bool json=false)
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

        public static string GetBalances(string aUserId)
        {
            var aUrl = aBaseUrl + String.Format(aGetBalanceParams, aUserId);

            return aUrl;
        }

        public static string GetMiningMode(string aUserId)
        {
            var aUrl = aBaseUrl + String.Format(aGetMiningModeParams, aUserId);

            return aUrl;
        }

        public static string GetSpeeds(string aUserId)
        {
            var aUrl = aBaseUrl + String.Format(aGetSpeedParams, aUserId);

            return aUrl;
        }

        public static string GetDepositAddress(string aUserId, string aCurrency)
        {
            var aUrl = aBaseUrl + String.Format(aGetDepositAddressParams, aUserId, aCurrency);

            return aUrl;
        }

        public static string SetMiningMode(string aUserId, string aEmail, string aPassword, string aCurrency)
        {
            var aUrl = aBaseUrl + String.Format(aSetMiningModeParams, aUserId, aEmail, aPassword, aCurrency);

            return GetRestResult(aUrl);
        }

        public static string SetAutomaticWithdraw(string aUserId, string aEMail, string aPassword, string aCurrency,
            float aAmount, string aWallet)
        {
            var aUrl = aBaseUrl +
                       String.Format(System.Globalization.CultureInfo.GetCultureInfo("en-EN"), aSetAutoWithdrawParms, aUserId, aEMail, aPassword, aCurrency, aAmount, aWallet);

            return GetRestResult(aUrl);
        }

        public static string SetManualWithdaw(string aUserId, string aEMail, string aPassword, string aCurrency,
            float aAmount, string aWallet)
        {
            var aUrl = aBaseUrl +
                       String.Format(System.Globalization.CultureInfo.GetCultureInfo("en-EN"), aSetManualWithdrawParms, aUserId, aEMail, aPassword, aCurrency, aAmount, aWallet);

            return GetRestResult(aUrl);
        }

        public static string BuyCloud(string aUserId, string aEMail, string aPassword, string aCurrencyFrom,
            float aAmount, string aCurrencyTo)
        {
            var aUrl = aBaseUrl + String.Format(System.Globalization.CultureInfo.GetCultureInfo("en-EN"),aBuyCloudParams, aUserId, aEMail, aPassword, aCurrencyFrom, aAmount, aCurrencyTo);

            return GetRestResult(aUrl);
        }

        public static string EstimateFee(string aCurrencyFrom, float aAmount, string aCurrencTo)
        {
            var aUrl = aBaseUrl + String.Format(System.Globalization.CultureInfo.GetCultureInfo("en-EN"),aEstimateParams, aCurrencyFrom, aAmount, aCurrencTo);

            return aUrl;
        }

        public static double GetRate(string aCurrency)
        {
            var aUrl = aBaseUrl + String.Format(aRateParams, aCurrency);

            JObject myJson = JObject.Parse(GetRestResult(aUrl, false, true));

            return myJson[aCurrency].Value<double>();
        }

        public static double GetBalance(string aUserId, string aCurrency)
        {
            return GetBalances(aUserId).AsJsonObject()[aCurrency].Value<double>();
        }

        public static double GetSpeed(string aUserId, string aMiningType)
        {
            return GetSpeeds(aUserId).AsJsonObject()[aMiningType].Value<double>();
        }

        public static string AsString(this string aUrl)
        {
            return GetRestResult(aUrl);
        }

        public static JObject AsJsonObject(this string aUrl)
        {
            JObject myJson = JObject.Parse(GetRestResult(aUrl, false, true));
            return myJson;
        }
    }
}
