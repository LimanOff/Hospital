using Hospital.Models.Infrastucture;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
    public class ClientController : Controller
    {
        [HttpGet]
        public IActionResult PatientRegistration() => View();

        [HttpPost]
        public IActionResult PatientRegistration(Patient patient)
        {
            return View();
        }

        [HttpGet]
        public IActionResult PatientCard() => View();

        [HttpPost]
        public IActionResult LoadPatientCard()
        {
            return RedirectToAction("PatientCard");
        }
    }
}
