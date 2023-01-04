using Microsoft.AspNetCore.Mvc;
using System;
using RandomPasswordGenerator.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomPasswordGenerator.Controllers
{
    public class GenerateController : Controller
    {
        public IActionResult Generate()
        {
            GeneratorModel model = new GeneratorModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Generatepassword(GeneratorModel model)
        {
            Random random = new Random();
            string passwordGenerated = "";
            int charIntvalue = 0;
            for (int i = 0; i < model.Length; i++)
            {
                charIntvalue = random.Next(33, 126);
                char letter = Convert.ToChar(charIntvalue);
                passwordGenerated += letter;
            }
            model.Password = passwordGenerated;
            return View("Generate", model);
        }
    }
}
