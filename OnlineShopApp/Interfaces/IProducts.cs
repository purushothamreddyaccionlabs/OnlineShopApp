using OnlineShopApp.Models;

namespace OnlineShopApp.Interfaces
{
    public interface IProducts
    {
        List<Product> GetProducts();

        Product CreateProducts(Product product);
    }
}
