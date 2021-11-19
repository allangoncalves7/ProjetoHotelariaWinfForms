using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim.models
{
    public class Hospede
    {
        public int IdHospede { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DtNasc { get; set; }
        public string Senha { get; set; }
    }
}
