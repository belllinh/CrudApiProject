using System.ComponentModel.DataAnnotations;

namespace CrudApiProject.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public string? FirstName {  get; set; }

        public string? LastName {  get; set; }

        public string? EmailAddress { get; set; }


    }
}
