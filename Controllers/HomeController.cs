using System.Linq;
using System.Web.Mvc;
using u24616185_HW1.Models;
using u24616185_HW1.ViewModels;

namespace u24616185_HW1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Drivers = Data.Drivers;
            ViewBag.Vehicles = Data.Vehicles;
            return View();
        }


        public ActionResult SelectService() => View(Data.ServiceTypes);


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


        public ActionResult BookingConfirmed() => View();


        public ActionResult RideHistory() => View();


        public ActionResult Manage()
        {
            ViewBag.InitialDrivers = Data.Drivers;
            ViewBag.InitialVehicles = Data.Vehicles;
            ViewBag.ServiceTypes = Data.ServiceTypes;
            return View();
        }
    }
}
