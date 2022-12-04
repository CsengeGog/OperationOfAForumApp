using OperationOfAForumApp.Data;
using OperationOfAForumApp.Models;

namespace OperationOfAForumApp.Repository
{
    public class ForbiddenWordsRepository : RepositoryBase<ForbiddenWords>, IRepositoryBase<ForbiddenWords>
    {
        public ForbiddenWordsRepository(DataContex context) : base(context)
        {
        }
    }
}
