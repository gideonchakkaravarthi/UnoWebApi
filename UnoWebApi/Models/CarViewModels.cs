using System.ComponentModel.DataAnnotations;

namespace UnoWebApi.Models
{
    public class CarViewModels
    {
        [Key]
        public int CarId { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Description Length Should Be Less Than 50 Char")]
        public string Description { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Car Color Length Should Be Less Than 50 Char")]
        public string Color { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int Year { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public decimal RentalPrice { get; set; }
    }
}