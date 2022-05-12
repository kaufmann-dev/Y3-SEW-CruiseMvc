using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entity
{
    [Table("CUSTOMERS")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CUSTOMER_ID", TypeName = "INT")]
        public int Id { get; set; }
        
        [Column("FIRST_NAME", TypeName = "VARCHAR(30)")]
        [StringLength(30, ErrorMessage = "invalid string length for first name")]
        [Required(ErrorMessage = "first name required")]
        public string FirstName { get; set; }
        
        [Column("LAST_NAME", TypeName = "VARCHAR(30)")]
        [StringLength(30, ErrorMessage = "invalid string kength for last name")]
        [Required(ErrorMessage = "last name required")]
        public string LastName { get; set; }
    }
}