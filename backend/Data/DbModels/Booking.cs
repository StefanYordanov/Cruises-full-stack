using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CruisesWebApp.Data.DbModels
{
    public class Booking
    {
        public int Id { get; set; }

        public int ShipId { get; set; }

        public Ship Ship { get; set; }

        public DateTime BookingDate { get; set; }

        public decimal Price { get; set; }
    }
}
