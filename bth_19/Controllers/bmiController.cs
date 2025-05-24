using Microsoft.AspNetCore.Mvc;
using BMICalculator.Models;

namespace BMICalculator.Controllers
{
    public class bmiController : Controller
    {
        // GET: Home
        public ActionResult view()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculate(BMIModel model)
        {
            if (ModelState.IsValid)
            {
                double bmi = model.Weight / (model.Height * model.Height);
                ViewBag.BMIResult = $"Your BMI is: {bmi:F2}";
            }
            else
            {
                ViewBag.BMIResult = "Invalid input. Please check your weight and height.";
            }

            return View("view", model);
        }
    }
}