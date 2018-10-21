using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Domain.Modelo
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O CPF é obrigatório")]
        public string CPF { get; set; }
        public int TipoEnderecoId { get; set; }
        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "O Endereço é obrigatório")]
        public string Logradouro { get; set; }
        [Display(Name = "Número", Description = "Informe um inteiro")]
        [Range(1, 99999)]
        public int Numero { get; set; }
        [Display(Name = "Bairro")]
        [Required(ErrorMessage = "O Bairro é obrigatório")]
        public string Bairro { get; set; }
        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "A Cidade é obrigatório")]
        public string Cidade { get; set; }
        [Display(Name = "UF")]
        [Required(ErrorMessage = "O UF é obrigatório")]
        public string UF { get; set; }
        [Display(Name = "CEP")]
        [Required(ErrorMessage = "O CEP é obrigatório")]
        public string CEP { get; set; }
        [Display(Name = "Complemento")]
        public string Complemento { get; set; }
        
    }
}
