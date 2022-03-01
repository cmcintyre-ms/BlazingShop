using BlazingShop.Shared;
using System.Collections.Generic;

namespace BlazingShop.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        void LoadProducts();
    }
}
