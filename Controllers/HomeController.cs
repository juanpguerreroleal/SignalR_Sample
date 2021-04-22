using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using SignalR_Sample.Hubs;
using SignalR_Sample.Models;
using SignalR_Sample.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR_Sample.Controllers
{
    public class HomeController : Controller
    {
        private IHubContext<DashboardHub> _hub { get; set; }
        public HomeController(IHubContext<DashboardHub> hub)
        {
            _hub = hub;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Privacy()
        {
            DashboardViewModel model = new DashboardViewModel();
            model.ProgrammingLanguages = new List<ProgrammingLanguage>();
            model.ProgrammingLanguages.Add(new ProgrammingLanguage() { Id = 1, Name = "C#", Description = "Microsoft Language C#" });
            await _hub.Clients.All.SendAsync("GetProgrammingLanguages", model.ProgrammingLanguages);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
