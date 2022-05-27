using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Details.Controllers
{
    public class EnrolmentController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
