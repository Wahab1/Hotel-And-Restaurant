using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iris
{
    public class LaundryMember
    {
        public int Id { get; set; }
        public string ItemDescription { get; set; }
        public string ItemName { get; set; }
        public int ItemNameId { get; set; }
        public int ItemPrice { get; set; }
        public string Customer { get; set; }
        public int CustomerId { get; set; }
        public string Reception { get; set; }
        public int ReceptionId { get; set; }
        public int Quantity { get; set; }
    }
}
