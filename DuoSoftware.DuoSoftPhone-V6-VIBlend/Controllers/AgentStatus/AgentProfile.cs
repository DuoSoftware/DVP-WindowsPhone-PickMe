using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;
using DuoSoftware.DuoSoftPhone.Controllers.Service;
using DuoSoftware.DuoTools.DuoLogger;
using Newtonsoft.Json.Linq;
using Quobject.Collections.Immutable;
using Quobject.SocketIoClientDotNet.Client;
using System.Data;
using DuoCallTesterLicenseKey;
using System.Text;
using System.Security.Cryptography;

namespace DuoSoftware.DuoSoftPhone.Controllers.AgentStatus
{
    

    public struct Server
    {
        public string token;
        public string domain;
        public string websocketUrl;
        public string outboundProxy;
        public bool enableRtcwebBreaker;
    }

    public sealed class AgentProfile
    {
        private static volatile AgentProfile instance;
        private static object syncRoot = new Object();
        public NameValueCollection settingObject;
        public JavaScriptSerializer jsonSerializer;

        private AgentProfile()
        {
            settingObject = System.Configuration.ConfigurationSettings.AppSettings;
            jsonSerializer = new JavaScriptSerializer();
            ivrList = new DataTable("ivrlist");
            ivrList.Columns.Add("ExtensionName");
            ivrList.Columns.Add("Extension");
        }

