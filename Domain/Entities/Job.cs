using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class Job
    {
        [Column("Job_Id")]
        public int Id { get; set; }

        [Column("Job_Title")]
        [Required]
        [MaxLength(35)]
        public string? JobTitle { get; set; }

        [Column("Min_Salary")]
        public decimal MinSalary { get; set; }

        [Column("Max_Salary")]
        public decimal MaxSalary { get; set; }
    }
}
