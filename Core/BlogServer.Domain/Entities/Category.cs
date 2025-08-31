
using BlogServer.Domain.Entities.Common;

namespace BlogServer.Domain.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public required IList<Blog> Blogs { get; set; } // 1 to many relationship

}