using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UnoWebApi.Models
{
    public class ReservationViewModels
    {
        public int ReservationId { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "FirstName Length Should Be Less Than 10 Char")]
        public string FirstName { get; set; }
        public int CarId { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "CarName Length Should Be Less Than 10 Char")]
        public string CarName { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public System.DateTime RentalDate { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public System.DateTime ReturnDate { get; set; }
        [Required]
        public virtual ICollection<CarViewModels> Car { get; set; }
       
        public virtual ICollection<UserAccountViewModels> userAccount { get; set; }
    }
}