using RestSharp;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WooliesX.Infrastructure
{
    public class HttpClientHelper : IHttpClientHelper
    {
        const string BASE_URI = @"http://dev-wooliesx-recruitment.azurewebsites.net/api/resource/";
        const string TOKEN = "18e6f66b-02fe-4b1c-8737-fe4ac38aea03";
        
        public HttpResponseMessage ReadServiceData(string requestResourceName) {
            //using (var client = new HttpClient() { Timeout = new TimeSpan(0, 0, 30) })
            //{
            //    var reqMessage = GetRequestMessage(requestResourceName);
            //    var response = client.GetAsync(reqMessage).Result;
            //    return response;
            //}
            RestClient client = new RestClient(GetRequestMessage(requestResourceName));
            RestRequest request = new RestRequest(Method.GET);
            IRestResponse<List<Product>> response = client.Execute<List<Product>>(request);
            response.Data
        }
        private string GetRequestMessage(string ResourceName)
        {
            var queryString = System.Web.HttpUtility.ParseQueryString(string.Empty);
            queryString.Add("token", TOKEN);

            var completeRequestUri = $"{BASE_URI}{ResourceName}?{queryString}";
            return completeRequestUri;
        }
    }
}
