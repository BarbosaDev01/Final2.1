using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace aplicacaoFinal.Models
{
    public class Posto
    {
        [Key]
        public int IdPosto { get; set; }
        [Required]
        [DisplayName("Nome do Posto")]
        public string NomePosto { get; set; }
        [Required]
        [DisplayName("Tipo de Pino")]
        public string TipoPino { get; set; }
        [Required]
        [DisplayName("Potencia do Posto")]
        public int PotenciaPosto { get; set; }
        [DisplayName("Preço por kWh")]
        public double PrecoPorKwh { get; set; }
        [Required]
        [DisplayName("Rua do posto")]
        public string Rua { get; set; }
        [Required]
        [DisplayName("Bairro do Posto")]
        public string Bairro { get; set; }


        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
    }
}
