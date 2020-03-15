using System.Net.Http;
using System.Threading.Tasks;

namespace WooliesX.Infrastructure
{
    public interface IHttpClientHelper
    {
        HttpResponseMessage ReadServiceData(string request);
    }
}
