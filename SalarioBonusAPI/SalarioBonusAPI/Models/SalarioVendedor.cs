using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalarioBonusAPI.Models
{
    public class SalarioVendedor
    {
        private int _ID;
        private string _Vendedor;
        private decimal _SalarioFixo;
        private decimal _ValorTotalVendas;
        private decimal _SalarioReceber;

        public int ID
        {
            set
            {
                _ID = value;
            }

            get
            {
                return _ID;
            }
        }

        public string Vendedor
        {
            set
            {
                _Vendedor = value;
            }

            get
            {
                return _Vendedor;
            }
        }

        public decimal SalarioFixo
        {
            set
            {
                _SalarioFixo = value;
            }

            get
            {
                return _SalarioFixo;
            }
        }

        public decimal TotalVendas
        {
            set
            {
                _ValorTotalVendas = value;
            }

            get
            {
                return _ValorTotalVendas;
            }
        }

        public decimal SalarioReceber
        {
            set
            {
                _SalarioReceber = value;
            }

            get
            {
                return _SalarioReceber;
            }
        }        
    }    
}
