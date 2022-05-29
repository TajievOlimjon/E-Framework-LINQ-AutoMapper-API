using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class Region
    {
        [Column("Region_Id")]
        public int Id { get; set; }

        [Column("Region_Name")]
        [MaxLength(25)]
        public string? RegionName { get; set; }

    }
}
