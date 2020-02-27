using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UnoWebApi.Models
{
    public class RentalViewModels
    {
        [Key]
        public int RentalId { get; set; }
        [Required]
        public int AccountId { get; set; }

        [Required]
        [MaxLength(50,ErrorMessage ="FirstName Length Should Be Less Than 50 Char")]
        public string FirstName { get; set; }
        [Required]
        public int CarId { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "CarName Length Should Be Less Than 50 Char")]
        public string CarName { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public System.DateTime DateRented { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> DateReturned { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public System.DateTime DateDue { get; set; }
        public virtual ICollection<CarViewModels> Car { get; set; }
        public virtual ICollection<UserAccountViewModels> userAccount { get; set; }
    }
}