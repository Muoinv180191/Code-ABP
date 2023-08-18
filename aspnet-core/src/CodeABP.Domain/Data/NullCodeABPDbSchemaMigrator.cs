using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CodeABP.Data;

/* This is used if database provider does't define
 * ICodeABPDbSchemaMigrator implementation.
 */
public class NullCodeABPDbSchemaMigrator : ICodeABPDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
