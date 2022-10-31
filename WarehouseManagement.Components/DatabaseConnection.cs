using System.Reflection;
using WarehouseManagement.SharedBasis;

namespace WarehouseManagement.Components
{
    public class DatabaseConnection
    {
        public static IEnumerable<string> GetDatabaseConnectors()
        {
            return Directory
                .GetFiles(Environment.CurrentDirectory)
                .Where(file => file.Contains("WarehouseManagement.Database"))
               .Select(Assembly.LoadFrom)
               .SelectMany(assembly => assembly.GetExportedTypes())
               .Where(type => typeof(IDatabaseConnector).IsAssignableFrom(type))
               .Select(type => type.Name);
        }
    }
}