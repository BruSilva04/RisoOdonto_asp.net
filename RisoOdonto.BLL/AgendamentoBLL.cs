using RisoOdonto.DAL;
using RisoOdonto.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisoOdonto.BLL
{
    public class AgendamentoBLL
    {
        //variavel
        AgendamentoDAL objBLL = new AgendamentoDAL();

        //CRUD
        //Read
        public List<AgendamentoDTO> Listar()
        {
            return objBLL.ListarAgenda();
        }
    }
}
