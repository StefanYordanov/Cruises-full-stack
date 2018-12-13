using CruisesWebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CruisesWebApp.Uttilities.GetBookingsGroupedUttilities
{
    public class ExtractSalesUnitsFromContext : IExtractSalesUnits
    {
        private ApplicationDbContext context;

        public ExtractSalesUnitsFromContext(ApplicationDbContext context)
        {
            this.context = context;
        }

        public ICollection<SalesUnitsGroupedViewModel> GetSalesUnitsGrouped(int year, int quarter)
        {
            ICollection<SalesUnitsGroupedViewModel> result;

            using (var ctx = context)
            {
                result = (from bookings in ctx.Bookings
                          where bookings.BookingDate.Year == year && 
                          bookings.BookingDate.Month <= quarter * 3 && 
                          bookings.BookingDate.Month > (quarter - 1) * 3
                          group bookings by new
                          {
                              bookings.Ship.SalesUnit.Name,
                              bookings.Ship.SalesUnit.Id,
                              bookings.Ship.SalesUnit.Currency
                          }
                               into grp
                          select new SalesUnitsGroupedViewModel()
                          {
                              Name = grp.Key.Name,
                              Id = grp.Key.Id,
                              Currency = grp.Key.Currency,
                              TotalPrice = grp.Sum(bookings => bookings.Price)
                          }).ToList();
            }

            return result;
        }

        public ICollection<SalesUnitDetailsViewModel> GetSalesUnitDetails(int year, int quarter, int salesUnitId)
        {
            ICollection<SalesUnitDetailsViewModel> result;

            using (var ctx = context)
            {
                result = (from bookings in ctx.Bookings
                          where bookings.BookingDate.Year == year &&
                          bookings.BookingDate.Month <= quarter * 3 &&
                          bookings.BookingDate.Month > (quarter - 1) * 3 &&
                          bookings.Ship.SalesUnitID == salesUnitId
                          select new SalesUnitDetailsViewModel()
                          {
                              BookingId = bookings.Id,
                              ShipName = bookings.Ship.Name,
                              Price = bookings.Price,
                              Currency = bookings.Ship.SalesUnit.Currency
                          }).ToList();
            }

            return result;
        }

        //EF blows up if i call it via the method
        private bool FilterByYearAndQuarter(DateTime date, int year, int quarter)
        {
            return date.Year == year && date.Month <= quarter * 3 && date.Month > (quarter - 1) * 3;
        }
    }
}
