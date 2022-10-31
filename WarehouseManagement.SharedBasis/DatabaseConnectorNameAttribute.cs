namespace WarehouseManagement.SharedBasis;

public class DatabaseConnectorNameAttribute : Attribute
{
    public DatabaseConnectorNameAttribute(string name)
    {
        this.Name = name;
    }

    public string Name { get; }
}