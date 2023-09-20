using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisoOdonto.DAL
{
    public class Conexao
    {
        //variaveis
        protected SqlCommand cmd;
        protected SqlDataReader dr;
        protected SqlConnection conn;

        //metodos
        //Conectar
        protected void Conectar()
        {
            try
            {
                conn = new SqlConnection("Server=tcp:risoodonto.database.windows.net,1433;Initial Catalog=RisoOdonto;Persist Security Info=False;User ID=adm;Password=Risoodonto10;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                conn.Open();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        //desconectar
        protected void Desconectar()
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
