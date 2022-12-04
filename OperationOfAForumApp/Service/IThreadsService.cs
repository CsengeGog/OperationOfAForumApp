using OperationOfAForumApp.Models;

namespace OperationOfAForumApp.Service
{
    public interface IThreadsService
    {
        Threads AddThread(Threads thread);

        IEnumerable<Threads> GetThreads();

        Threads UpdateThread(Threads thread);

        void DeleteThread(int id);

    }
}
