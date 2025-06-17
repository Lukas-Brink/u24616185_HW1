using System.Linq;
using System.Web.Mvc;
using u24616185_HW1.Models;
using u24616185_HW1.ViewModels;

namespace u24616185_HW1.Controllers
{
    public class HomeController : Controller
    {
        // Landing page showing all drivers and vehicles
        public ActionResult Index()
        {
            ViewBag.Drivers = Data.Drivers;
            ViewBag.Vehicles = Data.Vehicles;
            return View();
        }

        // Page to select a service type
        public ActionResult SelectService() => View(Data.ServiceTypes);

        // Booking form filtered by the selected service
        public ActionResult BookingForm(string serviceName)
        {
            if (string.IsNullOrEmpty(serviceName))
                return RedirectToAction(nameof(SelectService));

            var filteredDrivers = Data.Drivers.Where(d => d.ServiceType.Name == serviceName).ToList();
            var filteredVehicles = Data.Vehicles.Where(v => v.ServiceType.Name == serviceName).ToList();

            ViewBag.Drivers = filteredDrivers;

            var viewModel = new BookingFormViewModel
            {
                SelectedServiceName = serviceName,
                Vehicles = filteredVehicles
            };

            return View(viewModel);
        }

        // Booking confirmation page (data via localStorage only)
        public ActionResult BookingConfirmed() => View();

        // Ride history page (data via localStorage only)
        public ActionResult RideHistory() => View();

        // Admin manage page with initial data loaded
        public ActionResult Manage()
        {
            ViewBag.InitialDrivers = Data.Drivers;
            ViewBag.InitialVehicles = Data.Vehicles;
            ViewBag.ServiceTypes = Data.ServiceTypes;
            return View();
        }
    }
}
