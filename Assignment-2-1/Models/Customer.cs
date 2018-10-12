using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_2_1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }

        public Customer()
        {
            Sales = new HashSet<Sale>();
        }
    }
}