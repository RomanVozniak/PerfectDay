using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PerfectDay.Repositories;
using PerfectDay.Entities;

namespace PerfectDay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ApplicationContex _context;
        [HttpGet]
        public async Task<>()
        {

            return View();
        }
    }
}