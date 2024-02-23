namespace WarehouseManagement.SharedBasis;

public class DatabaseConnectorTypItem
{
    public DatabaseConnectorTypItem(Type databaseConnectorType, string typename)
    {
        this.DatabaseConnectorType = databaseConnectorType;
        this.ConnectorArt = typename;
    }

    public Type DatabaseConnectorType { get; }
    public string ConnectorArt { get; }

    public IDatabaseConnector GetDatabaseConnectorInstance()
    {
        if (this.DatabaseConnectorType == null)
        {
            throw new InvalidOperationException("DatabaseConnectorType is null");
        }

        return (IDatabaseConnector)Activator.CreateInstance(this.DatabaseConnectorType);
    }
}