namespace Week2_2280601159.Repositories;
using System.Collections.Generic;
using System.Linq;
using Week2_2280601159.Models;

public class MockProductRepository : IProductRepository
{
    private readonly List<Product> _products;
    public MockProductRepository()
    {
        // Tạo một số dữ liệu mẫu
        _products = new List<Product>
    {
                new Product { Id = 1, Name =  "Đắc Nhân Tâm", Author =  "Dale Carnegie", Price = 200, ImageUrl = "images/sp1.png", Description = "Cuốn sách giúp bạn phát triển kỹ năng giao tiếp và thành công trong cuộc sống."},
                new Product { Id = 2, Name = "Dấu Chân Trên Cát", Author = "Nguyễn Ngọc Thạch", Price = 150, ImageUrl = "images/sp2.png", Description = "Một câu chuyện cảm động về nghị lực sống và ý chí vượt khó."},
                new Product { Id = 3, Name = "Nhà Giả Kim", Author = "Paulo Coelho", Price =  67, ImageUrl = "images/sp3.png", Description = "Cuốn sách truyền cảm hứng về việc theo đuổi ước mơ."},
                new Product { Id = 4, Name = "Số Đỏ", Author = "Vũ Trọng Phụng", Price = 45, ImageUrl = "images/sp4.png", Description = "Tác phẩm châm biếm xã hội Việt Nam thập niên 30."},
                new Product { Id = 5, Name = "Tôi Thấy Hoa Vàng Trên Cỏ Xanh", Author = "Nguyễn Nhật Ánh", Price = 50, ImageUrl = "images/sp5.png", Description = "Một câu chuyện tuổi thơ đầy màu sắc và cảm xúc."},
                new Product { Id = 6, Name = "Harry Potter", Author = "J.K. Rowling", Price = 100, ImageUrl =  "images/sp6.png", Description = "Series tiểu thuyết kỳ ảo nổi tiếng thế giới."},
    };         
    }
    public IEnumerable<Product> GetAll()
    {
        return _products;
    }
    public Product GetById(int id)
    {
        return _products.FirstOrDefault(p => p.Id == id);
    }
    public void Add(Product product)
    {
        product.Id = _products.Max(p => p.Id) + 1;
        _products.Add(product);
    }
    public void Update(Product product)
    {
        var index = _products.FindIndex(p => p.Id == product.Id);
        if (index != -1)
        {
            _products[index] = product;
        }
    }
    public void Delete(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product != null)
        {
            _products.Remove(product);
        }
    }
}
