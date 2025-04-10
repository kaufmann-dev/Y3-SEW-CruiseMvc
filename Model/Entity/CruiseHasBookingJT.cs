using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Model.Entity
{
    [Table("CRUISE_HAS_BOOKINGS_JT")]
    public class CruiseHasBookingJT
    {
        //[ForeignKey("BOOKING_ID")]
        //[Key]
        public int? BookingId { get; set; }
        public Booking Booking { get; set; }
        
        //[ForeignKey("CUSTOMER_ID")]
        //[Key]
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        
        //[ForeignKey("CRUISE_ID")]
        //[Key]
        public int? CruiseId { get; set; }
        public Cruise Cruise { get; set; }
        
        //[ForeignKey("CABIN_NR")]
        //[Key]
        public int? CabinNr { get; set; }
        public Cabin Cabin { get; set; }

        //[ForeignKey("SHIP_ID")]
        //[Key]
        public int? ShipId { get; set; }
        public Ship Ship { get; set; }
        
        [Column("PRICE", TypeName = "INT")]
        [Required(ErrorMessage = "price required")]
        public int Price { get; set; }
    }
}