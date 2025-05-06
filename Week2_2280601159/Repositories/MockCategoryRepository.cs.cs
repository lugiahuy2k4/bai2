using Week2_2280601159.Models;

namespace Week2_2280601159.Repositories
{
    public class MockCategoryRepository : ICategoryRepository
    {
        private List<Category> _categoryList;
        public MockCategoryRepository()
        {
            _categoryList = new List<Category>
        {
        new Category { Id = 1, Name = "Truyện" },
        new Category { Id = 2, Name = "Tiểu Thuyết" },
        // Thêm các category khác
        };
        }
        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryList;
        }
    }
}
