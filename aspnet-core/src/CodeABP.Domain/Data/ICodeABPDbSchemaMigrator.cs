using System.Threading.Tasks;

namespace CodeABP.Data;

public interface ICodeABPDbSchemaMigrator
{
    Task MigrateAsync();
}
