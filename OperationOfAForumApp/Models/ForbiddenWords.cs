using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OperationOfAForumApp.Models
{
    [Table("ForbiddenWords")]
    public class ForbiddenWords
    {
        [Key]
        public int Id { get; set; }

        public string Word { get; set; }

    }
}
