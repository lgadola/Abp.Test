using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ResO.Pages;

public class Index_Tests : ResOWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
