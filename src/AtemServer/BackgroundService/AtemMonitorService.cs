using AtemServer.BackgroundService.Switcher;
using BMDSwitcherAPI;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AtemServer.BackgroundService
{
    public class AtemMonitorService : BackgroundService
    {
        private IBMDSwitcherDiscovery _switcherDiscovery;
        private IBMDSwitcher _switcher;
        private SwitcherMonitor _switcherMonitor;
        private InputMonitor _inputMonitor;

        public AtemMonitorService(IServiceScopeFactory scopeFactory) : base(scopeFactory)
        {
            _switcherMonitor = new SwitcherMonitor();
            _switcherMonitor.SwitcherDisconnected += new SwitcherEventHandler((s, a) => SwitcherDisconnected());
        }

        private void SwitcherDisconnected()
        {
            throw new NotImplementedException();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

            while (!stoppingToken.IsCancellationRequested)
            {
                
            }
        }
    }
}
