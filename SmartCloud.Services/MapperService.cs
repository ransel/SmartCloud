using System;
using System.Collections.Generic;
using AutoMapper;
using SmartCloud.Domain.Commands.Account;
using SmartCloud.Model.Account;
using SmartCloud.Services.Interfaces;
using SmartCloud.Services.Mappers.Converters;

namespace SmartCloud.Services
{
    public class MapperService : IMapperService
    {
        private readonly IMapper _mapper;

        public MapperService()
        {
            var config = InitializeMaps();
            _mapper = config.CreateMapper();
        }

        private static MapperConfiguration InitializeMaps()
        {
            
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DateTime?, string>().ConvertUsing<NullableDateTimeToStringConverter>();
                cfg.CreateMap<DateTime, string>().ConvertUsing<DateTimeToStringConverter>();
                cfg.CreateMap<bool, string>().ConvertUsing<BoolToStringConverter>();
                cfg.CreateMap<bool?, string>().ConvertUsing<NullableBoolToStringConverter>();
                cfg.CreateMap<Domain.Entities.User, User>().ForMember(dest => dest.UserType, src => src.MapFrom(x => x.UserType.Description));
                cfg.CreateMap<CreateUserCommand, Domain.Entities.User>();
            });

            return config;
        }

        public TTarget Map<TSource, TTarget>(TSource source)
        {
            return _mapper.Map<TSource, TTarget>(source);
        }

        public TTarget Map<TSource, TTarget>(TSource source, TTarget target)
        {
            return _mapper.Map(source, target);
        }

        public List<TTarget> Map<TSource, TTarget>(List<TSource> source)
        {
            return _mapper.Map<List<TSource>, List<TTarget>>(source);
        }
    }
}