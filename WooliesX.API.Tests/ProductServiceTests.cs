using Moq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using WooliesX.API.Services;
using WooliesX.Domain;
using Xunit;

namespace WooliesX.API.Tests
{
    public class ProductServiceTests
    {
        private readonly ProductService _sut;
        private Mock<IRestClient> restClientMock;
        private readonly Mock<ProductServiceAgent> serviceAgentMock;
        public ProductServiceTests()
        {
            restClientMock = new Mock<IRestClient>();
            serviceAgentMock = new Mock<ProductServiceAgent>(restClientMock.Object);
            _sut = new ProductService(serviceAgentMock.Object);
        }
        [Fact]
        public void Constructor_ShouldThrow_ArgumentNullException_WhenServiceAgentIsNull()
        {
            // act & assert
            Assert.Throws<ArgumentNullException>(() => new ProductService(null));
        }
    }
}
