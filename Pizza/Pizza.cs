using System;

namespace Pizza
{
    enum Topping
    {
        Capsicum,
        Paneer,
        Onion,
        Chicken,
        Corn,
        Olives,
        Mushrooms
    };

    enum PizzaSize
    {
        small,
        medium,
        large
    };

    class Pizza
    {
        public Boolean isVeg;
        public Topping[] toppings;
        public PizzaSize size;
        public double price;

        public Pizza(Boolean IsVeg, Topping[] Toppings, PizzaSize Size)
        {
            this.size = Size;
            this.toppings = Toppings;
            this.isVeg = IsVeg;
            this.price = this.CalculatePrice();
        }

        public double CalculatePrice()
        {
            double price = 0;
            foreach (var item in this.toppings)
            {
                price += 30;
            }

            switch (this.size)
            {
                case PizzaSize.small:
                    price += 100;
                    break;
                case PizzaSize.medium:
                    price += 200;
                    break;
                case PizzaSize.large:
                    price += 300;
                    break;
                default:
                    price += 200;
                    break;
            }

            this.price = price;
            return this.price;
        }
    }
}
