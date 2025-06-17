using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u24616185_HW1.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string RegistrationNumber { get; set; }
        public string ImageUrl { get; set; }
        public ServiceType ServiceType { get; set; }
    }

}