using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ResO.Web;

[Dependency(ReplaceServices = true)]
public class ResOBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ResO";
}
