using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using u24616185_HW1.ViewModels;

namespace u24616185_HW1.Models
{
    public class Booking
    {
        public string Id { get; set; }
        public string DateBooked { get; set; }
        public string PickupTime { get; set; }
        public string PickupAddress { get; set; }
        public string Driver { get; set; }
        public string DriverPhone { get; set; }
        public string Vehicle { get; set; }
        public string PatientPhone { get; set; }
        public bool IsSOS { get; set; }
    }


}
