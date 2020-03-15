using System.Collections.Generic;
using WooliesX.Domain;

namespace WooliesX.API.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts(string sortOption);
    }
}
