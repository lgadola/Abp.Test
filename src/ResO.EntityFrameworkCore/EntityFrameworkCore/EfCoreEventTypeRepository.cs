using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using ResO.Domain;
using ResO.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Caching;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace ResO.Repository
{
    public class EfCoreEventTypeRepository : EfCoreRepository<ResODbContext, EventType, Guid>,
        IEventTypeRepository
    {

        public EfCoreEventTypeRepository(
                IDbContextProvider<ResODbContext> dbContextProvider)
             : base(dbContextProvider)
        {
        }

    }
}
