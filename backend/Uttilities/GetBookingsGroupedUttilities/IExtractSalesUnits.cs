using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CruisesWebApp.Uttilities.GetBookingsGroupedUttilities
{
    public interface IExtractSalesUnits
    {
        ICollection<SalesUnitsGroupedViewModel> GetSalesUnitsGrouped(int year, int quarter);

        ICollection<SalesUnitDetailsViewModel> GetSalesUnitDetails(int year, int quarter, int id);
    }
}
