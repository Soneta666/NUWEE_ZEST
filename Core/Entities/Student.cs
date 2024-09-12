using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Post { get; set; }
        public string Password { get; set; }
        public double Bonus { get; set; }
        public int BasketId { get; set; }
        public Basket Basket { get; set; }
    }
}
