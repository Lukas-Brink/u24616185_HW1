using System.Collections.Generic;
using u24616185_HW1.Models;

namespace u24616185_HW1.ViewModels
{
    public class BookingFormViewModel
    {
        public string SelectedServiceName { get; set; }
        public List<Driver> Drivers { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}
