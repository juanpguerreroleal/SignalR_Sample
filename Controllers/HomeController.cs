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
        private readonly ApplicationDbContext _db;
        public HomeController(IHubContext<DashboardHub> hub, ApplicationDbContext db)
        {
            _hub = hub;
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
