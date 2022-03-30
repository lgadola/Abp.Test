﻿using System;
using System.Threading.Tasks;
using ResO.Data;
using Shouldly;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;
using Xunit;

namespace ResO.Samples;

/* This is just an example test class.
 * Normally, you don't test code of the modules you are using
 * (like IdentityUserManager here).
 * Only test your own domain services.
 */
public class SampleDomainTests : ResODomainTestBase
{
    private readonly IIdentityUserRepository _identityUserRepository;
    private readonly IdentityUserManager _identityUserManager;
    private readonly IRepository<Subscription, Guid> _subscriptions;

    public SampleDomainTests()
    {
        _identityUserRepository = GetRequiredService<IIdentityUserRepository>();
        _identityUserManager = GetRequiredService<IdentityUserManager>();
        _subscriptions = GetRequiredService<IRepository<Subscription, Guid>>();   
    }

    [Fact]
    public async Task Should_Set_Email_Of_A_User()
    {
        IdentityUser adminUser;

        /* Need to manually start Unit Of Work because
         * FirstOrDefaultAsync should be executed while db connection / context is available.
         */
        await WithUnitOfWorkAsync(async () =>
        {
            adminUser = await _identityUserRepository
                .FindByNormalizedUserNameAsync("ADMIN");

            await _identityUserManager.SetEmailAsync(adminUser, "newemail@abp.io");
            await _identityUserRepository.UpdateAsync(adminUser);
        });

        adminUser = await _identityUserRepository.FindByNormalizedUserNameAsync("ADMIN");
        adminUser.Email.ShouldBe("newemail@abp.io");
    }
    [Fact]
    public async Task Should_Throw_NotImplementedException()
    {
        var sub = new Subscription() { Title = "Test" };
        await WithUnitOfWorkAsync(async () =>
        {
            await _subscriptions.InsertAsync(sub, true);
        });
        
    }
}
