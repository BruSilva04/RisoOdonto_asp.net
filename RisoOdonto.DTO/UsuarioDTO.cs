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
        public string PLANO_DE_SAUDE { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Sexo { get; set; }
        public int Telefone { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public int Cep { get; set; }
        public string Logradouro { get; set; }
        public int Nro { get; set; }
        public  bool  TpUsuario { get; set; }
    }
}
