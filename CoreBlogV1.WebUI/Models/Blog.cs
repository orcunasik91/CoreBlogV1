namespace CoreBlogV1.WebUI.Models;
public class Blog
{
    public int BlogId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public DateTime PublishDate { get; set; }
    public string Tags { get; set; }
    public int LikeCount { get; set; }
    public int CommentCount { get; set; }
    public int ViewCount { get; set; }
    public bool IsStatus { get; set; }
}