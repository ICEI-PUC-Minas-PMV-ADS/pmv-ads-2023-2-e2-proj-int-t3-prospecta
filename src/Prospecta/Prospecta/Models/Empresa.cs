using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prospecta.Models
{
    [Table("Empresas")]
    public class Empresa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [Display(Name = "Razão Social")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [Display(Name = "Nome Fantasia")]
        public string NomeFantasia { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [Display(Name = "CNPJ")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório.")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Informar a cidade onde se localiza a empresa ou matriz.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Informar o Estado em que se localiza a empresa ou matriz.")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Por favor, informar o tipo de serviço ou produto que oferece!")]
        [Display(Name = "Área de atuação")]
        public int AreaAtuacao { get; set; }
    }
}
