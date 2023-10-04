using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prospecta.Models
{
    [Table("Leads")]
    public class Lead
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "É necessário informar o CPF.")]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório.")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório.")]
        [Display(Name = "Telefone | WhatsApp")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Informar a cidade em que deseja obter o serviço ou produto.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Informar o Estado em que deseja obter o serviço ou produto.")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Por favor, informar o tipo de serviço ou produto de interesse!")]
        [Display(Name = "Serviço/Produto de Interesse")]
        public string Interesse { get; set; }

        [Display(Name = "Empresa Pretendida")]
        public string EmpresaPretendida { get; set; }

        public void cadastrarLead()
        {
        }
    }
}
