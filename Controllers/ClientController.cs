using Hospital.Models.Infrastucture;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Hospital.Controllers
{
    public class ClientController : Controller
    {
        private readonly MainContext _context;

        public ClientController(MainContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult PatientRegistration() => View();

        [HttpGet]
        public IActionResult PatientCard() => View();


        [HttpPost]
        public IActionResult PatientRegistration(Patient patient)
        {
            return View();
        }

        [HttpPost]
        public void AddPatientImageLink()
        {
            Console.WriteLine("Добавлено изображение пациента");
        }

        [HttpPost]
        public IActionResult LoadPatientCard()
        {
            return RedirectToAction("PatientCard");
        }
    }
}
