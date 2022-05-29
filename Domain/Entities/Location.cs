using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class Location
    {
        [Column("Location_Id")]
        public int Id { get; set; }

        [Column("Street_Address")]
        [Required]
        [MaxLength(40)]
        public string? StreetAddress { get; set; }

        [Column("Postal_Code")]
        [MaxLength(12)]
        public string? PostalCode { get; set; }

        [MaxLength(30)]
        [Required]
        public string? City { get; set; }

        [Column("State_Province")]
        [MaxLength(25)]
        public string? StateProvince { get; set; }

        [Column("Countrie_Id")]
        [Required]
        public int CountrieId { get; set; }
        public Countrie? Countrie { get; set; }
    }
}
