﻿using APIModelo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIModelo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        [HttpGet("GetPessoa")]
        public Pessoa Getpessoa()
        {
            Pessoa vPessoa = new Pessoa();
            vPessoa.Id = 1;
            vPessoa.Nome = "Jóse das couves";
            vPessoa.NumeroCelular = "(18) 98569-6547";

            return vPessoa;
        }

        [HttpGet("GetPessoas")] 

        public List<Pessoa> GetPessoas()
        {
            var vPessoa = new Pessoa();



            return vPessoa.Dados();
        }
    }
}
