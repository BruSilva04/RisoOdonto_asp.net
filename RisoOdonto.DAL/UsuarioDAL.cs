using RisoOdonto.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace RisoOdonto.DAL
{
    public class UsuarioDAL: Conexao
    {
        //autenticacao
        public UsuarioDTO AutenticarCliente(string Email, string Senha)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Paciente WHERE Email=@Email AND Senha=@Senha;", conn);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Senha", Senha);
                dr = cmd.ExecuteReader();
                UsuarioDTO obj = null; //ponteiro
                if (dr.Read())
                {
                    obj = new UsuarioDTO();
                    obj.Email = dr["Email"].ToString();
                    obj.Senha = dr["Senha"].ToString();
                    obj.TpUsuario = dr["TpUsuario"].ToString();
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception($"Usuário não cadastrado ! {ex.Message}");
            }
            finally
            {
                Desconectar();
            }


        }


        //CRUD
        //Create
        public void CadastrarCliente(UsuarioDTO objCad)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO Paciente (Nome,Email, Telefone, DataNasciemento, CPF,Estado, Endereço,Senha,TpUsuario) VALUES (@Nome,@Email,@Telefone,@DataNasciemento,@CPF,@Estado,@Endereço,@Senha,@TpUsuario);", conn);
                cmd.Parameters.AddWithValue("@Nome", objCad.Nome);
                cmd.Parameters.AddWithValue("@Email", objCad.Email);
                cmd.Parameters.AddWithValue("@Telefone", objCad.Telefone);
                cmd.Parameters.AddWithValue("@DataNasciemento", objCad.DataNasciemento);
                cmd.Parameters.AddWithValue("@CPF", objCad.CPF);
                cmd.Parameters.AddWithValue("@Estado", objCad.Estado);
                cmd.Parameters.AddWithValue("@Endereço", objCad.Endereço);
                cmd.Parameters.AddWithValue("@Senha", objCad.Senha);
                cmd.Parameters.AddWithValue("@TpUsuario", objCad.TpUsuario);
                cmd.ExecuteNonQuery();
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

        //Read
        public List<UsuarioDTO> ListarPaciente()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdPaciente,Nome,CPF,DataNasciemento,Email,Senha,Telefone,Estado,Endereço,DescricaoTipoUsuario  FROM Paciente INNER JOIN TipoUsuario ON IdTipoUsuario = TpUsuario ORDER BY IdPaciente ASC;", conn);
                dr = cmd.ExecuteReader();
                List<UsuarioDTO> lista = new List<UsuarioDTO>();
                while (dr.Read())
                {
                    UsuarioDTO obj = new UsuarioDTO();
                    obj.IdPaciente = Convert.ToInt32(dr["IdPaciente"]);
                    obj.Nome = dr["Nome"].ToString();
                    obj.Email = dr["Email"].ToString();
                    obj.Telefone = Convert.ToInt32(dr["Telefone"]);
                    obj.DataNasciemento = Convert.ToDateTime(dr["DataNasciemento"]);
                    obj.CPF = dr["CPF"].ToString();
                    obj.Estado = dr["Estado"].ToString();
                    obj.Endereço = dr["Endereço"].ToString();
                    obj.Senha = dr["Senha"].ToString();
                    obj.TpUsuario = dr["DescricaoTipoUsuario"].ToString();
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

        //Update
        public void EditarPaciente(UsuarioDTO objEdita)
        {
            try
            {
                Conectar(); 
                cmd = new SqlCommand("UPDATE Paciente SET [Nome] = @Nome,[CPF]=@CPF,[DataNasciemento]=@DataNasciemento,[Email]=@Email,[Senha]=@Senha,[Telefone]=@Telefone,[Estado]=@Estado,[Endereço] = @Endereço,[TpUsuario] = @TpUsuario WHERE IdPaciente = @id;", conn);
                cmd.Parameters.AddWithValue("@Nome", objEdita.Nome);
                cmd.Parameters.AddWithValue("@Email", objEdita.Email);
                cmd.Parameters.AddWithValue("@Telefone", objEdita.Telefone);
                cmd.Parameters.AddWithValue("@DataNasciemento", objEdita.DataNasciemento);
                cmd.Parameters.AddWithValue("@CPF", objEdita.CPF);
                cmd.Parameters.AddWithValue("@Estado", objEdita.Estado);
                cmd.Parameters.AddWithValue("@Endereço", objEdita.Endereço);
                cmd.Parameters.AddWithValue("@Senha", objEdita.Senha);
                cmd.Parameters.AddWithValue("@TpUsuario", objEdita.TpUsuario);
                cmd.ExecuteNonQuery();
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

        //Delete
        public void ExcluirPaciente(int objDel)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("DELETE FROM Paciente WHERE IdPaciente = @Id;", conn);
                cmd.Parameters.AddWithValue("@Id", objDel);
                cmd.ExecuteNonQuery();

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

        //CarregaDDL
        public List<TipoUsuarioDTO> CarregaDDL()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM TipoUsuario;", conn);
                dr = cmd.ExecuteReader();
                List<TipoUsuarioDTO> lista = new List<TipoUsuarioDTO>();
                while (dr.Read())
                {
                    TipoUsuarioDTO obj = new TipoUsuarioDTO();
                    obj.IdTipoUsuario = Convert.ToInt32(dr["IdTipoUsuario"]);
                    obj.DescricaoTipoUsuario = dr["DescricaoTipoUsuario"].ToString();
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
