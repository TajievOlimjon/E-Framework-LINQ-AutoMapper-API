using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class Employee
    {
        [Column("Employee_Id")]
        public int Id { get; set; }
      
        [Column("First_Name")]
        [Required]
        [MaxLength(20)]     
        public string? FirstName { get; set; }      
       
        [Column("Last_Name")]
        [Required]
        [MaxLength(25)]
        public string? LastName { get; set; }
       
        [Required]
        [MaxLength(100)]       
        public string? Email { get; set; }
        
        [Column("Phone_Number")]
        public string? PhoneNumber { get; set; }
       
        [Column("Hire_Date")]
        public DateTime HireDate { get; set; }

        [Required]
        public decimal Salary { get; set; }
        
        [Column("Job_Id")]
        public int JobId { get; set; }
        public Job? Job { get; set; }
       
        [Column("Department_Id")]
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
       
     }
   

    
}
