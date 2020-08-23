using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Wholesale.Web.Areas.Management.Controllers
{
   
    public class HomeController : BaseController
    {
        public IActionResult Index() => View();
    }
}