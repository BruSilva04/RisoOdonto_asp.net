using RisoOdonto.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisoOdonto.DAL
{
    public class AgendamentoDAL : Conexao
    {

        //CRUD
        //Read
        public List<AgendamentoDTO> ListarAgenda()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdAgendamento, IdPaciente, IdDentista, DataConsulta, Horario, PrimeiraConsulta, StatusConsulta FROM Agendamento INNER JOIN IdAgendamento ON IdPaciente = Paciente ORDER BY IdAgendamento ASC INNER JOIN IdDentista;", conn);
                dr = cmd.ExecuteReader();
                List<AgendamentoDTO> lista = new List<AgendamentoDTO>();
                while (dr.Read())
                {
                    AgendamentoDTO obj = new AgendamentoDTO();
                    obj.IdAgendamento = Convert.ToInt32(dr["IdAgendamento"]);
                    obj.IdPaciente = Convert.ToInt32(dr["IdPaciente"]);
                    obj.IdDentista = Convert.ToInt32(dr["IdDentista"]);
                    obj.DataConsulta = Convert.ToDateTime(dr["DataConsulta"]);
                    obj.Horario = Convert.ToDateTime(dr["Horario"]);
                    obj.PrimeiraConsulta = Convert.ToBoolean(dr["PrimeiraConsulta"]);
                    obj.StatusConsulta = dr["StatusConsulta"].ToString();
                    lista.Add(obj);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
