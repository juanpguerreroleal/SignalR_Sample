using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR_Sample.ViewModels
{
    public class DashboardViewModel
    {
        public List<ProgrammingLanguage> ProgrammingLanguages { get; set; }
    }
    public class ProgrammingLanguage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
