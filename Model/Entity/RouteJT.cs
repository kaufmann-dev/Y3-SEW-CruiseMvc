using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entity
{
    [Table("ROUTES_JT")]
    public class RouteJT
    {
        public Harbor Harbor { get; set; }
        
        //[ForeignKey("DEPARTURE_HARBOR_ID")]
        //[Key]
        public int? DepartureHarborId { get; set; }
        
        //[ForeignKey("ARRIVAL_HARBOR_ID")]
        //[Key]
        public int? ArrivalHarborId { get; set; }

        [Column("NAME", TypeName = "VARCHAR(100)")]
        [StringLength(100, ErrorMessage = "invalid string length for name")]
        [Required(ErrorMessage = "name required")]
        public string Name { get; set; }
        
        [Column("DISTANCE", TypeName = "DECIMAL(8)")]
        [Required(ErrorMessage = "distance required")]
        public float Distance { get; set; }
    }
}