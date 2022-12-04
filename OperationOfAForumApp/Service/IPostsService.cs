using OperationOfAForumApp.Models;

namespace OperationOfAForumApp.Service
{
    public interface IPostsService
    {
        IEnumerable<Posts> GetAllPosts();

        Posts AddPost(Posts post);

        Posts GetPostByName(string name);
    }
}
