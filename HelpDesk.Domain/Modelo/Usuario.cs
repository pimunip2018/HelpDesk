using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Domain.Modelo
{
    public class Usuario
    {
        public string CPF { get; set; }
        public bool Bloqueado { get; set; }
        public int Tentativa { get; set; }
        public int TipoUsuarioId { get; set; }
        public string Senha { get; set; }


    }
}
