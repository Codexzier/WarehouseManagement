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
}