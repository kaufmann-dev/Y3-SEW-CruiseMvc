using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entity
{
    [Table("CRUISE_HAS_EMPLOYEES_JT")]
    public class CruiseHasEmployeeJT
    {
        //[ForeignKey("CRUISE_ID")]
        //[Key]
        public int? CruiseId { get; set; }
        public Cruise Cruise { get; set; }
        
        //[ForeignKey("EMPLOYEE_ID")]
        //[Key]
        public int? EmployeeId { get; set; }
        public EmployeeST Employee { get; set; }
        
        [Column("EMPLOYEE_ROLE", TypeName = "VARCHAR(30)")]
        [Required(ErrorMessage = "employee role required")]
        [StringLength(30, ErrorMessage = "invalid string length for employee role")]
        public string EmployeeRole { get; set; }
    }
}