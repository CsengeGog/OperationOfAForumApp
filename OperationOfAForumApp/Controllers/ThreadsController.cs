using Microsoft.AspNetCore.Mvc;
using OperationOfAForumApp.Models;
using OperationOfAForumApp.Service;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.Contracts;

namespace OperationOfAForumApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ThreadsController
    {
        private readonly IThreadsService threadsService;

        public ThreadsController(IThreadsService threadsService) 
        {
            this.threadsService = threadsService;
        }

        [HttpGet(Name ="getThreads")]
        public IEnumerable<Threads> GetThreads() 
        {
            return threadsService.GetThreads();
        }

        [HttpPost(Name ="addThread")]
        public Threads AddThread(Threads thread) 
        {
            return threadsService.AddThread(thread);
        }

        [HttpPut(Name ="updateThread")]
        public Threads UpdateThread(Threads thread) 
        {
            return threadsService.UpdateThread(thread);
        }

        [HttpDelete(Name ="deleteThread")]
        public void DeleteThread(int id) 
        {
            threadsService.DeleteThread(id);
        }


    }
}
