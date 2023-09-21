using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisoOdonto.DTO
{
    public class UsuarioDTO
    {
        public int IdPaciente { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNasciemento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Sexo { get; set; }
        public int Telefone { get; set; }
        public string Estado { get; set; }
        public string Endereço { get; set; }

        public string   TpUsuario { get; set; }
    }
}
