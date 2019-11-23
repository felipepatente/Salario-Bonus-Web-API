using SalarioBonusAPI.Models;

namespace SalarioBonusAPI.Servicos
{
    public class CalcularSalario
    {
        private decimal comissao = 0.15m;

        public decimal GetSalarioLiquido(SalarioVendedor salario)
        {
            return (salario.ValorTotalVendas * comissao) + salario.SalarioFixo;
        }
    }
}
