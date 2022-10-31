using WarehouseManagement.SharedBasis;

namespace WarehouseManagement.DatabasePostgreSQL
{
    [DatabaseConnectorName("PostgreSQL")]
    public class DatabaseConnector : IDatabaseConnector
    {
        
        #region interface methods
                
        public void CreateTable<TTable>()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ArticleItem> GetAll()
        {
            throw new NotImplementedException();
        }

        public ArticleItem GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Insert(ArticleItem articleItem)
        {
            throw new NotImplementedException();
        }

        public IArticleSubItem SubItem_GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(ArticleItem articleItem)
        {
            throw new NotImplementedException();
        }

        public void Update(IArticleSubItem subItem)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}