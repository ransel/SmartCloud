using SmartCloud.Domain.Context;

namespace SmartCloud.Services.Interfaces
{
    public interface IContextService
    {
        SmartCloudPrincipal User { get; set; }
        T GetItem<T>(string key);
        void AddItem<T>(string key, T instance);
    }
}