using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using u24616185_HW1.ViewModels;

namespace u24616185_HW1.Models
{
    public static class Data
    {
        public static List<ServiceType> ServiceTypes = new List<ServiceType>

{
    new ServiceType
    {
        Name = "ALS (Advanced Life Support)",
        Description = "Provides advanced life support with paramedics and advanced equipment.",
        ImageUrl = "/Images/Paramedic_ExploreCareers1024X512.jpg"
    },
    new ServiceType
    {
        Name = "BLS (Basic Life Support)",
        Description = "Basic life support including CPR and first aid.",
        ImageUrl = "/Images/maxresdefault.jpg"
    },
    new ServiceType
    {
        Name = "Patient Transport",
        Description = "Non-emergency patient transport services.",
        ImageUrl = "/Images/090A0250-Edit.jpg"
    },
    new ServiceType
    {
        Name = "Medical Utility Vehicle",
        Description = "Vehicles for medical utility support and equipment transport.",
        ImageUrl = "/Images/images.jpg"
    },
    new ServiceType
    {
        Name = "Event Medical Ambulance",
        Description = "Medical ambulance services for events and large gatherings.",
        ImageUrl = "/Images/AMS-event-set-up-1024x768.jpg"
    },
    new ServiceType
    {
        Name = "Air Ambulance",
        Description = "Emergency air medical evacuation and transport.",
        ImageUrl = "/Images/blog_thumbnail1686218464.jpg"
    }
};


        public static List<Driver> Drivers = new List<Driver>
        {
            new Driver { Id = 1, FirstName = "John", LastName = "Smith", PhoneNumber = "0712345678", ImageUrl = "/Images/driver1.jpg", ServiceType = ServiceTypes[0] },
            new Driver { Id = 2, FirstName = "Jane", LastName = "Doe", PhoneNumber = "0723456789", ImageUrl = "/Images/driver2.jpg", ServiceType = ServiceTypes[1] },
            new Driver { Id = 3, FirstName = "Mike", LastName = "Jordan", PhoneNumber = "0734567890", ImageUrl = "/Images/driver3.jpg", ServiceType = ServiceTypes[2] },
            new Driver { Id = 4, FirstName = "Emily", LastName = "Taylor", PhoneNumber = "0745678901", ImageUrl = "/Images/driver4.jpg", ServiceType = ServiceTypes[3] },
            new Driver { Id = 5, FirstName = "Chris", LastName = "Brown", PhoneNumber = "0756789012", ImageUrl = "/Images/driver5.jpg", ServiceType = ServiceTypes[4] },
            new Driver { Id = 6, FirstName = "Natalie", LastName = "Green", PhoneNumber = "0767890123", ImageUrl = "/Images/driver6.jpg", ServiceType = ServiceTypes[5] },
            new Driver { Id = 7, FirstName = "Daniel", LastName = "Miller", PhoneNumber = "0778901234", ImageUrl = "/Images/driver7.jpg", ServiceType = ServiceTypes[0] },
            new Driver { Id = 8, FirstName = "Sarah", LastName = "Wilson", PhoneNumber = "0789012345", ImageUrl = "/Images/driver8.jpg", ServiceType = ServiceTypes[1] },
            new Driver { Id = 9, FirstName = "Liam", LastName = "Johnson", PhoneNumber = "0790123456", ImageUrl = "/Images/driver9.jpg", ServiceType = ServiceTypes[2] },
            new Driver { Id = 10, FirstName = "Olivia", LastName = "Lee", PhoneNumber = "0701234567", ImageUrl = "/Images/driver10.jpg", ServiceType = ServiceTypes[4] }
        };

        public static List<Vehicle> Vehicles = new List<Vehicle>
        {
            new Vehicle { Id = 1, Type = "Type I", RegistrationNumber = "ALS123GP", ImageUrl = "/Images/vehicle1.jpg", ServiceType = ServiceTypes[0] },
            new Vehicle { Id = 2, Type = "Type II", RegistrationNumber = "BLS456GP", ImageUrl = "/Images/vehicle2.jpg", ServiceType = ServiceTypes[1] },
            new Vehicle { Id = 3, Type = "Patient Van", RegistrationNumber = "PT789GP", ImageUrl = "/Images/vehicle3.jpg", ServiceType = ServiceTypes[2] },
            new Vehicle { Id = 4, Type = "Utility Van", RegistrationNumber = "MU012GP", ImageUrl = "/Images/vehicle4.jpg", ServiceType = ServiceTypes[3] },
            new Vehicle { Id = 5, Type = "Event Support", RegistrationNumber = "EV345GP", ImageUrl = "/Images/vehicle5.jpg", ServiceType = ServiceTypes[4] },
            new Vehicle { Id = 6, Type = "Helicopter", RegistrationNumber = "AIR678GP", ImageUrl = "/Images/vehicle6.jpg", ServiceType = ServiceTypes[5] },
            new Vehicle { Id = 7, Type = "Type I", RegistrationNumber = "ALS901GP", ImageUrl = "/Images/vehicle7.jpg", ServiceType = ServiceTypes[0] },
            new Vehicle { Id = 8, Type = "Type II", RegistrationNumber = "BLS234GP", ImageUrl = "/Images/vehicle8.jpg", ServiceType = ServiceTypes[1] },
            new Vehicle { Id = 9, Type = "Transport Van", RegistrationNumber = "PT567GP", ImageUrl = "/Images/vehicle9.jpg", ServiceType = ServiceTypes[2] },
            new Vehicle { Id = 10, Type = "Event SUV", RegistrationNumber = "EV890GP", ImageUrl = "/Images/vehicle10.jpg", ServiceType = ServiceTypes[4] }
        };

    }

}
