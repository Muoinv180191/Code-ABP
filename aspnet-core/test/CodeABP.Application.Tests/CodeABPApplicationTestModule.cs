using Volo.Abp.Modularity;

namespace CodeABP;

[DependsOn(
    typeof(CodeABPApplicationModule),
    typeof(CodeABPDomainTestModule)
    )]
public class CodeABPApplicationTestModule : AbpModule
{

}
