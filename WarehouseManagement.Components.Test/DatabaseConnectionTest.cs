using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace WarehouseManagement.Components.Test
{
    [TestClass]
    public class DatabaseConnectionTest
    {
        [TestMethod]
        public void ReadDlls()
        {
            // arrange
            // act
            var result = DatabaseConnection.GetDatabaseConnectors();

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count());
        }
        
        [TestMethod]
        public void LoadDatabase_SQLite()
        {
            // arrange
            var dbcItems = DatabaseConnection.GetDatabaseConnectors();

            // act
            var result = dbcItems.FirstOrDefault(dbcItem => dbcItem.ConnectorArt == "SQLite");

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual("SQLite", result.ConnectorArt);
        }
    }
}