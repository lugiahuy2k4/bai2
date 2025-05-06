using System.Collections.Generic;
using Week2_2280601159.Models;


namespace Week2_2280601159.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}
