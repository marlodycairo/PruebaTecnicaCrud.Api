using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Api.Core.DTOs
{
    public class OrderDetailDto
    {
        public int OrderDetailID { get; set; }
        public int ProductID { get; set; }
        public float UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }
    }
}
