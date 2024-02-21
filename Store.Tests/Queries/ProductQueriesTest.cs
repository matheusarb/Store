using Store.Domain.Entities;
using Store.Domain.Queries;

namespace Store.Tests.Queries;

[TestClass]
public class ProductQueriesTest
{
    private readonly IList<Product> _products;

    public ProductQueriesTest()
    {
        _products = new List<Product>();
        _products.Add(new Product("Produto01", 10, true));
        _products.Add(new Product("Produto02", 10, true));
        _products.Add(new Product("Produto03", 10, true));
        _products.Add(new Product("Produto04", 10, false));
        _products.Add(new Product("Produto05", 10, false));
    }

    [TestMethod]
    [TestCategory("Queries")]
    public void Dado_a_consulta_de_produtos_ativos_deve_retornar_3()
    {
        var result = _products.AsQueryable().Where(ProductQueries.GetActiveProducts());

        Assert.AreEqual(result.Count(), 3);
    }

    [TestMethod]
    [TestCategory("Queries")]
    public void Dado_a_consulta_de_produtos_inativos_deve_retornar_2()
    {
        var result = _products.AsQueryable().Where(ProductQueries.GetInactiveProducts());

        Assert.AreEqual(result.Count(), 2);
    }
}