        public static AgentProfile Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new AgentProfile();
                    }
                }

                return instance;
            }
        }
        
        public string id { private set; get; }
        public string localIPAddress { private set; get; }
        public string UserName { private set; get; }
        public string ContactName { private set; get; }
        public string Password { private set; get; }
        public string SipPassword { private set; get; }
        public string displayName { private set; get; }
        public string authorizationName { private set; get; }
        public string publicIdentity { private set; get; }
        public Server server { private set; get; }
        public object veeryFormat { private set; get; }
        public int acwTime { private set; get; }
        public bool autoAnswer { private set; get; }
        public DataTable ivrList { get; set; }

        public bool IsAllowToOutbound { get; private set; }
        private string GetLocalIPAddress()
        {
            try
            {
                string myHost = Dns.GetHostName();

                string myIp = (from ipAddress in Dns.GetHostEntry(myHost).AddressList
                    where ipAddress.IsIPv6LinkLocal == false
                    where ipAddress.IsIPv6Multicast == false
                    where ipAddress.IsIPv6SiteLocal == false
                    where ipAddress.IsIPv6Teredo == false
                    select ipAddress).Select(ipAddress => ipAddress.ToString()).FirstOrDefault();

                if (!IsValidIP(myIp))
                {
                    IPAddress[] myIp1 = Dns.GetHostAddresses(myHost);
                    foreach (IPAddress ipAddress in
                        myIp1.Where(ipAddress => ipAddress.AddressFamily == AddressFamily.InterNetwork))
                    {
                        myIp = ipAddress.ToString();
                        break;
                    }
                }

                return myIp;
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "GetLocalIPAddress", exception,
                    Logger.LogLevel.Error);
                return string.Empty;
            }
        }

        private bool IsValidIP(params object[] list)
        {
            try
            {
                var addr = list[0].ToString();
                //create our match pattern
                //            const string pattern = @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.
                //    ([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";

                const string pattern = "\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}";
                //create our Regular Expression object
                var check = new Regex(pattern);
                //boolean variable to hold the status
                bool valid = false;
                //check to make sure an ip address was provided
                valid = addr != "" && check.IsMatch(addr, 0);
                //return the results
                return valid;
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "IsValidIP", exception, Logger.LogLevel.Error);
                //Console.WriteLine(exception.Message);
                return false;
            }
        }


        private bool GetContactVeeryFormat()
        {
            var url = settingObject["userServiceBaseUrl"] + "Myprofile/veeryformat/veeryaccount";
            var responseData = HttpHandler.MakeRequest(url, "Bearer " + server.token, null, "get");

            var data = jsonSerializer.Deserialize<Dictionary<string, dynamic>>(responseData.ToString());
            if (!data["IsSuccess"]) return false;
            veeryFormat = data["Result"];
            ContactName = data["Result"]["ContactName"]; //Extention
            return true;
        }

        private bool IsAutoAnswerEnable()
        {
            var url = settingObject["userServiceBaseUrl"] + "Phone/Config";
            var responseData = HttpHandler.MakeRequest(url, "Bearer " + server.token, null, "get");

            var data = jsonSerializer.Deserialize<Dictionary<string, dynamic>>(responseData.ToString());
            if (!data["IsSuccess"]) return false;

            VeerySetting.Instance.AutoAnswerDelay = (int)TimeSpan.FromMilliseconds(Convert.ToInt16(data["Result"]["autoAnswerDelay"])).TotalMilliseconds;
            
            return data["Result"]["autoAnswer"];
        }

        
        private void GetSipPassword()
        {
            try
            {
                var url = settingObject["sipuserUrl"] + "SipUser/User/" + ContactName + "/Password?iv";
                var responseData = HttpHandler.MakeRequest(url, "Bearer " + server.token, null, "get");

                var data = jsonSerializer.Deserialize<Dictionary<string, dynamic>>(responseData.ToString());
                SipPassword = LicenseKeyHandler.GetLicenseKey("DuoS123", data["Result"]);


                //string encrypted = "U2FsdGVkX1+TO9w41FPHU9EjMkv1HVMly435lCqfGSw=";

                //var sss = Codec.DecryptStringAES();
                //string decrypted = LicenseKeyHandler.Decrypt<AesManaged>(encrypted, "DuoS123", "5c34d78451312ca4");
                //Console.Write(decrypted);
                //var aa = veeryFormat;
                //var url = settingObject["sipuserUrl"] + "SipUser/User/" + Extention + "/Password";
                //var responseData = HttpHandler.MakeRequest(url, "Bearer " + server.token, null, "get");

                //var data = jsonSerializer.Deserialize<Dictionary<string, dynamic>>(responseData.ToString());

                //SipPassword = LicenseKeyHandler.OpenSSLDecrypt(data["Result"], "DuoS123"); 
                //SipPassword = LicenseKeyHandler.GetLicenseKey("DuoS123", data["Result"]);

                
                
                
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        private void IsAllowToOutboundCall()
        {
            try
            {
                var url = settingObject["userServiceBaseUrl"] + "User/" + UserName + "/Operations/OutboundMode";
                var responseData = HttpHandler.MakeRequest(url, "Bearer " + server.token, null, "get");

                var data = jsonSerializer.Deserialize<Dictionary<string, dynamic>>(responseData.ToString());
                IsAllowToOutbound = data["IsSuccess"];

            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        private void GetIvrList()
        {
            try
            {
                var url = settingObject["sipuserUrl"] + "SipUser/ExtensionsByCategory/IVR";
                var responseData = HttpHandler.MakeRequest(url, "Bearer " + server.token, null, "get");

                var data = jsonSerializer.Deserialize<Dictionary<string, dynamic>>(responseData.ToString());
                foreach(var row in data["Result"]){
                    DataRow rw = ivrList.NewRow();
                    rw["ExtensionName"] = row["ExtensionName"];
                    rw["Extension"] = row["Extension"];
                    ivrList.Rows.Add(rw);
                }                
            }
            catch (Exception)
            {
                
            }
        }

        private struct HandlingTypes
        {
            public string Type;
            public object Contact;
        }

        struct dataArds
        {
            public string ResourceId;
            public HandlingTypes[] HandlingTypes;

        }

        struct dataArdsq
        {
            public string ResourceId;
            public string[] HandlingTypes;

        }


        private bool RegisterWithArds()
        {

            var url = settingObject["ardsUrl"];

            var postData = new dataArds
            {
                ResourceId = id,
                HandlingTypes = new HandlingTypes[]
                {
                    new HandlingTypes()
                    {
                        Type = "CALL",
                        Contact = veeryFormat,
                    }
                }
            };


            var responseData = HttpHandler.MakeRequest(url, "Bearer " + server.token, postData, "post");

            if (responseData == null) return false;
            var data = jsonSerializer.Deserialize<Dictionary<string, dynamic>>(responseData.ToString());
            return data["IsSuccess"];
        }


        public void Unregistration()
        {
            var url = settingObject["ardsUrl"] + "/" + id;
            var responseData = HttpHandler.MakeRequest(url, "Bearer " + server.token, null, "delete");
            Console.WriteLine(responseData);
        }

        public bool Relogin()
        {
          return  Login(UserName, Password);
        }

        public bool Login(string username, string txtPassword)
        {
            try
            {
                
                var userServiceUrl = settingObject["userServiceUrl"];
                var encoded = HttpHandler.Base64Encode("ae849240-2c6d-11e6-b274-a9eec7dab26b:6145813102144258048");

                var authUrl = new Uri(userServiceUrl);

                dynamic data = new JObject();
                data.grant_type = "password";
                data.username = username;
                data.password = txtPassword;
                //["all_all", "profile_veeryaccount", "write_ardsresource", "write_notification", "read_myUserProfile", "read_productivity", "profile_veeryaccount", "resourceid"];
                data.scope =
                    "all_all write_ardsresource write_notification read_myUserProfile read_requestmeta write_sysmonitoring profile_veeryaccount resourceid";


                var token = HttpHandler.MakeRequest(userServiceUrl, "Basic " + encoded, data, "post");
                var dict = jsonSerializer.Deserialize<Dictionary<string, dynamic>>(token);
                var tokenData1 = Jose.JWT.Payload<Dictionary<string, dynamic>>(dict["access_token"]);

                id = tokenData1["context"]["resourceid"];
                publicIdentity = "sip:" + tokenData1["context"]["veeryaccount"]["contact"];
                id = tokenData1["context"]["resourceid"];
                var values = tokenData1["context"]["veeryaccount"]["contact"].ToString().Split('@');
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, string.Format("Login Resourceid : {0}", id), Logger.LogLevel.Info);

                displayName = values[0];
                UserName = username;
                Password = txtPassword;
                authorizationName = values[0];
                server = new Server
                {
                    domain = values[1],
                    outboundProxy = "",
                    enableRtcwebBreaker = false,
                    token = dict["access_token"],
                    websocketUrl = "wss://" + values[1] + ":7443",
                };
                localIPAddress = GetLocalIPAddress();
                acwTime = ardsHandler.GetAcwTime(this);
                var retValue = GetContactVeeryFormat() && RegisterWithArds();
                if (retValue)
                    autoAnswer = IsAutoAnswerEnable();
                GetIvrList();
                GetSipPassword();
                IsAllowToOutboundCall();
                return retValue;
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "Login fail", exception, Logger.LogLevel.Error);
                return false;
            }
        }



        
    }
}