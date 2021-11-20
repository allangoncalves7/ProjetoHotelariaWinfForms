using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim.models
{
    public class Pagamento
    {
        public int IdPagamento { get; set; }
        public string Tipo { get; set; }
        public decimal TotalPagamento { get; set; }
        //ForeignKey
        public int IdReserva { get; set; }
        public decimal ValorReserva { get; set; }
        //ForeignKey
        public int IdServico { get; set; }
        public decimal ValorServico { get; set; }
        public string NomeHospede { get; set; }
    }
}
