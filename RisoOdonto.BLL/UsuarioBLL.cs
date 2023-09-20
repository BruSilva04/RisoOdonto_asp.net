using RisoOdonto.DAL;
using RisoOdonto.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisoOdonto.BLL
{
    public class UsuarioBLL
    {
        //variavel
        UsuarioDAL objBLL = new UsuarioDAL();

        //autenticar
        public UsuarioDTO AutenticarPaciente(string Email, string Senha)
        {
            UsuarioDTO paciente = objBLL.AutenticarCliente(Email, Senha);
            return paciente;
        }

        //CRUD
        //Create
        public void Cadastrar(UsuarioDTO objCad)
        {
            objBLL.CadastrarCliente(objCad);
        }

        //Read
        public List<UsuarioDTO> Listar()
        {
            return objBLL.ListarPaciente();
        }

        //Delete
        public void Excluir(int objDel)
        {
            objBLL.ExcluirPaciente(objDel);
        }

        //Update
        public void Editar(UsuarioDTO objEdita)
        {
            objBLL.EditarPaciente(objEdita);
        }

        //CarregaDDL
        public List<TipoUsuarioDTO> CarregaTpUsuarioDDL()
        {
            return objBLL.CarregaDDL();
        }
    }
}
