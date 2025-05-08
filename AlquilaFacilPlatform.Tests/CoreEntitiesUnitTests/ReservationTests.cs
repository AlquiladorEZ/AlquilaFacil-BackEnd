using AlquilaFacilPlatform.Booking.Domain.Model.Aggregates;
using AlquilaFacilPlatform.Booking.Domain.Model.Commands;

namespace AlquilaFacilPlatform.Tests.CoreEntitiesUnitTests;

public class ReservationTests
{
    [Fact]
    public void Reservation_Constructor_WithCommand_ShouldInitializeProperties()
    {
        // Arrange
        var command = new CreateReservationCommand(DateTime.Now, DateTime.Now.AddDays(5), 1, 1, 100.0f, "voucherImageUrl");

        // Act
        var reservation = new Reservation(command);

        // Assert
        Assert.Equal(command.StartDate, reservation.StartDate);
        Assert.Equal(command.EndDate, reservation.EndDate);
        Assert.Equal(command.UserId, reservation.UserId);
        Assert.Equal(command.LocalId, reservation.LocalId);
        Assert.Equal(command.Price, reservation.Price);
        Assert.Equal(command.VoucherImageUrl, reservation.VoucherImageUrl);
    }
}