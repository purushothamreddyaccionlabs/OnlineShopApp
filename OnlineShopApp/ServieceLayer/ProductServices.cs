using OnlineShopApp.Interfaces;
using OnlineShopApp.Models;

namespace OnlineShopApp.ServieceLayer
{
    public class ProductServices:IProducts
    {
        private CommerceContext _dbcontext;
        public ProductServices(CommerceContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public Product CreateProducts(Product product)
        {
            _dbcontext.Products.Add(product);
            _dbcontext.SaveChanges();
            return product;
        }

        public List<Product> GetProducts()
        {
            return _dbcontext.Products.ToList();
            
        }

   
    }
}
