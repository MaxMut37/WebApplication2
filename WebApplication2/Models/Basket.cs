using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Basket
    {
        [Key]
        public int IdBasket { get; set; }
        public string UserId { get; set; }
        public string ProductId { get; set; }
    }
}
