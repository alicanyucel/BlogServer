using BlogServer.Domain.Entities.Common;

namespace BlogServer.Domain.Entities;

public class Blog:BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string CoverImage { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Guid CategoryId { get; set; }
    public required Category Category { get; set; } // 1 to many relationship
}
