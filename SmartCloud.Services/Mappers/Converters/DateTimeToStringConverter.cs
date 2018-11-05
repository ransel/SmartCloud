using System;
using AutoMapper;
using SmartCloud.Common.Constants;

namespace SmartCloud.Services.Mappers.Converters
{
    public class DateTimeToStringConverter : ITypeConverter<DateTime, string>
    {
        public string Convert(DateTime source, string destination, ResolutionContext context)
        {
            return source.ToString(FormatConstants.Date);
        }
    }
}
