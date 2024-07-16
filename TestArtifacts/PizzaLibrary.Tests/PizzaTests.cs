namespace PizzaLibrary.Tests
{
    public class PizzaTests
    {
        [Fact]
        public void CanCreatePizza()
        {
            // Arrange
            var pizza = new Pizza("Margherita");

            // Act
            var name = pizza.Name;

            // Assert
            Assert.Equal("Margherita", name);
        }

        [Fact]
        public void CanAddToppingToPizza()
        {
            // Arrange
            var pizza = new Pizza("Margherita");
            var topping = new Topping("Cheese");

            // Act
            pizza.AddTopping(topping);

            // Assert
            Assert.Contains(topping, pizza.Toppings);
        }

        [Fact]
        public void ToppingsListStartsEmpty()
        {
            // Arrange
            var pizza = new Pizza("Margherita");

            // Act
            var toppings = pizza.Toppings;

            // Assert
            Assert.Empty(toppings);
        }
    }
}