using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim.models
{
    public class Servico
    {
        public int IdServico { get; set; }
        public string Tipo { get; set; }
        public decimal Valor { get; set; }
        //ForeignKey
        public Reserva Reserva { get; set; }
        public int IdReserva { get; set; }
        public string NomeHospede { get; set; }
    }
}
