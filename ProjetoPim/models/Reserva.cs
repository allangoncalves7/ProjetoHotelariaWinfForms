using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim.models
{
    class Reserva
    {
        public DateTime DtEntrada { get; set; }

        public DateTime DtSaida { get; set; }
        public Enum StatusReserva { get; set; }
        //ForeignKey
        public Quarto Quarto { get; set; }
        public int IdQuarto { get; set; }
        //ForeignKey
        public Hospede Hospede { get; set; }
        public int IdHospede { get; set; }
    }
}
