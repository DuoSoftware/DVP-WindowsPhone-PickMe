﻿using System;
using DuoSoftware.DuoLogger;
using DuoSoftware.DuoSoftPhone.Controllers.AgentStatus;
using DuoSoftware.DuoSoftPhone.Controllers.Common;
using PortSIP;

namespace DuoSoftware.DuoSoftPhone.Controllers.CallStatus
{
    public class CallIdleState : CallState
    {
        public override void OnAnswer(ref Call call)
        {
            try { throw new NotImplementedException("Invalid Call Status."); } catch (Exception exception) { Logger.Instance.LogMessage(Logger.LoggerFiles.DuoLogger3, "", exception, Logger.LogLevel.Error); }
        }

        public override void OnHold(ref Call call, CallActions callAction)
        {
            try { throw new NotImplementedException("Invalid Call Status."); } catch (Exception exception) { Logger.Instance.LogMessage(Logger.LoggerFiles.DuoLogger3, "", exception, Logger.LogLevel.Error); }
        }

        public override void OnUnHold(ref Call call, CallActions callAction)
        {
            try { throw new NotImplementedException("Invalid Call Status."); } catch (Exception exception) { Logger.Instance.LogMessage(Logger.LoggerFiles.DuoLogger3, "", exception, Logger.LogLevel.Error); }
        }

        public override void OnNoAnswer(ref Call call)
        {
            try { throw new NotImplementedException("Invalid Call Status."); } catch (Exception exception) { Logger.Instance.LogMessage(Logger.LoggerFiles.DuoLogger3, "", exception, Logger.LogLevel.Error); }
        }

        public override void OnReset(ref Call call)
        {
            try { throw new NotImplementedException("Invalid Call Status."); } catch (Exception exception) { Logger.Instance.LogMessage(Logger.LoggerFiles.DuoLogger3, "", exception, Logger.LogLevel.Error); }
        }

        public override void OnDisconnected(ref Call call)
        {
            try { call.CallCurrentState = new CallDisconnectedState(); }
            catch (Exception exception) { Logger.Instance.LogMessage(Logger.LoggerFiles.DuoLogger3, "", exception, Logger.LogLevel.Error); }
        }

        public override void OnTransferReq(ref Call call, CallActions callAction)
        {
            try { throw new NotImplementedException("Invalid Call Status."); } catch (Exception exception) { Logger.Instance.LogMessage(Logger.LoggerFiles.DuoLogger3, "", exception, Logger.LogLevel.Error); }
        }

        public override void OnTranferFail(ref Call call)
        {
            try { throw new NotImplementedException("Invalid Call Status."); } catch (Exception exception) { Logger.Instance.LogMessage(Logger.LoggerFiles.DuoLogger3, "", exception, Logger.LogLevel.Error); }
        }

        public override void OnOperationFail(ref Call call)
        {
             try { throw new NotImplementedException("Invalid Call Status."); } catch (Exception exception) { Logger.Instance.LogMessage(Logger.LoggerFiles.DuoLogger3, "", exception, Logger.LogLevel.Error); }
        }

        public override void OnSwapReq(ref Call call, CallActions callAction)
        {
            try { throw new NotImplementedException("Invalid Call Status."); } catch (Exception exception) { Logger.Instance.LogMessage(Logger.LoggerFiles.DuoLogger3, "", exception, Logger.LogLevel.Error); }
        }

        public override void OnCallReject(ref Call call)
        {
            try { throw new NotImplementedException("Invalid Call Status."); } catch (Exception exception) { Logger.Instance.LogMessage(Logger.LoggerFiles.DuoLogger3, "", exception, Logger.LogLevel.Error); }
        }

        public override void OnEndLinkLine(ref Call call, CallActions callAction)
        {
            try { throw new NotImplementedException("Invalid Call Status."); } catch (Exception exception) { Logger.Instance.LogMessage(Logger.LoggerFiles.DuoLogger3, "", exception, Logger.LogLevel.Error); }
        }

        public override void OnMakeCall(ref Call call)
        {
            try { call.CallCurrentState = new CallTryingState(); }
            catch (Exception exception) { Logger.Instance.LogMessage(Logger.LoggerFiles.DuoLogger3, "", exception, Logger.LogLevel.Error); }
        }

        public override void OnRinging(ref Call call, int callbackIndex, int callbackObject, int sessionId, string statusText, int statusCode)
        {
            call.CallCurrentState = new CallRingingState();
        }

        public override void OnIncoming(ref Call call, int callbackIndex, int callbackObject, int sessionId, string callerDisplayName,
            string caller, string calleeDisplayName, string callee, string audioCodecNames, string videoCodecNames,
            bool existsAudio, bool existsVideo)
        {
            call.CallCurrentState = new CallIncommingState();
        }

        public override void OnTimeout(ref Call call, ref Agent agent)
        {
            try { throw new NotImplementedException("Invalid Call Status."); } catch (Exception exception) { Logger.Instance.LogMessage(Logger.LoggerFiles.DuoLogger3, "", exception, Logger.LogLevel.Error); }
        }

        public override void OnEndCallSession(ref Call call)
        {
            try { throw new NotImplementedException("Invalid Call Status."); } catch (Exception exception) { Logger.Instance.LogMessage(Logger.LoggerFiles.DuoLogger3, "", exception, Logger.LogLevel.Error); }
        }

        public override void OnCallConference(ref Call call)
        {
            try { throw new NotImplementedException("Invalid Call Status."); } catch (Exception exception) { Logger.Instance.LogMessage(Logger.LoggerFiles.DuoLogger3, "", exception, Logger.LogLevel.Error); }
        }

        public override void OnCallConferenceFail(ref Call call)
        {
            try { throw new NotImplementedException("Invalid Call Status."); } catch (Exception exception) { Logger.Instance.LogMessage(Logger.LoggerFiles.DuoLogger3, "", exception, Logger.LogLevel.Error); }
        }

        public override void OnSetStatus(ref Call call)
        {
            try { throw new NotImplementedException("Invalid Call Status."); }
            catch (Exception exception) { Logger.Instance.LogMessage(Logger.LoggerFiles.DuoLogger3, "", exception, Logger.LogLevel.Error); }
        }

        public override void OnSendDTMF(ref Call call, int val)
        {
            
        }

        public override void OnSessinCreate(ref Call call, string sessionId)
        {
             try { throw new NotImplementedException("Invalid Call Status."); } catch (Exception exception) { Logger.Instance.LogMessage(Logger.LoggerFiles.DuoLogger3, "", exception, Logger.LogLevel.Error); }
        }
    }
}