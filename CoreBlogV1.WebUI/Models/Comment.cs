﻿namespace CoreBlogV1.WebUI.Models;
public class Comment
{
    public int Id { get; set; }
    public int BlogId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Message { get; set; }
    public DateTime PublishDate { get; set; }
}