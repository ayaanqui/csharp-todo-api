using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Controllers
{
    public class Rando
    {
        public int Number { get; set; }
        public string Me { get; set; }
    }


    [Route("api/[controller]")]
    [ApiController]
    public class RandoController : ControllerBase
    {
        [HttpGet]
        public Rando Get()
        {
            Rando r = new Rando();
            r.Number = 10;
            r.Me = "Loop";
            return r;
        }
    }
}
