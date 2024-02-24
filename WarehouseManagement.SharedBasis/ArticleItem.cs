namespace WarehouseManagement.SharedBasis;

public class ArticleItem
{
    public long Id { get; set; }
    public string Title { get; set; } = "title";
    public string Description { get; set; } = string.Empty;
    public bool IsArchived { get; set; } = false;
    public bool IsTemplate { get; set; }
    IEnumerable<IArticleSubItem> ArticleSubItems { get; set; } = Array.Empty<IArticleSubItem>();
}