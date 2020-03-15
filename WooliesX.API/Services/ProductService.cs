using System;
using System.Collections.Generic;
using WooliesX.Domain;

namespace WooliesX.API.Services
{
    public class ProductService : IProductService
    {
        readonly IProductServiceAgent _productServiceAgent;
        public ProductService(IProductServiceAgent productServiceAgent)
        {
            if (productServiceAgent == null)
                throw new ArgumentNullException(nameof(productServiceAgent));

            _productServiceAgent = productServiceAgent;
        }
        public IEnumerable<Product> GetProducts(string sortOption)
        {
            SortOption sortBy;

            if (string.IsNullOrWhiteSpace(sortOption))
                throw new ArgumentNullException(nameof(sortOption));

            if (!Enum.TryParse(sortOption, true, out sortBy))
                throw new ArgumentException(nameof(sortOption));

            var products = _productServiceAgent.GetProducts();
            var store = new WooliesStore();
            store.Load(products);
            return store.SortBy(SimpleSortFactory.Create(sortBy));
        }
    }
}
