using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim.Data
{
    public class HortelariaContext
    {
        private string conexionString = @"Data Source=LAPTOP-0I533N03\SQLEXPRESS;Initial Catalog=testH;Integrated Security=True";

        public bool InserirHospede(models.Hospede hospede)
        {
            try
            {
                var dt = new BancoDataContext(conexionString);
                tbHospede tb = new tbHospede
                {
                    Nome = hospede.Nome,
                    Cpf = hospede.Cpf,
                    Email = hospede.Email,
                    DtNasc = hospede.DtNasc,
                    Telefone = hospede.Telefone,
                    Senha = hospede.Senha
                };

                dt.tbHospedes.InsertOnSubmit(tb);
                dt.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorrreu um erro. Motivo: " + ex);
            }
            


        }
    }
}
