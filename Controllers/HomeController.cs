using InterfaceTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace InterfaceTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }
            [HttpPost]
        public IActionResult Privacy(Values v)
        {
            FileStream fs = new FileStream(@"D:\InterfaceTask.txt", FileMode.OpenOrCreate, FileAccess.Write);
                try
            {
                v.Add = v.a + v.b + v.c;
                v.Multi = v.a * v.b * v.c;

                XmlSerializer xs = new XmlSerializer(typeof(Values));
                xs.Serialize(fs, v);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fs.Close();
            }
            return View();
        }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
}
