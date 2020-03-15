using RestSharp;
using System.Collections.Generic;
using WooliesX.API.Helpers;
using WooliesX.Domain;
namespace WooliesX.API.Services
{
    public class ProductServiceAgent : IProductServiceAgent
    {
        private readonly IRestClient _restClient;

        public ProductServiceAgent(IRestClient restClient)
        {
            _restClient = restClient;
        }

        public IEnumerable<Product> GetProducts()
        {
            _restClient.BaseUrl = new System.Uri(URLConstants.BASE_URL);

            var request = new RestRequest(URLConstants.PRODUCT_RESOURCE, Method.GET);
            request.AddQueryParameter(URLConstants.TOKEN, URLConstants.TOKEN_VALUE);

            var response = _restClient.Execute<List<Product>>(request);
            return response.Data;
        }

    }
}
