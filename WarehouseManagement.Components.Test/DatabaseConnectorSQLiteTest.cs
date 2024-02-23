using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarehouseManagement.SharedBasis;

namespace WarehouseManagement.Components.Test;

[TestClass]
public class DatabaseConnectorSQLiteTest
{
    [TestMethod]
    public void CreateTable()
    {
        // arrange
        var dbcItems = DatabaseConnection.GetDatabaseConnectors();
        var dbcItem = dbcItems.FirstOrDefault(dbcItem => dbcItem.ConnectorArt == "SQLite");
        var instance = dbcItem.GetDatabaseConnectorInstance();

        // act
        instance.CreateTable<ArticleItem>();

        // assert
        Assert.IsTrue(true);
    }
}