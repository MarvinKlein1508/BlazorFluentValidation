using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFluentValidation.Core.Models
{
    public class Order
    {
        public Customer Customer { get; set; } = new Customer();
        public string Model { get; set; } = String.Empty;
        public int Quanitity { get; set; }
        public decimal Total { get; set; }
    }
}
