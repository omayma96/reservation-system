using Moq;
using reservation_system.Controllers;
using reservation_system.Models;
using reservation_system.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject1
{
    public class ReservationTypeTest
    {
       public Mock<IReservationTypeService> mock = new Mock<IReservationTypeService>();

        [Fact]
        public async void GetReservationTypebyId()
        {
            mock.Setup(p => p.GetReservationTypebyId(1)).ReturnsAsync("JK");
            ReservationsTypeController res = new ReservationsTypeController(mock.Object);
            string result = await res.GetReservationTypeById(1);
            Assert.Equal("JK", result);
        }

/*        [Fact]
        public async void GetReservationTypeDetails()
        {
            var reservationTypeDTO = new ReservationType()
            {
                id = 3,
                type = "Lundi",
                nbrPlace = 10
            };
            mock.Setup(p => p.GetReservationTypeDetails(3)).ReturnsAsync(reservationTypeDTO);
            ReservationsTypeController res = new ReservationsTypeController(mock.Object);
            var result = await res.GetReservationTypeDetails(1);
            Assert.True(reservationTypeDTO.Equals(result));
        }*/
    }
}
