using System.Runtime.Serialization;

namespace WarehouseManagement.DatabaseSQLite
{
    [Serializable]
    internal class SqLiteDatabaseException : Exception
    {
        public SqLiteDatabaseException()
        {
        }

        public SqLiteDatabaseException(string? message) : base(message)
        {
        }

        public SqLiteDatabaseException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected SqLiteDatabaseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}