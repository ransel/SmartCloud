using AutoMapper;

namespace SmartCloud.Services.Mappers.Converters
{
    public class BoolToStringConverter : ITypeConverter<bool, string>
    {
        public string Convert(bool source, string destination, ResolutionContext context)
        {
            return source ? "Yes" : "No";
        }
    }
}
