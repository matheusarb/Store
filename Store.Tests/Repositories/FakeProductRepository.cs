
using Store.Domain.Entities;
using Store.Domain.Repositories.Interfaces;

namespace Store.Tests.Repositories;

public class FakeProductRepository : IProductRepository
{
    public IEnumerable<Product> Get(IEnumerable<Guid> ids)
    {
        var products = new List<Product>();
        products.Add(new Product("Produto01", 10, true));
        products.Add(new Product("Produto02", 10, true));
        products.Add(new Product("Produto03", 10, true));
        products.Add(new Product("Produto04", 10, false));
        products.Add(new Product("Produto05", 10, false));

        return products;
    }
}