using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim.models
{
    class Servico
    {
        public string Tipo { get; set; }
        public decimal Valor { get; set; }
        //ForeignKey
        public Reserva Reserva { get; set; }
        public int IdReserva { get; set; }
    }
}
