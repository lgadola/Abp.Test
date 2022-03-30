using System;
using Volo.Abp.Application.Services;

namespace ResO.Application.Contracts
{
    public interface IEventTypeAppService : ICrudAppService<EventTypeDto, Guid, EventTypeRequestDto, EventTypeDto, EventTypeDto>
    {

    }
}
