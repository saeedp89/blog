namespace Domain.Entities;

public class Post
{
    public Post()
    {
        CreatedAt = DateTime.Now;
    }

    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Body { get; set; }

    public DateTime CreatedAt { get; set; }
}