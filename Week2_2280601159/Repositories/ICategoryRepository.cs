using Week2_2280601159.Models;

namespace Week2_2280601159.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}
