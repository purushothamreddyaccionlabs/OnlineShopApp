using OnlineShopApp.Models;

namespace OnlineShopApp.Interfaces
{
    public interface ICategory
    {
        List<Category> GetCategories();

        Category CreateCategory(Category category);
    }
}
