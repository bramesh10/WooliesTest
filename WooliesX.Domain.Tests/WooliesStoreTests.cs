using System;
using System.Linq;
using System.Collections.Generic;
using Xunit;

namespace WooliesX.Domain.Tests
{
    public class WooliesStoreTests
    {
        private readonly WooliesStore _sut;
        
        public WooliesStoreTests()
        {
            _sut = new WooliesStore();
        }
        [Fact]
        public void GivenProductsIsNullThrowsArgumentNullException()
        {
            // act & assert
            Assert.Throws<ArgumentNullException>(() => _sut.Load(null));

        }
        [Fact]
        public void GivenProductsAreAddedToStore()
        {
            //arrange
            var products = new List<Product> { new Product { name = "Product1", price = 20, quantity = 10 } };
            int expected = 1;
            // act
            _sut.Load(products);
            //assert
            Assert.Equal(expected, _sut.Products.Count());
        }
        [Fact]
        public void GivenSortOptionIsNullThrowsException()
        {
            // act & assert
            Assert.Throws<ArgumentNullException>(() => _sut.SortBy(null));
        }
        [Fact]
        public void GivenProductsIsNullThrowsException()
        {
            // act & assert
            Assert.Throws<ArgumentNullException>(() => _sut.SortBy(new SortByAscendingName()));
        }
        [Fact]
        public void GivenSortOptionProductsAreSorted()
        {
            //arrange
            var products = new List<Product> { new Product { name = "Product1", price = 20, quantity = 10 }, new Product { name = "Product2", price = 5, quantity = 8 } };
            var expected = "Product2";
            _sut.Load(products);

            // act
            var sortedProducts = _sut.SortBy(new SortByDescendingName());

            //assert
            Assert.Equal(expected, sortedProducts.First().name);
        }
    }
}
