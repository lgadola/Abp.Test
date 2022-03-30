using ResO.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ResO.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ResOPageModel : AbpPageModel
{
    protected ResOPageModel()
    {
        LocalizationResourceType = typeof(ResOResource);
    }
}
