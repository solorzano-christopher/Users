﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Users.Models;

namespace Users.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() =>
        View(new Dictionary<string, object>
        { ["Placeholder"] = "Placeholder" });
    }
}
