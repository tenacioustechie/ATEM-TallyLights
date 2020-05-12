using BMDSwitcherAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtemServer.BackgroundService.Switcher
{
    public class SwitcherMonitor : IBMDSwitcherCallback
    {
        // Events:
        public event SwitcherEventHandler SwitcherDisconnected;

        public SwitcherMonitor()
        {
        }

        void IBMDSwitcherCallback.Notify(_BMDSwitcherEventType eventType, _BMDSwitcherVideoMode coreVideoMode)
        {
            if (eventType == _BMDSwitcherEventType.bmdSwitcherEventTypeDisconnected)
            {
                if (SwitcherDisconnected != null)
                    SwitcherDisconnected(this, null);
            }
        }
    }
}
