using System;
using System.Collections.Generic;
using System.Text;
using CodeABP.Localization;
using Volo.Abp.Application.Services;

namespace CodeABP;

/* Inherit your application services from this class.
 */
public abstract class CodeABPAppService : ApplicationService
{
    protected CodeABPAppService()
    {
        LocalizationResource = typeof(CodeABPResource);
    }
}
