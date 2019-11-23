using SalarioBonusAPI.Data;
using SalarioBonusAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalarioBonusAPI.Servicos
{
    public class GerenciarSalario
    {
        private SalarioContext context;

        public GerenciarSalario(SalarioContext context)
        {
            this.context = context;            
        }


        public SalarioVendedor AdicionarSalario(SalarioVendedor salario)
        {
            CalcularSalario calcular = new CalcularSalario();
            salario.SalarioReceber = calcular.GetSalarioLiquido(salario);

            context.SalarioVendedor.Add(salario);
            context.SaveChanges();

            return salario;
        }

        public IList<SalarioVendedor> GetSalarioVendedores()
        {            
            var salarios = context.SalarioVendedor.ToList();

            return salarios;
        }
        
        public IList<SalarioVendedor> RemoverSalario(int id)
        {
            var salario = context.SalarioVendedor.SingleOrDefault(s => s.ID == id);

            context.SalarioVendedor.Remove(salario);
            context.SaveChanges();

            return context.SalarioVendedor.ToList();

        }

        public SalarioVendedor AtualizarSalarioLiquido(SalarioVendedor salarioLiquidoNew, int id)
        {
            CalcularSalario calcularSalario = new CalcularSalario();

            salarioLiquidoNew.ID = id;
            salarioLiquidoNew.SalarioReceber = calcularSalario.GetSalarioLiquido(salarioLiquidoNew);

            context.SalarioVendedor.Update(salarioLiquidoNew);
            context.SaveChanges();


            return context.SalarioVendedor.SingleOrDefault(s => s.ID == id);
        }
    }
}
