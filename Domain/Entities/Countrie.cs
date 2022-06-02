using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class Countrie
    {
        [Column("Countrie_Id")]
        public int Id { get; set; }

        [Column("Countrie_Name")]
        [MaxLength(40)]
        public string? Name { get; set; }
        [Required]
        [Column("Region_Id")]
        public int RegionId { get; set; }
        public Region? Region { get; set; }

    }
   
}
