namespace GinkStories.Api;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    //public DateTime CreatedAt { get; set; }
    //public DateTime UpdatedAt { get; set; }
    public bool Deleted { get; set; }
}