using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iris
{
    public class BookingRoomMember
    {
        public int CustomerId { get; set; }
        public string CustomerName  { get; set; } 
        public int ReceptionId { get; set; }
        public string ReceptionName { get; set; }
        public int RoomId { get; set; }
        public int RoomNo { get; set; }
        public string CustomerCNIC { get; set; }
        public DateTime Date { get; set; }
        public int RoomRent { get; set; }
        public int LaundryBill { get; set; }
        public int ResturantBill { get; set; }
    }
}
