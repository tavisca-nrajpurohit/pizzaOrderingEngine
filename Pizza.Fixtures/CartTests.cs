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
    }
}
