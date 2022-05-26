using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int NumberOfPages { get; set; }
        public string Author { get; set; }
    }
}
