using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace RefreshTokenExpSample
{
    public class CustomAuthorizationMessageHandler : AuthorizationMessageHandler
    {
        public CustomAuthorizationMessageHandler(IAccessTokenProvider provider, NavigationManager navigationManager) : base(provider, navigationManager)
        {
            ConfigureHandler(
                authorizedUrls: new[] { "https://xzc-e-n-exelens-d-api-01.azurewebsites.net" },
                scopes: new[] { "https://ExWAMDigitalB2C.onmicrosoft.com/fcbec44b-355b-44a4-8287-a47a77ef9984/QAiApi.All" });
        }
    }
}
