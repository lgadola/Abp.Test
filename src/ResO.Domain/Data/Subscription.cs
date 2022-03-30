using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace ResO.Data
{
    public class Subscription : BasicAggregateRoot<Guid>
    {
        public Subscription()
        {
            Id = Guid.NewGuid();
        }
        public string Title { get; set; }
    }
}
