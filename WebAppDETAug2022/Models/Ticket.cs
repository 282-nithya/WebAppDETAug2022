using System.ComponentModel.DataAnnotations;

namespace WebAppDETAug2022.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
       

        public int Price { get; set; }

      
    }
}
