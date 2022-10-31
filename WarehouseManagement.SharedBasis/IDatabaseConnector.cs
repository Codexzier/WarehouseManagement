namespace WarehouseManagement.SharedBasis
{
    public interface IDatabaseConnector
    {
        void CreateTable<TTable>();
        void Insert(ArticleItem articleItem);
        IEnumerable<ArticleItem> GetAll();
        ArticleItem GetById(long id);
        IArticleSubItem SubItem_GetById(long id);
        void Update(ArticleItem articleItem);
        void Update(IArticleSubItem subItem);
    }

    public class ArticleItem
    {
        public long Id { get; set; }
        public string Title { get; set; } = "title";
        public string Description { get; set; } = String.Empty;
        public bool IsArchived { get; set; } = false;
        public bool IsTemplate { get; set; }
        IEnumerable<IArticleSubItem> ArticleSubItems { get; set; } = Array.Empty<IArticleSubItem>();
    }

    public interface IArticleSubItem
    {
        long Id { get; set; }
        long ArticleId { get; set; }
    }
}