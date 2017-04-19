using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSite.DTO
{
    public class OrderDTO
    {
        public System.Guid OrderId { get; set; }
        public PizzaSite.DTO.Enums.SizeType Size { get; set; }
        public PizzaSite.DTO.Enums.CrustType Crust { get; set; }
        public bool Sausage { get; set; }
        public bool Pepperoni { get; set; }
        public bool Onion { get; set; }
        public bool GreenPeppers { get; set; }
        public decimal TotalCost { get; set; }
        public string Name { get; set; }
        public string Addrress { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public PizzaSite.DTO.Enums.PaymentType PaymentType { get; set; }
        public bool Completed { get; set; }
    }
}
