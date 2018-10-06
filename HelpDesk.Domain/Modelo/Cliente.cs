﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Domain.Modelo
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public ICollection<Contato> Contatos { get; set; }
        public ICollection<Endereco> Endereco { get; set; }
        public ICollection<ProfissaoCliente> ProfissoesClientes { get; set; }

    }
}
