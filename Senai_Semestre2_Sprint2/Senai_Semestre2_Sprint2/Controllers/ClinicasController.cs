using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai_Semestre2_Sprint2.Domains;
using Senai_Semestre2_Sprint2.Interfaces;
using Senai_Semestre2_Sprint2.Repositories;

namespace Senai_Semestre2_Sprint2.Controllers
{   [Authorize(Roles = "administrador")]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicasController : ControllerBase
    {

        private IClinicasRepository _ClinicasRepository { get; set; }

        public ClinicasController()
        {
            _ClinicasRepository = new ClinicasRepository();
        }


        [HttpGet]
        public IActionResult Listar()
        {

            

            return Ok(_ClinicasRepository.Listar());
        }

        [HttpPost]
        public IActionResult Cadastrar(Clinicas clinica)
        {

            _ClinicasRepository.Cadastrar(clinica);

            return Ok();
        }

        [HttpPut]
        public IActionResult Atualizar(Clinicas clinica)
        {

            _ClinicasRepository.Alterar(clinica);

            return Ok();
        }




        
    }
}