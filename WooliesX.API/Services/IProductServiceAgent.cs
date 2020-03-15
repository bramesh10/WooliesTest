using System.Collections.Generic;
using WooliesX.Domain;

namespace WooliesX.API.Services
{
    public interface IProductServiceAgent
    {
        IEnumerable<Product> GetProducts();
    }
}
