using System.ComponentModel.DataAnnotations;

namespace GinkStories.Domain.Entities;

public class User
{
    [Key]
    public int id { get; set; }
    public string name { get; set; } = string.Empty;
    public string email { get; set; } = string.Empty;
    public string password { get; set; } = string.Empty;
    //public DateTime CreatedAt { get; set; }
    //public DateTime UpdatedAt { get; set; }
    public bool deleted { get; set; }
}