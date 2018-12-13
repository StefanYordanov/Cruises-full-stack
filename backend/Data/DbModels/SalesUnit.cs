using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CruisesWebApp.Data.DbModels
{
    public class SalesUnit
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public ICollection<Ship> Ships { get; set; }

        public string Currency { get; set; }
    }
}
