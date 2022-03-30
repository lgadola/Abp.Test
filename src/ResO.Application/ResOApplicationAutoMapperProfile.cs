using AutoMapper;
using ResO.Application.Contracts;
using ResO.Domain;

namespace ResO;

public class ResOApplicationAutoMapperProfile : Profile
{
    public ResOApplicationAutoMapperProfile()
    {
        CreateMap<EventType, EventTypeDto>()
            .MapExtraProperties();
        CreateMap<EventTypeDto, EventType>()
             .ForMember(dest => dest.TenantId, opts => opts.Ignore())
             .ForMember(dest => dest.LastModificationTime, opts => opts.Ignore())
             .ForMember(dest => dest.LastModifierId, opts => opts.Ignore())
             .ForMember(dest => dest.CreationTime, opts => opts.Ignore())
             .ForMember(dest => dest.CreatorId, opts => opts.Ignore())
             .MapExtraProperties();
    }
}
