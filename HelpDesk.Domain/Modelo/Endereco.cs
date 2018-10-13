﻿namespace HelpDesk.Domain.Modelo
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string CPF { get; set; }
        public int TipoEnderecoId { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
        
    }
}
