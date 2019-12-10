namespace Pizza
{
    class Cart
    {

        Pizza[] Pizzas = new Pizza[10];
        int itemCount = 0;
        double totalPrice = 0;

        public void AddToCart(Pizza newPizza)
        {
            this.itemCount++;
            this.Pizzas[itemCount - 1] = newPizza;
            this.totalPrice += newPizza.price;
        }

        public void RemoveFromCart(int index)
        {
            Pizza newPizza = this.Pizzas[index];
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

        public Pizza[] GetCartDetails()
        {
            return this.Pizzas;
        }

    }
}