using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u24616185_HW1.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageUrl { get; set; }
        public ServiceType ServiceType { get; set; }
    }

}