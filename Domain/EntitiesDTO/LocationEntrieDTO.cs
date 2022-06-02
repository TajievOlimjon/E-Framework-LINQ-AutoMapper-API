using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.EntitiesDTO
{
    public  class LocationEntrieDTO
    {
        public int Id { get; set; }
        public string? StreetAddress { get; set; }
        public string? PostalCode { get; set; }
        public string? City { get; set; }
        public string? StateProvince { get; set; }
        public int CountrieId { get; set; }
    }
}
