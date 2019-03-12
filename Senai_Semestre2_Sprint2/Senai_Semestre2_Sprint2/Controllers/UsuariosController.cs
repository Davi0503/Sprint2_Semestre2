﻿using System;
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
    public class UsuariosController : ControllerBase
    {
        private IUsuariosRepository _usuariosRepository { get; set; }

        public UsuariosController()
        {
           _usuariosRepository = new UsuariosRepository();
        }

        [HttpGet]

        public IActionResult Listar() {

           

            return Ok(_usuariosRepository.Listar());
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuarios usuario) {

            _usuariosRepository.Cadastrar(usuario);

            return Ok();

        }

    }
}