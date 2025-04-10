using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entity
{
    [Table("CRUISES")]
    public class Cabin
    {
        [Column("CABIN_NR", TypeName = "INT")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Nr { get; set; }
        
        //[ForeignKey("SHIP_ID")]
        //[Key]
        public int? ShipId { get; set; }
        public Ship Ship { get; set; }
        
        [Column("CABIN_SIZE", TypeName = "INT")]
        [Required(ErrorMessage = "cabin size required")]
        public int CabinSize { get; set; }
        
        [Column("DESCRIPTION", TypeName = "VARCHAR(20)")]
        [Required(ErrorMessage = "description required")]
        [StringLength(20, ErrorMessage = "invalid string length for description")]
        public string Description { get; set; }
    }
}