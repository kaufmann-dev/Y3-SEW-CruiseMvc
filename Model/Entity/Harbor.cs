using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entity
{
    [Table("HARBORS")]
    public class Harbor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("HARBOR_ID")]
        public int Id { get; set; }
        
        [StringLength(50, ErrorMessage = "invalid string length for name")]
        [Required(ErrorMessage = "name required")]
        [Column("NAME", TypeName = "VARCHAR(50)")]
        public string Name { get; set; }
        
        [StringLength(50, ErrorMessage = "invalid string length for continent")]
        [Required(ErrorMessage = "continent required")]
        [Column("CONTINENT", TypeName = "VARCHAR(50)")]
        public string Continent { get; set; }
        
        [StringLength(50, ErrorMessage = "invalid string length for country")]
        [Required(ErrorMessage = "country required")]
        [Column("COUNTRY", TypeName = "VARCHAR(50)")]
        public string Country { get; set; }
        
        [StringLength(8, ErrorMessage = "invalid string length for zip code")]
        [Required(ErrorMessage = "zip code required")]
        [Column("POSTAL_CODE", TypeName = "VARCHAR(8)")]
        public string Zip { get; set; }
        
        [StringLength(200, ErrorMessage = "invalid string length for street name")]
        [Required(ErrorMessage = "street name required")]
        [Column("STREET", TypeName = "VARCHAR(200)")]
        public string Street { get; set; }
        
        [StringLength(100, ErrorMessage = "invalid string length for location")]
        [Required(ErrorMessage = "location required")]
        [Column("LOCATION", TypeName = "VARCHAR(100)")]
        public string Location { get; set; }
        
    }
}