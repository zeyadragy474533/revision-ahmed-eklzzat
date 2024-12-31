using Microsoft.AspNetCore.Mvc;
using System.Data.Common;
using revision_ahmed_eklzzat.Data;
using revision_ahmed_eklzzat.Models;

namespace revision_ahmed_eklzzat.Controllers
{
    public class DepartmentController : Controller
    {

        public IActionResult Index()
        {

            return View();
        }
    }
}
