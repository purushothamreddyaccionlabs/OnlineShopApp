using OnlineShopApp.Interfaces;
using OnlineShopApp.Models;

namespace OnlineShopApp.ServieceLayer
{
    public class CategoryServices:ICategory
    {
        private readonly CommerceContext _dbcontext;

        public CategoryServices(CommerceContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public Category CreateCategory(Category category)
        {
            _dbcontext.Categories.Add(category);
            _dbcontext.SaveChanges();
            return category;
        }

        public List<Category> GetCategories()
        {
            return _dbcontext.Categories.ToList();
        }
    }
}
