using DuoSoftware.DuoSoftPhone.Controllers.AgentStatus;
using DuoSoftware.DuoTools.DuoLogger;
using Newtonsoft.Json.Linq;
using Quobject.SocketIoClientDotNet.Client;
using System;


namespace DuoSoftware.DuoSoftPhone.Controllers
{
    public delegate void VeerySocketEvent(object data);

    public class SocketConnector
    {
        public event VeerySocketEvent OnAuthenticated;
        public event VeerySocketEvent OnMessageReceive;
        public event VeerySocketEvent OnAgentFound;
        public event VeerySocketEvent OnAgentSuspended;
        public event VeerySocketEvent OnpreviewDialerMessage;
        Socket socket;


        private void SendAuth()
        {
            new System.Threading.Thread(() =>
            {
                try
                {
                    System.Threading.Thread.Sleep(2000);
                    var jsonObject = new JObject { { "token", AgentProfile.Instance.server.token } };
                    socket.Emit("authenticate", jsonObject);
                }
                catch (Exception exception)
                {
                    Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "SendAuth", exception, Logger.LogLevel.Error);
                }
            }).Start();
        }

        public void Execute()
        {
            try
            {
                var options = new Quobject.SocketIoClientDotNet.Client.IO.Options
                {
                    AutoConnect = false,
                    Reconnection = true,
                    Transports = Quobject.Collections.Immutable.ImmutableList.Create<string>("websocket")
                };

                socket = IO.Socket(AgentProfile.Instance.settingObject["notificationUrl"], options);//ws://192.168.0.67:8089

                socket.On(Socket.EVENT_ERROR, (data) =>
                {
                    Console.WriteLine(data);
                });


                socket.On(Socket.EVENT_CONNECT, (data) =>
                {
                    try
                    {
                        Console.WriteLine(data);
                        //var jsonObject = new JObject { { "token", AgentProfile.Instance.server.token } };
                        //socket.Emit("authenticate", jsonObject);
                        SendAuth();
                    }
                    catch (Exception exception)
                    {
                        Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "EVENT_CONNECT", exception, Logger.LogLevel.Error);
                    }
                });


                socket.On("clientdetails", (data) =>
                {
                    Console.WriteLine(data);
                });


                socket.On("authenticated", (data) =>
                {
                    if (OnAuthenticated != null)
                    {
                        OnAuthenticated(data);
                    }
                });

                socket.On("agent_connected", (data) =>
                {
                    Console.WriteLine(data);
                });

                socket.On("agent_disconnected", (data) =>
                {
                    Console.WriteLine(data);
                });

                socket.On("agent_found", (data) =>
                {
                    if (OnAgentFound != null)
                    {
                        OnAgentFound(data);
                    }
                });

                socket.On("agent_rejected", (data) =>
                {
                    Console.WriteLine(data);
                });

                socket.On("agent_suspended", (data) =>
                {
                    Console.WriteLine(data);
                    if (OnAgentSuspended != null)
                    {
                        OnAgentSuspended(data);
                    }
                });

                socket.On("preview_dialer_message", (data) =>
                {
                    Console.WriteLine(data);
                    if (OnpreviewDialerMessage != null)
                    {
                        OnpreviewDialerMessage(data);
                    }
                });

                socket.On(Socket.EVENT_DISCONNECT, (data) =>
                {
                    Console.WriteLine(data);
                });

                socket.On(Socket.EVENT_CONNECT_ERROR, (data) =>
                {
                    Console.WriteLine(data);
                });

                socket.On(Socket.EVENT_MESSAGE, (data) =>
                {
                    Console.WriteLine(data);
                    if (OnMessageReceive != null)
                    {
                        OnMessageReceive(data);
                    }
                });

                socket.Connect();
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "SocketConnector", exception, Logger.LogLevel.Error);
            }
        }

    }
}
