using System.ComponentModel.DataAnnotations;

namespace FBTarjeta.Models
{
    public class TarjetaCredito
    {
        public int id { get; set; }
        public string nombre { get; set; }
        [Required]
        public string numeroTarjeta { get; set; }
        [Required]
        public string fecha { get; set; }
        [Required]
        public string cvv { get; set; }
    }
}
