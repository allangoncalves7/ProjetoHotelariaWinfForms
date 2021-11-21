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
        public bool InserirHospede(Hospede hospede)
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

        public bool ExcluirHospede(int id)
        {
            try
            {
                var dt = new BancoDataContext(connectionString);

                var delete = dt.tbHospedes.Where(x => x.IdHospede == id).FirstOrDefault();

                dt.tbHospedes.DeleteOnSubmit(delete);
                dt.SubmitChanges();

                return true;

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorrreu um erro. Motivo: " + ex);
            }
        }

        public bool EditarHospede(Hospede hospede)
        {
            try
            {
                var dt = new BancoDataContext(connectionString);

                var update = dt.tbHospedes.Where(x => x.IdHospede == hospede.IdHospede).FirstOrDefault();
                update.Nome = hospede.Nome;
                update.Cpf = hospede.Cpf;
                update.Email = hospede.Email;
                update.Telefone = hospede.Telefone;

                dt.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorrreu um erro. Motivo: " + ex);
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
        public bool InserirQuarto(Quarto quarto)
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
        
        public tbServico ConsultarServicoByReserva(int idReserva)
        {

            try
            {
                var dt = new BancoDataContext(connectionString);

                var servico = dt.tbServicos.Where(x => x.IdReserva == idReserva).FirstOrDefault();

                return servico;
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

        #region PAGAMENTO


        public bool CadastrarPagamento(Pagamento pagamento)
        {
            try
            {
                var dt = new BancoDataContext(connectionString);
                tbPagamento tb = new tbPagamento();

                tb.IdReserva = pagamento.IdReserva;
                int idserv = pagamento.IdServico;
                if(idserv > 0)
                    tb.IdServico = pagamento.IdServico;
                tb.Tipo = pagamento.Tipo;
                tb.TotalPagamento = pagamento.TotalPagamento;
               

                dt.tbPagamentos.InsertOnSubmit(tb);
                dt.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorrreu um erro. Motivo: " + ex);
            }
        }

        public List<tbPagamento> ConsultarPagamentos()
        {
            try
            {
                var dt = new BancoDataContext(connectionString);

                var pagamentos = from pag in dt.tbPagamentos
                               select pag;

                return pagamentos.
                    OrderByDescending(x => x.IdPagamento).
                    ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public tbPagamento ConsultarPagamentoByReserva(int idReserva)
        {

            try
            {
                var dt = new BancoDataContext(connectionString);

                var pagamento = dt.tbPagamentos.Where(x => x.IdReserva == idReserva).FirstOrDefault();

                return pagamento;
            }

            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool EditarPagamento(Pagamento pagamento)
        {
            try
            {
                var dt = new BancoDataContext(connectionString);

                var update = dt.tbPagamentos.Where(x => x.IdPagamento == pagamento.IdPagamento).FirstOrDefault();
                update.Tipo = pagamento.Tipo;
                update.TotalPagamento = pagamento.TotalPagamento;
                update.IdReserva = pagamento.IdReserva;
                update.IdServico = pagamento.IdServico;

                dt.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorrreu um erro. Motivo: " + ex);
            }
        }

        public bool ExcluirPagamento(int id)
        {
            try
            {
                var dt = new BancoDataContext(connectionString);

                var delete = dt.tbPagamentos.Where(x => x.IdPagamento == id).FirstOrDefault();

                dt.tbPagamentos.DeleteOnSubmit(delete);
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
