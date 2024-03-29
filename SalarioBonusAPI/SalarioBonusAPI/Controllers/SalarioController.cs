﻿using Microsoft.AspNetCore.Mvc;
using SalarioBonusAPI.Data;
using SalarioBonusAPI.Models;
using SalarioBonusAPI.Servicos;
using System.Collections.Generic;
using System.Linq;

namespace SalarioBonusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalarioController : Controller
    {
        GerenciarSalario gerenciarSalario;
        private SalarioContext context;

        public SalarioController(SalarioContext context)
        {
            this.context = context;
            gerenciarSalario = new GerenciarSalario(context);
        }

        [HttpPost]
        public ActionResult<string> Post([FromBody]SalarioVendedor salarioLiquido)
        {
            SalarioVendedor salario = gerenciarSalario.AdicionarSalario(salarioLiquido);
            
            return Ok(salario);
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            var salariosVendedores = gerenciarSalario.GetSalarioVendedores();

            if (salariosVendedores == null)
            {
                return NotFound();
            }

            return Ok(salariosVendedores);
        }

        [HttpGet("{id}")]
        public ActionResult<SalarioVendedor> Get(int id)
        {
            var salario = context.SalarioVendedor.SingleOrDefault(s => s.ID == id);

            return Ok(salario);
        }

        [HttpDelete("{id}")]
        public ActionResult<SalarioVendedor> Delete(int id)
        {
            IList<SalarioVendedor> salariosVendedores = gerenciarSalario.RemoverSalario(id);
            return Ok(salariosVendedores);
        }

        [HttpPut("{id}")]
        public ActionResult<SalarioVendedor> Put(int id, [FromBody] SalarioVendedor salarioLiquido)
        {
            SalarioVendedor salarioLiquidoAtualizado = gerenciarSalario.AtualizarSalarioLiquido(salarioLiquido, id);

            return Ok(salarioLiquido);
        }
    }
}