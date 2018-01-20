using System;
using System.Collections.Generic;

namespace TangentWeb.Helpers
{
    public static class AuthenticationHelper
    {
        public static async void Authenticate(string username, string password, Action<bool> callback)
        {
            var url = WebRequestHelper.BaseUrl + "api-token-auth/";

            var content = new Dictionary<string, string>
            {
                ["username"] = username,
                ["password"] = password
            };

            var response = await WebRequestHelper.MakeAsyncRequest(url, content);

            if (!response.IsSuccessStatusCode) return;

            var result = response.Content.ReadAsStringAsync().Result;

            callback?.Invoke(true);
        }
    }


    //public static async void Authenticate(string email, string password, Action<bool> callback)
    //{
    //        var url = WebRequestHelper.BaseUrl + string.Format("
    // ?username={0}&password={1}", email, password);
    //        var result = string.Empty;
    //        try
    //        {
    //        result = await WebRequestHelper.MakeAsyncRequest(url);
    //    }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine(ex);
    //        }

    //        bool.TryParse(result, out var authenticated);
    //        callback?.Invoke(authenticated);
    //}
}
