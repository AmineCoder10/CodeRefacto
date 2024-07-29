using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRefacto
{
    public class Order
    {
        public int Id { get; set; }
        public bool IsVerified { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
        public string Status { get; set; }
        public bool IsProcessed { get; set; }
    }
}
