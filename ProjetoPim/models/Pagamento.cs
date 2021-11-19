using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim.models
{
    class Pagamento
    {
        public string Tipo { get; set; }
        public decimal TotalPagamento { get; set; }
        //ForeignKey
        public Reserva Reserva { get; set; }
        public int IdReserva { get; set; }
        //ForeignKey
        public Servico Servico { get; set; }
        public int IdServico { get; set; }
    }
}
