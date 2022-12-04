using OperationOfAForumApp.Data;
using OperationOfAForumApp.Models;

namespace OperationOfAForumApp.Repository
{
    public class PostsRepository : RepositoryBase<Posts>, IRepositoryBase<Posts>
    {
        public PostsRepository(DataContex context) : base(context)
        {
        }
    }
}
