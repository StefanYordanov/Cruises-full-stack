using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CruisesWebApp.Uttilities.GetBookingsGroupedUttilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CruisesWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetBookingsGroupedController : ControllerBase
    {
        private IExtractSalesUnits extractSalesUnits;

        public GetBookingsGroupedController(IExtractSalesUnits extractSalesUnits)
        {
            this.extractSalesUnits = extractSalesUnits;
        }
        [HttpGet("{year}/{quarter}")]
        public ICollection<SalesUnitsGroupedViewModel> Get(int year, int quarter)
        {
            return extractSalesUnits.GetSalesUnitsGrouped(year, quarter);
        }

        [HttpGet("{year}/{quarter}/{salesUnitID}")]
        public ICollection<SalesUnitDetailsViewModel> Get(int year, int quarter, int salesUnitID)
        {
            return extractSalesUnits.GetSalesUnitDetails(year, quarter, salesUnitID);
        }
    }
}
