using System.ComponentModel.DataAnnotations;

namespace MovieEntity
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}