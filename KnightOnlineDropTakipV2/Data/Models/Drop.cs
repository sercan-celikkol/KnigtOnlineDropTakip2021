using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightOnlineDropTakipV2.Data.Models
{
    public class Drop
    {
        public Drop()
        {
            Date = DateTime.Now;
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string PartyMembers { get; set; }
        public decimal Price { get; set; }
        public bool IsShared { get; set; }
        public DateTime Date { get; set; }
    }
}
