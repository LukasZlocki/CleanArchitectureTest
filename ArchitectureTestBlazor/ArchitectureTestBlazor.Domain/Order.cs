using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureTestBlazor.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public string? SomeData { get; set; }
        public Product? OrderedProduct { get; set; }
    }
}
