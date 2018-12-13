using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CruisesWebApp.Uttilities.GetBookingsGroupedUttilities
{
    public class SalesUnitsGroupedViewModel
    {
        public int Id { get; set; }

        public decimal TotalPrice { get; set; }

        public string Name { get; set; }

        public string Currency { get; set; }
    }
}
