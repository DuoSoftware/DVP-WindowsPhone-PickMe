using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuoSoftware.DuoSoftPhone.Ui
{
    public enum DialerState
    {
        Initiate,
        NotOnCall,
        CallRouted,
        CallIncoming,
        CallOutgoing,
        OnHold,
        AgentSupervisorTalking,
        AgentClientTalking,
        Conference,
        etlCall,
        swapCall,
        transferCall,
        transferIvr,
        Error,
    }
}
