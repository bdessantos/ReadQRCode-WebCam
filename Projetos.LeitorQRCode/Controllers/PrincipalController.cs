using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Projetos.LeitorQRCode.Controllers
{
    public class PrincipalController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
