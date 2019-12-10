namespace Pizza
{
    public class Cart
    {

        PizzaItem[] Pizzas = new PizzaItem[10];
        public int itemCount = 0;
        public double totalPrice = 0;

        public void AddToCart(PizzaItem newPizza)
        {
            this.itemCount++;
            this.Pizzas[itemCount - 1] = newPizza;
            this.totalPrice += newPizza.price;
        }

        public void RemoveFromCart(int index)
        {
            PizzaItem newPizza = this.Pizzas[index];
            this.totalPrice -= newPizza.price;
            int count = index;
            while (count < this.itemCount - 1)
            {
                this.Pizzas[count] = this.Pizzas[count + 1];
            }
        }

        public double GetTotalPrice()
        {
            return this.totalPrice;
        }

        public int GetCartSize()
        {
            return this.itemCount;
        }

        public PizzaItem[] GetCartDetails()
        {
            return this.Pizzas;
        }

    }
}