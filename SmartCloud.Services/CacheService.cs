using System;
using Microsoft.Extensions.Caching.Memory;
using SmartCloud.Services.Interfaces;

namespace SmartCloud.Services
{
    public class CacheService: ICacheService
    {
        private readonly IMemoryCache _cache;

        public CacheService(IMemoryCache cache)
        {
            _cache = cache;
        }

        public bool TryGetValue<T>(string key, out T value)
        {
            return _cache.TryGetValue(key, out value);
        }

        public void SetValue<T>(string key, T value)
        {
            _cache.Set(key, value, TimeSpan.FromMinutes(60));
        }

        public void Remove(string key)
        {
            _cache.Remove(key);
        }
    }
}