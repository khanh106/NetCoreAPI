using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string strOutput = "Xin chào user có Id là " + ps.PersonId +" có họ và tên là " + ps.FullName+ " địa chỉ ở" + ps.Address;
            ViewBag.infoPerson = strOutput;
            return View();
        }
    }

}