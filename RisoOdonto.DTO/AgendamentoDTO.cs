using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisoOdonto.DTO
{
    public class AgendamentoDTO
    {
        public int IdAgendamento { get; set; }
        public int IdPaciente { get; set; }
        public int IdDentista { get; set; } 
        public DateTime DataConsulta { get; set; }
        public DateTime Horario { get; set; }
        public bool PrimeiraConsulta { get; set; }
        public string StatusConsulta { get; set; }
    }
}
