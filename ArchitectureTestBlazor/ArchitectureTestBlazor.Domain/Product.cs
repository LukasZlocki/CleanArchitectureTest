using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureTestBlazor.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? OriginCountry { get; set; }
    }
}
