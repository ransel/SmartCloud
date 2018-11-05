using System;
using AutoMapper;
using SmartCloud.Common.Constants;

namespace SmartCloud.Services.Mappers.Converters
{
    public class NullableDateTimeToStringConverter : ITypeConverter<DateTime?, string>
    {
        public string Convert(DateTime? source, string destination, ResolutionContext context)
        {
            if (!source.HasValue)
                return string.Empty;

            return source.Value.ToString(FormatConstants.Date);
        }
    }
}
