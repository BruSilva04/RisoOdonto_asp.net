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
                cmd = new SqlCommand("INSERT INTO Paciente (Nome,CPF,DataNasciemento,PLANO_DE_SAUDE,Email,Senha,Sexo,Telefone,Cidade,Bairro,Cep,Logradouro,Nro, TpUsuario) VALUES (@Nome,@CPF,@DataNasciemento,@PLANO_DE_SAUDE,@Email,@Senha,@Sexo,@Telefone,@Cidade,@Bairro,@Cep,@Logradouro,@Nro, @TpUsuario);", conn);
                cmd.Parameters.AddWithValue("@Nome", objCad.Nome);
                cmd.Parameters.AddWithValue("@CPF", objCad.CPF);
                cmd.Parameters.AddWithValue("@DataNasciemento", objCad.DataNasciemento);
                cmd.Parameters.AddWithValue("@PLANO_DE_SAUDE", objCad.PLANO_DE_SAUDE);
                cmd.Parameters.AddWithValue("@Email", objCad.Email);
                cmd.Parameters.AddWithValue("@Senha", objCad.Senha);
                cmd.Parameters.AddWithValue("@Sexo", objCad.Sexo);
                cmd.Parameters.AddWithValue("@Telefone", objCad.Telefone);
                cmd.Parameters.AddWithValue("@Cidade", objCad.Cidade);
                cmd.Parameters.AddWithValue("@Bairro", objCad.Bairro);
                cmd.Parameters.AddWithValue("@Cep", objCad.Cep);
                cmd.Parameters.AddWithValue("@Logradouro", objCad.Logradouro);
                cmd.Parameters.AddWithValue("@Nro", objCad.Nro);
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
                cmd = new SqlCommand("SELECT IdPaciente,Nome,CPF,DataNasciemento,PLANO_DE_SAUDE,Email,Senha,Sexo,Telefone,Cidade,Bairro,Cep,Logradouro,Nro,DescricaoTipoUsuario  FROM Paciente INNER JOIN TipoUsuario ON IdTipoUsuario = TpUsuario ORDER BY IdPaciente ASC;", conn);
                dr = cmd.ExecuteReader();
                List<UsuarioDTO> lista = new List<UsuarioDTO>();
                while (dr.Read())
                {
                    UsuarioDTO obj = new UsuarioDTO();
                    obj.IdPaciente = Convert.ToInt32(dr["IdPaciente"]);
                    obj.Nome = dr["Nome"].ToString();
                    obj.CPF = dr["CPF"].ToString();
                    obj.DataNasciemento = Convert.ToDateTime(dr["DataNasciemento"]);
                    obj.PLANO_DE_SAUDE = dr["PLANO_DE_SAUDE"].ToString();
                    obj.Email = dr["Email"].ToString();
                    obj.Senha = dr["Senha"].ToString();
                    obj.Sexo = dr["Sexo"].ToString();
                    obj.Telefone = Convert.ToInt32(dr["Telefone"]);
                    obj.Cidade = dr["Cidade"].ToString();
                    obj.Bairro = dr["Bairro"].ToString();
                    obj.Cep = Convert.ToInt32(dr["Cep"]);
                    obj.Logradouro = dr["Logradouro"].ToString();
                    obj.Nro = Convert.ToInt32(dr["Nro"]);
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
                cmd = new SqlCommand("UPDATE Paciente SET [Nome] = @Nome,[CPF]=@CPF,[DataNasciemento]=@DataNasciemento,[PLANO_DE_SAUDE]=@PLANO_DE_SAUDE,[Email]=@Email,[Senha]=@Senha,[Sexo]=@Sexo,[Telefone]=@Telefone,[Cidade]=@Cidade,[Bairro] = @Bairro,[Cep] = @Cep,[Logradouro] = @Logradouro,[Nro] = @Nro,[TpUsuario] = @TpUsuario WHERE IdPaciente = @id;", conn);
                cmd.Parameters.AddWithValue("@Nome",objEdita.Nome);
                cmd.Parameters.AddWithValue("@CPF", objEdita.CPF);
                cmd.Parameters.AddWithValue("@DataNasciement.o", objEdita.DataNasciemento);
                cmd.Parameters.AddWithValue("@PLANO_DE_SAUDE", objEdita.PLANO_DE_SAUDE);
                cmd.Parameters.AddWithValue("@Email", objEdita.Email);
                cmd.Parameters.AddWithValue("@Senha", objEdita.Senha);
                cmd.Parameters.AddWithValue("@Sexo", objEdita.Sexo);
                cmd.Parameters.AddWithValue("@Telefone", objEdita.Telefone);
                cmd.Parameters.AddWithValue("@Cidade", objEdita.Cidade);
                cmd.Parameters.AddWithValue("@Bairro", objEdita.Bairro);
                cmd.Parameters.AddWithValue("@Cep", objEdita.Cep);
                cmd.Parameters.AddWithValue("@Logradouro", objEdita.Logradouro);
                cmd.Parameters.AddWithValue("@Nro", objEdita.Nro);
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
