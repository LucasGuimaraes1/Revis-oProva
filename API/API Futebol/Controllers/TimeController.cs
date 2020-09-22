using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A.P.I_Futebol.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace A.P.I_Futebol.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Listagem de todos os times");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok("Listagem de time específico");
        }

        [HttpPost]
        public async Task<IActionResult> Post(Time time)
        {
            return Ok("Cadastro de time efetuado com sucesso");
        }
    }
}
