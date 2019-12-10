using Xunit;

namespace Pizza.Fixtures
{
    public class CartTests
    {
        [Fact]
        public void ADD_TO_CART_TEST()
        {
            Cart cart = new Cart();
            Topping[] toppings = new Topping[]{
                Topping.Capsicum,
                Topping.Corn,
                Topping.Paneer
            };

            PizzaItem pizza = new PizzaItem(true, toppings, PizzaSize.medium);
            cart.AddToCart(pizza);
            int cartSize = cart.GetCartSize();
            Assert.Equal(1, cartSize);

        }

        [Fact]
        public void ADD_2_PIZZAS_TO_CART_TEST()
        {
            Cart cart = new Cart();
            Topping[] toppings = new Topping[]{
                Topping.Capsicum,
                Topping.Corn,
                Topping.Paneer
            };

            PizzaItem pizza1 = new PizzaItem(true, toppings, PizzaSize.medium);
            cart.AddToCart(pizza1);
            PizzaItem pizza2 = new PizzaItem(true, toppings, PizzaSize.small);
            cart.AddToCart(pizza2);
            int cartSize = cart.GetCartSize();
            Assert.Equal(2, cartSize);
        }

        [Fact]
        public void PRICE_FOR_2_PIZZAS_IN_CART_TEST()
        {
            Cart cart = new Cart();
            Topping[] toppings = new Topping[]{
                Topping.Capsicum
            };

            PizzaItem pizza1 = new PizzaItem(true, toppings, PizzaSize.medium);
            cart.AddToCart(pizza1);
            PizzaItem pizza2 = new PizzaItem(true, toppings, PizzaSize.large);
            cart.AddToCart(pizza2);
            double cartTotalPrice = cart.GetTotalPrice();
            double expectedValue = 560.00;
            Assert.Equal(expectedValue, cartTotalPrice);
        }

        [Fact]
        public void ADD_AND_REMOVE_PIZZA_FROM_CART_TEST()
        {
            Cart cart = new Cart();
            Topping[] toppings = new Topping[]{
                Topping.Capsicum
            };

            PizzaItem pizza1 = new PizzaItem(true, toppings, PizzaSize.medium);
            cart.AddToCart(pizza1);
            PizzaItem pizza2 = new PizzaItem(true, toppings, PizzaSize.large);
            cart.AddToCart(pizza2);
            cart.RemoveFromCart(0);
            double cartTotalPrice = cart.GetTotalPrice();
            double expectedValue = 360.00;
            Assert.Equal(expectedValue, cartTotalPrice);
        }

        [Fact]
        public void ADD_MORE_THAN_10_PIZZAS_IN_CART_TEST()
        {
            Cart cart = new Cart();
            Topping[] toppings = new Topping[]{
                Topping.Capsicum
            };

            for (int i = 0; i < 20; i++)
            {
                PizzaItem pizza = new PizzaItem(true, toppings, PizzaSize.small);
                cart.AddToCart(pizza);
            }

            double cartTotalPrice = cart.GetTotalPrice();
            double expectedValue = 1300.00;
            Assert.Equal(expectedValue, cartTotalPrice);
        }

    }
}
