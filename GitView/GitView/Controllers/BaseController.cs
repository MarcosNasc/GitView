using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitView.Controllers
{
    public class BaseController : Controller
    {
        public IConfiguration _configuration { get; set; }
        public BaseController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void SetBaseConfigPublic()
        {
            ViewData["GitUser"] = _configuration["GitUser"];
        }
    }
}
