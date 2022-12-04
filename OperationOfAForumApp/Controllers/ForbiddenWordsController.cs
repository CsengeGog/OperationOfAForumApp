using Microsoft.AspNetCore.Mvc;
using OperationOfAForumApp.Models;
using OperationOfAForumApp.Service;

namespace OperationOfAForumApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ForbiddenWordsController
    {
        private IForbiddenWordsService forbiddenWordsService;

        public ForbiddenWordsController(IForbiddenWordsService forbiddenWordsService) 
        {
            this.forbiddenWordsService = forbiddenWordsService;
        }

        public IEnumerable<ForbiddenWords> GetForbiddenWords() 
        {
            return forbiddenWordsService.GetForbiddenWords();
        }
    }
}
