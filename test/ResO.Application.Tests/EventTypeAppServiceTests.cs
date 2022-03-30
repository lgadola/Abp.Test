using ResO.Application.Contracts;
using Shouldly;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Xunit;

namespace ResO.Application.Tests
{
    public class EventTypeAppService_Tests : ResOApplicationTestBase
    {
        private readonly IEventTypeAppService _eventTypeAppService;

        public EventTypeAppService_Tests()
        {
            _eventTypeAppService = GetRequiredService<IEventTypeAppService>();
        }
        [Fact]
        public async Task InsertAndFetchEventType()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                var evt = new EventTypeDto()
                {
                    Title = "Event Type 1",
                    Key = "Type1",
                    MinParticipants = 1,
                    MaxParticipants = 10
                };
                evt.SetProperty("AdditionalData", "Test");

                var result = await _eventTypeAppService.CreateAsync(evt);

                result = await _eventTypeAppService.GetAsync(result.Id);
                result.ShouldNotBeNull();
                result.GetProperty<string>("AdditionalData").ShouldBe("Test");
            });
        }
    }
}
