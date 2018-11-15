namespace SmartCloud.Services.Interfaces
{
    public interface ICacheService
    {
        bool TryGetValue<T>(string key, out T value);
        void SetValue<T>(string key, T value);
        void Remove(string key);
    }
}