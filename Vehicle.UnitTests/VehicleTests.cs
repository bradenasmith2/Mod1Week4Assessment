namespace Vehicle.UnitTests
{
    public class VehicleTests
    {
        [Fact]
        public void WhenCreated_HasCorrectProperties()
        {
            Vehicle megansCar = new Vehicle(4, "Green");

            Assert.Equal(4, megansCar.NumberOfWheels);
            Assert.Equal("Green", megansCar.Color);
            Assert.Equal(0, megansCar.MilesDriven);
        }

        [Fact]
        public void Summary_ReturnsInfoAboutVehicle()
        {
            Vehicle andysBike = new Vehicle(2, "Blue");
            var expected = "This Blue vehicle has 2 wheels, and has driven 0 miles."; // , and . added

            Assert.Equal(expected, andysBike.Sumary());
        }

        [Fact]
        public void Drive_AddsFive_To_MilesDriven_WithCorrectValue()
        {
            Vehicle vehicle1 = new(4, "Red");
            vehicle1.Drive();

            Assert.Equal(5, vehicle1.MilesDriven);
        }

        [Fact]
        public void Paint_Gets_NewColor_AndSets_ColorToNewColor()
        {
            Vehicle vehicle1 = new(4, "Red");
            vehicle1.Paint("Blue");

            Assert.Equal("Blue", vehicle1.Color);
        }
    }
}