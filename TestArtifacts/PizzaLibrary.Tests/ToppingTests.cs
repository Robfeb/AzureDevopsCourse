// PizzaTests.cs
namespace PizzaLibrary.Tests
{
    public class ToppingTests
    {
        [Fact]
        public void CanCreateTopping()
        {
            // Arrange
            var topping = new Topping("Cheese");

            // Act
            var name = topping.Name;

            // Assert
            Assert.Equal("Cheese", name);
        }
    }
}
