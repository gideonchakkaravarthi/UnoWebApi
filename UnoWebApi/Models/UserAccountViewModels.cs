using System.ComponentModel.DataAnnotations;

namespace UnoWebApi.Models
{
    public class UserAccountViewModels
    {
        [Key]
        public int AccountId { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Email Length Should Be Less Than 50 Char")]
        public string LoginEmail { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "FirstName Length Should Be Less Than 50 Char")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "LastName Length Should Be Less Than 50 Char")]
        public string LastName { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Address Length Should Be Less Than 50 Char")]
        public string Address { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "City Length Should Be Less Than 20 Char")]
        public string City { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "State Length Should Be Less Than 50 Char")]
        public string State { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "ZipCode Length Should Be Less Than 50 Char")]
        public string ZipCode { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "CreditCard Length Should Be Less Than 50 Char")]
        public string CreditCard { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public string ExpDate { get; set; }
       
    }
}