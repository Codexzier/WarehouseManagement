using WarehouseManagement.SharedBasis;

namespace WarehouseManagement.DatabaseSQLite.Test;

[TestClass]
public class DatabaseConnectorTest
{
    [TestMethod]
    public void CreateTable()
    {
        // arrange
        var instance = new DatabaseConnector();
        
        // act
        instance.CreateTable<ArticleItem>();
        
        // assert
        Assert.IsTrue(true);
    }
}