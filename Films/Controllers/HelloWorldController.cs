﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

namespace Films.Controllers
{
    public class HelloWorldController : Controller
    {
        
        // GET: /HelloWorld/
        
        /*public string Index()
        {
            return "This is my default action...";
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }*/
        public IActionResult Index()
        {
            return View();
        }
    }
}
