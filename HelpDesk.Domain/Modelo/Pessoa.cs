using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Domain.Modelo
{
    public class Pessoa
    {
        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O CPF é obrigatório")]
        public string CPF { get; set; }
        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
            "Números e caracteres especiais não são permitidos no nome.")]
        public string Nome { get; set; }
        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "A data de nascimento é obrigatório")]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime DtNasc { get; set; }
        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "O Telefone é obrigatório")]
        public string Telefone { get; set; }
        [Display(Name = "Telefone Comercial")]
        public string TelefoneEmpresa { get; set; }
        [Display(Name = "Ramal")]
        public int? Ramal { get; set; }
        [Display(Name = "Telefone Celular")]
        public string TelefoneCelular { get; set; }
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O E-mail é obrigatório")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string Email { get; set; }
        public int SexoId { get; set; }
        public int EstadoCivilId { get; set; }
        [Display(Name = "Razão Social")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string RazaoSocial { get; set; }
        [Display(Name = "CNPJ")]
        [Required(ErrorMessage = "O CNPJ é obrigatório")]
        public string CNPJ { get; set; }
        [Display(Name = "Data de Fundação")]
        [Required(ErrorMessage = "A data de fundação é obrigatório")]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime DtFundacao { get; set; }
        [Display(Name = "Cargo")]
        public string Cargo { get; set; }

    }
}
