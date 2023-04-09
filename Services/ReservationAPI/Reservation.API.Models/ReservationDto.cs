namespace Reservation.API.Models;

public class ReservationDto
{
    public int Id { get; set; }
    public int ReservationNumber { get; set; }
    public DateTime? CheckInDate { get; set; }
    public DateTime? CheckOutDate { get; set; }
    public DateTime? ResDate { get; set; }
    public double Amount { get; set; }
}