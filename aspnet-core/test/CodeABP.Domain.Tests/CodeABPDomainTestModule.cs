using CodeABP.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CodeABP;

[DependsOn(
    typeof(CodeABPEntityFrameworkCoreTestModule)
    )]
public class CodeABPDomainTestModule : AbpModule
{

}
