using System.Diagnostics;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using WarehouseManagement.SharedBasis;

namespace WarehouseManagement.Components
{
    public class DatabaseConnection
    {
        public IEnumerable<string> GetDatabaseConnectors()
        {
            var dllFilenames = Directory
                .GetFiles(Environment.CurrentDirectory)
                .Where(file => file.Contains("WarehouseManagement.Database"));

            //var listDatases = new List<string>();
            //foreach (var dllFilename in dllFilenames)
            //{
            //    Assembly assembly = Assembly.LoadFrom(dllFilename);
            //    foreach (var type in assembly.GetExportedTypes())
            //    {
            //        if (typeof(IDatabaseConnector).IsAssignableFrom(type))
            //        {
            //            //var instance = (IDatabaseConnector)Activator.CreateInstance(type);
            //            //if (instance != null) listDatases.Add(instance.Databasename);
            //            var fff = type.GetCustomAttribute(typeof(DatabaseConnectorNameAttribute));
            //            if(fff != null) {
            //                var vv = (DatabaseConnectorNameAttribute)fff;
            //                listDatases.Add(vv.Name);
            //            }
            //        }
            //    }
            //}
            //return listDatases;

            return dllFilenames
               .Select(dllFilename => Assembly.LoadFrom(dllFilename))
               .SelectMany(assembly => assembly.GetExportedTypes())
               .Where(type => typeof(IDatabaseConnector).IsAssignableFrom(type))
               .Select(type => type.Name);
        }
    }
}