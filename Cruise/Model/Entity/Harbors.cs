using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entity
{
    [Table("HARBORS")]
    public class Harbors
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("HARBOR_ID")]
        public int Id { get; set; }
        
        [StringLength(50, ErrorMessage = "invalid string length: name")]
        [Required(ErrorMessage = "name required")]
        [Column("NAME", TypeName = "VARCHAR(50)")]
        public string Name { get; set; }
        
        [StringLength(50, ErrorMessage = "invalid string length: continent")]
        [Required(ErrorMessage = "continent required")]
        [Column("CONTINENT", TypeName = "VARCHAR(50)")]
        public string Continent { get; set; }
        
        [StringLength(50, ErrorMessage = "invalid string length: country")]
        [Required(ErrorMessage = "country required")]
        [Column("COUNTRY", TypeName = "VARCHAR(50)")]
        public string Country { get; set; }
        
        [StringLength(8, ErrorMessage = "invalid string length: zip")]
        [Required(ErrorMessage = "zip required")]
        [Column("POSTAL_CODE", TypeName = "VARCHAR(8)")]
        public string Zip { get; set; }
        
        [StringLength(200, ErrorMessage = "invalid string length: street")]
        [Required(ErrorMessage = "street required")]
        [Column("STREET", TypeName = "VARCHAR(200)")]
        public string Street { get; set; }
        
        [StringLength(100, ErrorMessage = "invalid string length: location")]
        [Required(ErrorMessage = "location required")]
        [Column("LOCATION", TypeName = "VARCHAR(100)")]
        public string Location { get; set; }
        
    }
}