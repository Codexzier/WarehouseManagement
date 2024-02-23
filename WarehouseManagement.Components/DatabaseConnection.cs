using System.Reflection;
using WarehouseManagement.SharedBasis;

namespace WarehouseManagement.Components
{
    public class DatabaseConnection
    {
        public static IEnumerable<DatabaseConnectorTypItem> GetDatabaseConnectors()
        {
            return Directory
                .GetFiles(Environment.CurrentDirectory)
                .Where(file => file.Contains("WarehouseManagement.Database"))
               .Select(Assembly.LoadFrom)
               .SelectMany(assembly => assembly.GetExportedTypes())
               .Where(type => typeof(IDatabaseConnector).IsAssignableFrom(type))
               .Select(type =>
                {
                    var attribute = type.GetCustomAttribute<DatabaseConnectorNameAttribute>();
                    
                    return new DatabaseConnectorTypItem(
                        type,
                        attribute.Name);
                });
        }
    }
}