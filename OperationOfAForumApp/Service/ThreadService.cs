using OperationOfAForumApp.Data;
using OperationOfAForumApp.Models;

namespace OperationOfAForumApp.Service
{
    public class ThreadService : IThreadsService
    {
        public DataContex contex;
        public ThreadService(DataContex contex)
        {
            this.contex = contex;
        }
        public Threads AddThread(Threads thread)
        {
            contex.Add(thread);
            contex.SaveChanges();
            return thread;
        }

        public void DeleteThread(int id)
        {
            Threads deleteThread = contex.Threads.FirstOrDefault(t => t.Id == id);
            contex.Remove(deleteThread);
            contex.SaveChanges();
        }

        public IEnumerable<Threads> GetThreads()
        {
            return contex.Threads.ToList();
        }

        public Threads UpdateThread(Threads thread)
        {
            contex.Update(thread);
            contex.SaveChanges();
            return thread;
        }
    }
}
