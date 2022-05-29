using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class Department
    {
        [Column("Department_Id")]
        public int  Id { get; set; }

        [Column("Department_Name")]
        [Required]
        [MaxLength(30)]
        public string? Name { get; set; }

        [Column("Location_Name")]
        public int LocationId { get; set; }
        public Location? Location { get; set; }
    }
}
