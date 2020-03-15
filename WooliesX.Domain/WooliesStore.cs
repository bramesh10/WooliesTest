using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WooliesX.Domain
{
    public class WooliesStore
    {
        private IEnumerable<Product> _products = new List<Product>();
        public IEnumerable<Product> Products { get { return _products; } }
        public void Load(IEnumerable<Product> products)
        {
            if (products == null || products.Count() == 0)
                throw new ArgumentNullException(nameof(products));

            _products = products;
        }

        public IEnumerable<Product> SortBy(ISortOption sortOption)
        {
            if (sortOption == null) 
                throw new ArgumentNullException(nameof(sortOption));

            if (Products == null || Products.Count() == 0) 
                throw new ArgumentNullException(nameof(Products));

            return sortOption.Selected(Products);
        }
    }
}
