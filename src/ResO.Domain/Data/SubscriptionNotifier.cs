using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Entities.Events;
using Volo.Abp.EventBus;

namespace ResO.Data
{
    public class SubscriptionNotifier :
        ILocalEventHandler<EntityCreatedEventData<Subscription>>,
        ITransientDependency
    {
        public SubscriptionNotifier()
        {

        }
        public async Task HandleEventAsync(EntityCreatedEventData<Subscription> eventData)
        {
            throw new NotImplementedException();
        }
    }
}
