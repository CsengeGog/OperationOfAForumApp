using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OperationOfAForumApp.Models
{
    [Table("Posts")]
    public class Posts
    {
        [Key]
        public int Id { get; set; }
        public string ThreadName { get; set; }
        public string PostName { get; set; }
        public string PostBody { get; set; }
        public string Imagelf { get; set; }

    }
}
