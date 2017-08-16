using DuoSoftware.DuoSoftPhone.Controllers.AgentStatus;
using DuoSoftware.DuoSoftPhone.Controllers.Common;
using DuoSoftware.DuoSoftPhone.Controllers.Service;
using DuoSoftware.DuoTools.DuoLogger;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace DuoSoftware.DuoSoftPhone.Controllers
{
    public class AgentProductivityHandler
    {


        public static ProductivityResponse GetAgentProductivity()
        {
            try
            {
                NameValueCollection settingObject;
                JavaScriptSerializer jsonSerializer;
                settingObject = System.Configuration.ConfigurationSettings.AppSettings;
                jsonSerializer = new JavaScriptSerializer();
                var _agent = AgentProfile.Instance;

                var url = settingObject["resourceServiceUrl"] + _agent.id + "/Productivity";
                var responseData = HttpHandler.MakeRequest(url, "Bearer " + _agent.server.token, null, "get");

                var data = jsonSerializer.Deserialize<ProductivityResponse>(responseData.ToString());
                return data;
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "GetAgentProductivity", exception, Logger.LogLevel.Error);
                return new ProductivityResponse() { IsSuccess = false };
            }
        }

        public static List<string> GetDynamicBreakTypes()
        {
            var reply = new List<string>(); 
            try
            {
                NameValueCollection settingObject;
                JavaScriptSerializer jsonSerializer;
                settingObject = System.Configuration.ConfigurationSettings.AppSettings;
                jsonSerializer = new JavaScriptSerializer();
                var _agent = AgentProfile.Instance;

                var url = settingObject["resourceServiceUrl"] + "BreakTypes/Active";
                var responseData = HttpHandler.MakeRequest(url, "Bearer " + _agent.server.token, null, "get");

                var data = jsonSerializer.Deserialize<BreakInfoResponse>(responseData.ToString());
                
                foreach (BreakInfo item in data.Result)
                {
                    reply.Add(item.BreakType);
                }
               
            }
            catch (Exception exception)
            {
                Logger.Instance.LogMessage(Logger.LogAppender.DuoDefault, "GetDynamicBreakTypes", exception, Logger.LogLevel.Error);
                
            }
            return reply;
        }
    }
}
