using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalR_Sample.Hubs;
using SignalR_Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility.Util;

namespace SignalR_Sample.Controllers
{
    public class ProgrammingLanguageController : Controller
    {
        private IHubContext<DashboardHub> _hub { get; set; }
        private readonly ApplicationDbContext _db;
        public ProgrammingLanguageController(IHubContext<DashboardHub> hub, ApplicationDbContext db)
        {
            _hub = hub;
            _db = db;
        }
        public IActionResult Index()
        {
            List<ProgrammingLanguage> programmingLanguages = _db.ProgrammingLanguages.ToList();
            return View(programmingLanguages);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ActionName(nameof(Add))]
        public async Task<IActionResult> Add_POST(ProgrammingLanguage model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _db.ProgrammingLanguages.Add(model);
                    int entries = await _db.SaveChangesAsync();
                    if (entries > 0)
                    {
                        var list = new List<ProgrammingLanguage>();
                        list.Add(model);
                        await _hub.Clients.All.SendAsync(Constants.GetLanguages, list);
                        return RedirectToAction(nameof(Index));
                    }
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("Exception", e.Message);
                }
            }
            return View(model);
        }
        public async Task<IActionResult> Remove(int id)
        {
            bool success = false;
            var model = _db.ProgrammingLanguages.FirstOrDefault(x => x.Id == id);
            if (model != null)
            {
                _db.ProgrammingLanguages.Remove(model);
                int entries = await _db.SaveChangesAsync();
                if (entries > 0)
                {
                    success = true;
                    await _hub.Clients.All.SendAsync(Constants.RemoveLanguage, id);
                }
            }
            return new JsonResult(new { Success = success });
        }
    }
}
