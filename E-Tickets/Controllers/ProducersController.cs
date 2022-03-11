using System;
using System.Linq;
using System.Threading.Tasks;
using E_Tickets.Data;
using E_Tickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Tickets.Controllers
{

    public class ProducersController : Controller
    {
        private readonly IProducersService _service;
        public ProducersController(IProducersService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _service.GetAll();
            return View("Index", allProducers);
        }
        // GET: producers/detail/1
        public async Task<IActionResult> Details(int id)
        {
            var producersDetails = await _service.GetByIdAsync(id);
            if (producersDetails == null) return View("NotFound");
            return View(producersDetails);
        }
    }
}