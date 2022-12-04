using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OperationOfAForumApp.Models
{
    [Table("Threads")]
    public class Threads
    {
        [Key]
        public int Id { get; set; }
        public string ThreadName { get; set; }

    }
}
