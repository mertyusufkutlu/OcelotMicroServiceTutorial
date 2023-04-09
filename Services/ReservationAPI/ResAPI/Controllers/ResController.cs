using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infrastructure;
using Reservation.API.Models;

namespace ResAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ResController(IReservationService _reservationService)
        {
            this._reservationService = _reservationService;
        }

        [HttpGet("{bkgNumber}")]
        public ReservationDto Get(int bkgNumber)
        {
           return _reservationService.GetResByBkgNumber(bkgNumber);
        }
    }
}