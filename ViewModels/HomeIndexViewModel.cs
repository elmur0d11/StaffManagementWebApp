using StaffManagement.Models;
using System.Collections.Generic;

namespace StaffManagement.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Staff> Staffs { get; set; }
    }
}
