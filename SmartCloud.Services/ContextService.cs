using Microsoft.AspNetCore.Http;
using SmartCloud.Common.Constants;
using SmartCloud.Domain.Context;
using SmartCloud.Services.Interfaces;

namespace SmartCloud.Services
{
    public class ContextService : IContextService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ContextService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public SmartCloudPrincipal User
        {
            get => GetItem<SmartCloudPrincipal>(ContextConstants.PrincipalKey);
            set => AddItem(ContextConstants.PrincipalKey, value);
        }

        public T GetItem<T>(string key)
        {
            if (!_httpContextAccessor.HttpContext.Items.ContainsKey(key))
            {
                return default(T);
            }

            return (T)_httpContextAccessor.HttpContext.Items[key];
        }

        public void AddItem<T>(string key, T instance)
        {
            _httpContextAccessor.HttpContext.Items.Add(key, instance);
        }
    }
}