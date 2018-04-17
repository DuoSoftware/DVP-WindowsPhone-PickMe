using DuoSoftware.DuoTools.DuoLogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DuoSoftware.DuoSoftPhone.Controllers.Listners
{
    public sealed class UdpClient
    {

        #region Local Variables

        private static volatile UdpClient _instance;
        private static readonly object SyncRoot = new Object();

        Socket socketClient;
        IPAddress broadcast;
        IPEndPoint ep;
        bool UdpClinetEnable = false;

        #endregion

        #region Properties


        #endregion

        #region Constructors

        private UdpClient()
        {
            try
            {
                var settingObject = System.Configuration.ConfigurationSettings.AppSettings;
                if (settingObject["UdpClinetEnable"].ToLower().Equals("true") || settingObject["UdpClinetEnable"].Equals("1"))
                {
                    UdpClinetEnable = true;
                    socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    broadcast = IPAddress.Parse(settingObject["UDPClinetIp"].ToString());
                    ep = new IPEndPoint(broadcast, int.Parse(settingObject["UDPClinetPort"].ToString()));
                }
                else
                {
                    Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "UDP Clinet Disable", Logger.LogLevel.Error);
                }
                
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "UdpClient", exception, Logger.LogLevel.Error);
                throw;
            }
        }



        #endregion

        #region Interface Implementations


        #endregion

        #region Events

        #endregion

        #region Methods

        #region Internal Methods

        #endregion

        #region Private Methods
       
        #endregion

        #region protected Methods

        #endregion

        #region Public Methods

        public static UdpClient Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (SyncRoot)
                    {
                        if (_instance == null)
                            _instance = new UdpClient();
                    }
                }
                return _instance;
            }
        }

        public void SendToChannel(string no)
        {
            try
            {
                if (UdpClinetEnable)
                {
                    byte[] sendbuf = Encoding.ASCII.GetBytes(no);
                    socketClient.SendTo(sendbuf, ep);
                    Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, string.Format("Send UPD Message To Client. {0}", no), Logger.LogLevel.Info);
                }                
                
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "SendToChannel", exception, Logger.LogLevel.Error);
            }
        }  
        #endregion

        #endregion


    }

}
