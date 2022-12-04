using Microsoft.AspNetCore.Mvc;
using OperationOfAForumApp.Models;
using OperationOfAForumApp.Service;

namespace OperationOfAForumApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController
    {
        private IPostsService postsService;

        public PostsController(IPostsService postsService) 
        {
            this.postsService = postsService;
        }

        [HttpGet(Name ="getAllPosts")]
        public IEnumerable<Posts> GetPosts()
        {
            return postsService.GetAllPosts();
        }

        [HttpGet(Name ="getPostByName")]
        public Posts GetPostByName(string name) 
        {
            return postsService.GetPostByName(name);
        }

        [HttpPost(Name ="addPost")]
        public Posts AddPost(Posts post)
        {
            return postsService.AddPost(post);
        }
    }
}
