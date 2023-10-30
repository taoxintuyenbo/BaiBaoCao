using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sach
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publication { get; set; }
        public DateTime bDate { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string imgPath { get; set; }
    }
}
