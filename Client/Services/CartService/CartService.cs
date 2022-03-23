using BlazingShop.Client.Services.ProductService;
using BlazingShop.Shared;
using Blazored.LocalStorage;
using Blazored.Toast.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService localStorage;
        private readonly IToastService toastService;
        private readonly IProductService productService;

        public event Action OnChange;

        public CartService(ILocalStorageService localStorage, IToastService toastService,
            IProductService productService)
        {
            this.localStorage = localStorage;
            this.toastService = toastService;
            this.productService = productService;
        }

        public async Task AddToCart(ProductVariant productVariant)
        {
            var cart = await localStorage.GetItemAsync<List<ProductVariant>>("cart");
            if (cart == null)
            {
                cart = new List<ProductVariant>();
            }

            cart.Add(productVariant);
            await localStorage.SetItemAsync("cart", cart);

            var product = await productService.GetProduct(productVariant.ProductId);
            toastService.ShowSuccess(product.Title, "Added to Cart:");

            OnChange.Invoke();
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            var result = new List<CartItem>();
            var cart = await localStorage.GetItemAsync<List<ProductVariant>>("cart");
            if (cart == null)
            {
                return result;
            }

            foreach (var item in cart)
            {
                var product = await productService.GetProduct(item.ProductId);
                var cartItem = new CartItem
                {
                    ProductId = product.Id,
                    ProductTitle = product.Title,
                    Image = product.Image,
                    EditionId = item.EditionId
                };

                var variant = product.Variants.Find(v => v.EditionId == item.EditionId);
                if (variant != null)
                {
                    cartItem.EditionName = variant.Edition?.Name;
                    cartItem.Price = variant.Price;
                }

                result.Add(cartItem);
            }

            return result;
        }
    }
}
