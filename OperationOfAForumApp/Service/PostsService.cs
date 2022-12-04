using OperationOfAForumApp.Data;
using OperationOfAForumApp.Models;

namespace OperationOfAForumApp.Service
{
    public class PostsService : IPostsService
    {
        public DataContex contex;
        public PostsService(DataContex contex)
        {
            this.contex = contex;
        }
        public Posts AddPost(Posts post)
        {
            contex.Add(post);
            contex.SaveChanges();
            return post;
        }

        public IEnumerable<Posts> GetAllPosts()
        {
            return contex.Posts.ToList();
        }

        public Posts GetPostByName(string name)
        {
            return contex.Posts.FirstOrDefault(x=>x.PostName==name);
        }
    }
}
