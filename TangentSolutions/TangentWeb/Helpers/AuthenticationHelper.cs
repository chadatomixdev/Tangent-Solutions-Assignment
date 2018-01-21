using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TangentWeb.Models;

namespace TangentWeb.Helpers
{
    public static class AuthenticationHelper
    {
        public static async Task<AuthenticationResult> Authenticate(string username, string password)
        {
            var url = WebRequestHelper.BaseUrl + "api-token-auth/";
            var authenticationResult = new AuthenticationResult();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                authenticationResult.AuthenticationStatus = AuthenticationStatus.InvalidUsernameOrPassword;
                return authenticationResult;
            }

            var content = new Dictionary<string, string>
            {
                ["username"] = username,
                ["password"] = password
            };

            var response = await WebRequestHelper.MakeAsyncRequest(url, content);
            var data = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode || string.IsNullOrEmpty(data))
            {
                authenticationResult.AuthenticationStatus = AuthenticationStatus.Failed;
                return authenticationResult;
            }

            var token = JsonConvert.DeserializeObject<Token>(data);
            authenticationResult.AuthenticationStatus = AuthenticationStatus.Succeeded;
            authenticationResult.Data = token;

            return authenticationResult;
        }
    }

    public class AuthenticationResult
    {
        public Token Data { get; set; }
        public AuthenticationStatus AuthenticationStatus { get; set; }
    }

    public enum AuthenticationStatus
    {
        Succeeded,
        InvalidUsernameOrPassword,
        Failed
    }
}
