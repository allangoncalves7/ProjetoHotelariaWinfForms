using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim.models
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public DateTime DtEntrada { get; set; }

        public DateTime DtSaida { get; set; }
        public string StatusReserva { get; set; }
        //ForeignKey
        public int IdHospede{ get; set; }
        public string NomeHospede{ get; set; } 
        public int IdQuarto{ get; set; }
        public string DescQuarto{ get; set; }
        public decimal ValorDiaria { get; set; }

    }
}
