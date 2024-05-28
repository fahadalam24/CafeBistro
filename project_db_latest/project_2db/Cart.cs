using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2db
{
    public class Cart
    {
        private List<CartItem> cartItems;

        public Cart()
        {
            cartItems = new List<CartItem>();
        }

        public void AddItem(MenuItem menuItem, int quantity)
        {
            // Check if the item is already in the cart
            CartItem existingItem = cartItems.FirstOrDefault(item => item.MenuItem.MenuItemID == menuItem.MenuItemID);

            if (existingItem != null)
            {
                // If the item is already in the cart, update the quantity
                existingItem.Quantity += quantity;
            }
            else
            {
                // If the item is not in the cart, add a new cart item
                CartItem newItem = new CartItem
                {
                    MenuItem = menuItem,
                    Quantity = quantity
                };

                cartItems.Add(newItem);
            }
        }

        public void RemoveItem(MenuItem menuItem)
        {
            // Remove the item from the cart
            CartItem itemToRemove = cartItems.FirstOrDefault(item => item.MenuItem.MenuItemID == menuItem.MenuItemID);

            if (itemToRemove != null)
            {
                cartItems.Remove(itemToRemove);
            }
        }

        public List<CartItem> GetCartItems()
        {
            return cartItems;
        }

        public decimal CalculateTotalPrice()
        {
            // Calculate the total price of items in the cart
            return cartItems.Sum(item => item.Quantity * item.MenuItem.Price);
        }
    }

    public class CartItem
    {
        public MenuItem MenuItem { get; set; }
        public int Quantity { get; set; }
    }

}
