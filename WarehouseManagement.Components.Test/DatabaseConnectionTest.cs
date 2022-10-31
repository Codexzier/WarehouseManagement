using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WarehouseManagement.Components.Test
{
    [TestClass]
    public class DatabaseConnectionTest
    {
        [TestMethod]
        public void ReadDlls()
        {
            // arrange
            var instance = new DatabaseConnection();

            // act
            var result = instance.GetDatabaseConnectors();

            // assert
            Assert.IsNotNull(result);
        }
    }
}