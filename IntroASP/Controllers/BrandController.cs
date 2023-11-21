using IntroASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroASP.Controllers
{
    public class BrandController : Controller
    {
        private readonly PubContext _context;

        public BrandController(PubContext context) {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {


            return View(await _context.Brands.ToListAsync());
        }
    }
}
