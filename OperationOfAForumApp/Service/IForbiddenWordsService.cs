using OperationOfAForumApp.Models;

namespace OperationOfAForumApp.Service
{
    public interface IForbiddenWordsService
    {
        IEnumerable<ForbiddenWords> GetForbiddenWords();
    }
}
