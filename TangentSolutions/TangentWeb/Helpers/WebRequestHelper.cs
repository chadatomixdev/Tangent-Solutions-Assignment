using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TangentWeb.Helpers
{
    public static class WebRequestHelper
    {
        public static string BaseUrl => "http://staging.tangent.tngnt.co/api/";

        public static async Task<string> MakeAsyncRequest(string url)
        {
            var httpClient = new HttpClient { Timeout = new TimeSpan(0, 5, 0) };
            var contentsTask = httpClient.GetStringAsync(url);

            var contents = await contentsTask;

            return contents;
        }

        public static async Task<string> MakeAsyncRequest(string url, string token)
        {
            var httpClient = new HttpClient {Timeout = new TimeSpan(0, 5, 0)};
            var contentsTask = httpClient.GetStringAsync(url);

            var contents = await contentsTask;

            return contents;
        }
    }
}
