using CruisesWebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CruisesWebApp.Uttilities.GetBookingsGroupedUttilities
{
    public class SalesUnitDetailsViewModel
    {
        public int BookingId { get; set; }

        public string ShipName { get; set; }

        public decimal Price { get; set; }

        public string Currency { get; set; }
    }
}
