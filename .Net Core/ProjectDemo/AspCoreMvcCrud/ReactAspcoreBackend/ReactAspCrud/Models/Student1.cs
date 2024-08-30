using System.ComponentModel.DataAnnotations;

namespace ReactAspCrud.Models
{
    public class Student1
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        

    }
}
