namespace PizzaLibrary;
public class Pizza
{
    public string Name { get; set; }
    public List<Topping> Toppings { get; set; }

    public Pizza(string name)
    {
        Name = name;
        Toppings = new List<Topping>();
    }

    public void AddTopping(Topping topping)
    {
        Toppings.Add(topping);
    }
}

