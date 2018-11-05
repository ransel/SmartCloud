using AutoMapper;

namespace SmartCloud.Services.Mappers.Converters
{
    public class NullableBoolToStringConverter : ITypeConverter<bool?, string>
    {
        public string Convert(bool? source, string destination, ResolutionContext context)
        {
            if (!source.HasValue)
                return string.Empty;

            return source.Value ? "Yes" : "No";
        }
    }
}
