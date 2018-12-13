using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CruisesWebApp.Data.DbModels
{
    public class Ship
    {
        public int Id { get; set; }

        public int SalesUnitID { get; set; }

        public SalesUnit SalesUnit { get; set; }

        public ICollection<Booking> Bookings { get; set; }

        public string Name { get; set; }
    }
}
