using OperationOfAForumApp.Data;
using OperationOfAForumApp.Models;

namespace OperationOfAForumApp.Service
{
    public class ForbiddenWordsService : IForbiddenWordsService
    {
        public DataContex context;
        public ForbiddenWordsService(DataContex context)
        {
            this.context = context;
        }
        public IEnumerable<ForbiddenWords> GetForbiddenWords()
        {
            return context.ForbiddenWords.ToList();
        }
    }
}
