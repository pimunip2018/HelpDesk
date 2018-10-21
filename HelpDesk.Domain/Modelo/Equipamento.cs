using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Domain.Modelo
{
    public class Equipamento
    {
        public int EquipamentoId { get; set; }
        public int TipoEquipamentoId { get; set; }
        public int MarcaId { get; set; }
        public string Descricao { get; set; }
        public string Identificacao { get; set; }
        public string CPF { get; set; }
    }
}
