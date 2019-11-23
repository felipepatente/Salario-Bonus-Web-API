using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalarioBonusAPI.Data;
using SalarioBonusAPI.Models;
using SalarioBonusAPI.Servicos;

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
            this.gerenciarSalario = new GerenciarSalario(context);
        }

        [HttpPost]
        public ActionResult<string> Post([FromBody]SalarioVendedor salarioLiquido)
        {
            SalarioVendedor salario = gerenciarSalario.AdicionarSalario(salarioLiquido);
            IList<SalarioVendedor> salarios = gerenciarSalario.GetSalarioVendedores();

            return Ok(salarios);
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok(gerenciarSalario.GetSalarioVendedores());
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