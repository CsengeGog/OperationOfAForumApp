using OperationOfAForumApp.Data;
using OperationOfAForumApp.Models;

namespace OperationOfAForumApp.Repository
{
    public class ThreadsRepository : RepositoryBase<Threads>, IRepositoryBase<Threads>
    {
        public ThreadsRepository(DataContex context) : base(context)
        {
        }
    }
}
