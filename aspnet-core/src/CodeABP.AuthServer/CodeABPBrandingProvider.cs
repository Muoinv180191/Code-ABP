using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace CodeABP;

[Dependency(ReplaceServices = true)]
public class CodeABPBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "CodeABP";
}
