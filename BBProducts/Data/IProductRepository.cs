using BBProducts.Models;

namespace BBProducts.Data
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
