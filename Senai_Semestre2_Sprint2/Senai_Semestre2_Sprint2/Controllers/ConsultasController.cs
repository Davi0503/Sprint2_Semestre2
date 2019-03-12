using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai_Semestre2_Sprint2.Domains;
using Senai_Semestre2_Sprint2.Repositories;

namespace Senai_Semestre2_Sprint2.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultasController : ControllerBase
    {

        private IConsultasRepository _consultasRepository { get; set; }


        public ConsultasController()
        {
            _consultasRepository = new ConsultasRepository();
        }


        [HttpGet]

        public IActionResult Listar() {

            

            return Ok(_consultasRepository.Listar());
        }

        [HttpPost]

        public IActionResult Cadastrar(Consultas consulta)
        {
            _consultasRepository.Cadastrar(consulta);

            return Ok();
        }


        [HttpPut]

        public IActionResult Atualizar(Consultas consulta
            )
        {

            _consultasRepository.Atualizar(consulta);


            return Ok();

        }






    }
}