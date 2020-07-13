using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class EmployerDetailViewModel
    {
        public int EmployerId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public EmployerDetailViewModel(Employer theEmployer)
        {
            EmployerId = theEmployer.Id;
            Name = theEmployer.Name;
            Location = theEmployer.Location;
        }
    }
}
