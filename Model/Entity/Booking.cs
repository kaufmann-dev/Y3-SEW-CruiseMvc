using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entity
{
    [Table("BOOKINGS")]
    public class Booking
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("BOOKING_ID")]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "departure date required")]
        [Column("BOOKED_AT")]
        public DateTime BookingDate { get; set; }
    }
}