using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace ResO.Domain
{
    public interface IEventTypeRepository : IRepository<EventType, Guid>
    {

    }
}
