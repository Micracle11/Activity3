using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Activity3.Models;

namespace Activity3.Controllers
{
    public class AnimalController : Controller
    {
        // GET: Animal

        public Class1 Get()
        {
            Class1 a = new Class1();
            a.Animal = "Cheetah";
            a.Color = "Yellow, Black, White";
            a.Size = "67 – 94 cm";
            return a;
        }
    }
}