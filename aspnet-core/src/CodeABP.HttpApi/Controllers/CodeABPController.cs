using CodeABP.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CodeABP.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CodeABPController : AbpControllerBase
{
    protected CodeABPController()
    {
        LocalizationResource = typeof(CodeABPResource);
    }
}
