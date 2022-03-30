using ResO.Application.Contracts;
using ResO.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Data;
using Volo.Abp.MultiTenancy;

namespace ResO.Application
{
    public class EventTypeAppService : CrudAppService<EventType, EventTypeDto, Guid, EventTypeRequestDto, EventTypeDto, EventTypeDto>, IEventTypeAppService
    {
        public EventTypeAppService(IEventTypeRepository repository, 
            ICurrentTenant tenant)
            : base(repository)
        {

        }
    }
}
