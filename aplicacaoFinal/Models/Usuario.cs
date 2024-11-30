using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace aplicacaoFinal.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required]
        [DisplayName("Modelo do Carro")]
        public string ModeloCarro { get; set; }
        [Required]
        [DisplayName("KwCarro")]
        public string KwCarro { get; set; }
        [Required]
        [DisplayName("Modelo de pino do carregador")]
        public string ModeloPino { get; set; }
        public ICollection<Posto> Posto { get; set; }
    }
}
