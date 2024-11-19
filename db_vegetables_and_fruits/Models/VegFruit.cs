using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_vegetables_and_fruits.Models
{
    public class VegFruit
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Type { get; set; } = null!;
        public string Color { get; set; } = null!;
        public uint Сalorie_content { get; set; }

        
    }
}
