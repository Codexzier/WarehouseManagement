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
    }
}