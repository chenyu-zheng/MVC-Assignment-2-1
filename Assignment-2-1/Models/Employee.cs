using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment_2_1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegistrationNumber { get; set; }
        [InverseProperty("Employee")]
        public virtual ICollection<Sale> Sales { get; set; }
        [InverseProperty("Approver")]
        public virtual ICollection<Sale> ApprovedSales { get; set; }

        public Employee()
        {
            Sales = new HashSet<Sale>();
            ApprovedSales = new HashSet<Sale>();
        }
    }
}