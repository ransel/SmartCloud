using System.Collections.Generic;

namespace SmartCloud.Services.Interfaces
{
    public interface IMapperService
    {
        TTarget Map<TSource, TTarget>(TSource source);
        TTarget Map<TSource, TTarget>(TSource source, TTarget target);
        List<TTarget> Map<TSource, TTarget>(List<TSource> source);
    }
}