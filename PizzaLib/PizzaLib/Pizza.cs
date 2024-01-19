namespace PizzaLib
{
    public class Pizza
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public decimal Price { get; set; }

        public Pizza(string name, int size, decimal price)
        {
            Name = name;
            Size = size;
            Price = price;
        }


    }
}
