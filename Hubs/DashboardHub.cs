using Microsoft.AspNetCore.SignalR;
using SignalR_Sample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility.Util;

namespace SignalR_Sample.Hubs
{
    public class DashboardHub: Hub
    {
        public async Task SendDashboard(List<ProgrammingLanguage> programmingLanguages)
        {
            await Clients.All.SendAsync(Constants.GetLanguages, programmingLanguages);
        }
        public async Task Remove(int programmingLanguageId)
        {
            await Clients.All.SendAsync(Constants.RemoveLanguage, programmingLanguageId);
        }
    }
}
