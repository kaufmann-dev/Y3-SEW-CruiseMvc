using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entity
{
    [Table("EMPLOYEES_ST")]
    public class Employees_ST
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("EMPLOYEE_ID")]
        public int Id { get; set; }

        [StringLength(50, ErrorMessage = "invalid string length: fname")]
        [Required(ErrorMessage = "firstname required")]
        [Column("FIRST_NAME", TypeName = "VARCHAR(50)")]
        public string FirstName { get; set; }
        
        [StringLength(100, ErrorMessage = "invalid string length: lname")]
        [Required(ErrorMessage = "lastname required")]
        [Column("LAST_NAME", TypeName = "VARCHAR(50)")]
        public string LastName { get; set; }
        
        [StringLength(100, ErrorMessage = "invalid string length: type")]
        [Required(ErrorMessage = "type required")]
        [Column("EMPLOYEE_TYPE", TypeName = "LONGTEXT")]
        public string Type { get; set; }
    }
}