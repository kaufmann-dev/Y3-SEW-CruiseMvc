using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entity
{
    [Table("CRUISES")]
    public class Cruise
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("CRUISE_ID")]
        public int Id { get; set; }

        [StringLength(100, ErrorMessage = "invalid string length: name")]
        [Required(ErrorMessage = "name required")]
        [Column("NAME", TypeName = "VARCHAR(100)")]
        public string Name { get; set; }

        [Required(ErrorMessage = "departure date required")]
        [Column("DEPARTURE")]
        public DateTime Departure { get; set; }
        
        [Required(ErrorMessage = "arrival date required")]
        [Column("ARRIVAL")]
        public DateTime Arrival { get; set; }
    }
}