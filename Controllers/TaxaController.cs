using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevSoftPlayerApi1.Controllers
{
    [ApiController]
    [Route("Index")]
    public class TaxaController : Controller
    {
        [HttpGet]
        [Route("TaxaJuros")]
        public IActionResult TaxaJuros()
        {
            var taxa = 0.01;
            return Ok(taxa);
        }
    }
}
