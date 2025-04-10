using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entity
{
    [Table("CRUISE_HAS_ROUTES_JT")]
    public class CruiseHasRouteJT
    {
        //[ForeignKey("CRUISE_ID")]
        //[Key]
        public int? CruiseId { get; set; }
        public Cruise Cruise { get; set; }
        
        public Harbor Harbor { get; set; }
        
        //[ForeignKey("DEPARTURE_HARBOR_ID")]
        //[Key]
        public int? DepartureHarborId { get; set; }
        
        //[ForeignKey("ARRIVAL_HARBOR_ID")]
        //[Key]
        public int? ArrivalHarborId { get; set; }

        [Column("ROUTE_INDEX", TypeName = "DECIMAL(3)")]
        [Required(ErrorMessage = "route index required")]
        public float RouteIndex { get; set; }
    }
}