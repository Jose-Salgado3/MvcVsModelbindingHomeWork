using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcVsModelbindingHomeWork.Controllers
{
    public class VehicleController : Controller
    {
        public IActionResult Registration()
        {
            return View();
        }
    }
}