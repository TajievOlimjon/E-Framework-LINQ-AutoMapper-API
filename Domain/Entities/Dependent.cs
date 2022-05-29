using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class Dependent
    {
        [Column("Dependent_Id")]
        public int Id { get; set; }

        [Column("First_Name")]
        [Required]
        [MaxLength(50)]
        public string? FirstName { get; set; }

        [Column("Last_Name")]
        [Required]
        [MaxLength(50)]
        public string? LastName { get; set; }

        [Column("Relation_Ship")]
        [Required]
        [MaxLength(25)]
        public int RelationShip { get; set; }

        [Column("Employee_Id")]
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }


    }
}
