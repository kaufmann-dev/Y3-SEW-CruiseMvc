using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entity
{
    [Table("SHIPS")]
    public class Ship
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("SHIP_ID")]
        public int Id { get; set; }

        [StringLength(50, ErrorMessage = "invalid string length for name")]
        [Required(ErrorMessage = "name required")]
        [Column("NAME", TypeName = "VARCHAR(50)")]
        public string Name { get; set; }
        
        [StringLength(50, ErrorMessage = "invalid string length for ship classificiation")]
        [Required(ErrorMessage = "ship classificiation required")]
        [Column("SHIP_CLASSIFICATION", TypeName = "VARCHAR(50)")]
        public string ShipClassification { get; set; }
    }
}