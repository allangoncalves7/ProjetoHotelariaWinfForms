using ProjetoPim.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim.Data
{
    public class HotelariaContext
    {
        private string connectionString = @"Data Source=PIMHOTELARIAUNIP.mssql.somee.com;Initial Catalog=PIMHOTELARIAUNIP;User ID=allangoncalves_SQLLogin_5;Password=vxr5e2erec";


        #region HOSPEDE
        public bool InserirHospede(models.Hospede hospede)
        {
            try
            {
                var dt = new BancoDataContext(connectionString);
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

        public tbHospede ConsultarHospedeById(int id)
        {
            try
            {
                var dt = new BancoDataContext(connectionString);

                var hospede = dt.tbHospedes.Where(x => x.IdHospede == id).FirstOrDefault();

                if (hospede != null)
                    return hospede;


                return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<tbHospede> ConsultarHospedes()
        {
            try
            {
                var dt = new BancoDataContext(connectionString);

                var hospedes = from hosp in dt.tbHospedes
                               select hosp;

                return hospedes.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        #endregion

        #region RESERVA
        public List<tbReserva> ConsultarReservas()
        {
            try
            {
                var dt = new BancoDataContext(connectionString);

                var reservas = from res in dt.tbReservas
                               select res;

                return reservas.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<tbReserva> ConsultarReservasByDate(DateTime minDate, DateTime maxDate)
        {
            try
            {
                var dt = new BancoDataContext(connectionString);

                var reservas = from res in dt.tbReservas
                               where (res.DtEntrada >= minDate) && (res.DtSaida <= maxDate)
                               select res;

                return reservas.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public bool CadastrarReserva(Reserva reserva)
        {
            try
            {
                var dt = new BancoDataContext(connectionString);
                tbReserva tb = new tbReserva
                {
                    DtEntrada = reserva.DtEntrada,
                    DtSaida = reserva.DtSaida,
                    IdQuarto = reserva.IdQuarto,
                    IdHospede = reserva.IdHospede
                };

                dt.tbReservas.InsertOnSubmit(tb);
                dt.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorrreu um erro. Motivo: " + ex);
            }
        }

        public bool EditarReserva(Reserva reserva)
        {
            try
            {
                var dt = new BancoDataContext(connectionString);

                var update = dt.tbReservas.Where(x => x.IdReserva == reserva.IdReserva).FirstOrDefault();
                update.DtEntrada = reserva.DtEntrada;
                update.DtSaida = reserva.DtSaida;
                update.IdQuarto = reserva.IdQuarto;
                update.IdHospede = reserva.IdHospede;

                dt.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorrreu um erro. Motivo: " + ex);
            }
        }

        public bool ExcluirReserva(int id)
        {
            try
            {
                var dt = new BancoDataContext(connectionString);

                var delete = dt.tbReservas.Where(x => x.IdReserva == id).FirstOrDefault();

                dt.tbReservas.DeleteOnSubmit(delete);
                dt.SubmitChanges();

                return true;

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorrreu um erro. Motivo: " + ex);
            }
        }

        public bool CancelarReserva(int id)
        {
            try
            {
                var dt = new BancoDataContext(connectionString);

                var cancel = dt.tbReservas.Where(x => x.IdReserva == id).FirstOrDefault();

                cancel.StatusReserva = "Cancelada";

                dt.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorrreu um erro. Motivo: " + ex);
            }
        }

        #endregion


        #region QUARTO
        public List<tbQuarto> ConsultarQuartos()
        {
            try
            {
                var dt = new BancoDataContext(connectionString);

                var quartos = from quarto in dt.tbQuartos
                              select quarto;

                return quartos.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public bool InserirQuarto(models.Quarto quarto)
        {
            try
            {
                var dt = new BancoDataContext(connectionString);
                tbQuarto tb = new tbQuarto
                {
                    Descricao = quarto.Descricao,
                    ValorDiaria = quarto.ValorDiaria
                };

                dt.tbQuartos.InsertOnSubmit(tb);
                dt.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorrreu um erro. Motivo: " + ex);
            }
        }

        #endregion

        #region SERVIÇO

        public bool CadastrarServico(Servico servico)
        {
            try
            {
                var dt = new BancoDataContext(connectionString);
                tbServico tb = new tbServico
                {
                    Tipo = servico.Tipo,
                    Valor = servico.Valor,
                    IdReserva = servico.IdReserva
                };

                dt.tbServicos.InsertOnSubmit(tb);
                dt.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorrreu um erro. Motivo: " + ex);
            }
        }

        public List<tbServico> ConsultarServicos()
        {

            try
            {
                var dt = new BancoDataContext(connectionString);

                var servicos = from serv in dt.tbServicos
                              select serv;

                return servicos.
                    OrderByDescending(x => x.IdServico).
                    ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool EditarServico(Servico servico)
        {
            try
            {
                var dt = new BancoDataContext(connectionString);

                var update = dt.tbServicos.Where(x => x.IdServico== servico.IdServico).FirstOrDefault();
                update.Tipo = servico.Tipo;
                update.Valor = servico.Valor;

                dt.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorrreu um erro. Motivo: " + ex);
            }
        }

        public bool ExcluirServico(int id)
        {
            try
            {
                var dt = new BancoDataContext(connectionString);

                var delete = dt.tbServicos.Where(x => x.IdServico == id).FirstOrDefault();

                dt.tbServicos.DeleteOnSubmit(delete);
                dt.SubmitChanges();

                return true;

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorrreu um erro. Motivo: " + ex);
            }
        }

        #endregion
    }
}
