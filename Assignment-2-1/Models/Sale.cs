using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_2_1.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public string CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public string EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public string ApproverId { get; set; }
        public virtual Employee Approver { get; set; }
        public int StoreLocationId { get; set; }
        public virtual StoreLocation StoreLocation { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        public Sale()
        {
            Products = new HashSet<Product>();
        }
    }
}