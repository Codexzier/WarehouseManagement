using WarehouseManagement.SharedBasis;

namespace WarehouseManagement.DatabaseSQLite.Test;

[TestClass]
public class DatabaseConnectorTest
{
    public readonly string _databasePath = $"{Environment.CurrentDirectory}//warehouse";
    
    [TestMethod]
    public void CreateTable()
    {
        // arrange
        var instance = new DatabaseConnector(this.GetDatabasePath(1));
        
        // act
        instance.CreateTable<ArticleItem>();
        
        // assert
        Assert.IsTrue(true);
    }
    
    [TestMethod]
    public void Insert()
    {
        // arrange
        var instance = new DatabaseConnector(this.GetDatabasePath(2));
        var articleItem = CreateArticleItem();
        
        // act
        instance.Insert(articleItem);
        
        // assert
        Assert.IsTrue(true);
    }

    [TestMethod]
    public void GetById()
    {
        // arrange
        var instance = new DatabaseConnector(this.GetDatabasePath(3));
        var articleItem = CreateArticleItem();
        
        instance.Insert(articleItem);
        
        // act
        var result = instance.GetById(1);
        
        // assert
        Assert.AreEqual(articleItem, result);
    }
    
    private static ArticleItem CreateArticleItem(int id = 1)
    {
        var articleItem = new ArticleItem
        {
            Id = id,
            Title = "Test title",
            Description = "Test description",
            IsArchived = false,
            IsTemplate = false
        };
        return articleItem;
    }
    
    private DatabaseConnector GetInstance(int id)
    {
        var path = this.GetDatabasePath(id);
        
        return new DatabaseConnector(path);
    }
    
    private string GetDatabasePath(int id)
    {
        return $"{this._databasePath}_{id}.db";
    }
}