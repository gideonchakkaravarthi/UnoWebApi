//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnoWebApi
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rental
    {
        public int RentalId { get; set; }
        public int AccountId { get; set; }
        public int CarId { get; set; }
        public System.DateTime DateRented { get; set; }
        public Nullable<System.DateTime> DateReturned { get; set; }
        public System.DateTime DateDue { get; set; }
    }
}