using Reservation.API.Infrastructure;
using Reservation.API.Models;

namespace Reservation.API.Services;

public class ReservationService : IReservationService
{
    public ReservationDto GetResByBkgNumber(int BkgNumber)
    {
        return new ReservationDto()
        {
            Id = (new Random()).Next(100),
            Amount = (new Random()).Next(10000),
            ResDate = DateTime.Now,
            CheckInDate = DateTime.Now.Date.AddDays(30),
            CheckOutDate = DateTime.Now.Date.AddDays(37),
            ReservationNumber = BkgNumber,
        };
    }
}