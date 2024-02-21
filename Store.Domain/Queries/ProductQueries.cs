using System.Linq.Expressions;
using Store.Domain.Entities;

namespace Store.Domain.Queries;

// String queries are not testable, therefore, we use Expressions to write and test our queries
public static class ProductQueries
{
    public static Expression<Func<Product, bool>> GetActiveProducts()
        => x => x.Active;

    public static Expression<Func<Product, bool>> GetInactiveProducts()
        => x => x.Active == false;

    
}