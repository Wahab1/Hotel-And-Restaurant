using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iris
{
    public class RoomMember
    {
        public int Id { get; set; }
        public string RoomType { get; set; }
        public int RoomNumber { get; set; }
        public int RoomRent { get; set; }
        public int OwnerId { get; set; }
        public string Owner { get; set; }
    }
}
