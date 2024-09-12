using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Basket
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public ICollection<ProductBasket> ProductBaskets { get; set; }
    }
}
