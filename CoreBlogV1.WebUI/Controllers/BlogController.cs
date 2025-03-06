using CoreBlogV1.WebUI.Context;
using CoreBlogV1.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlogV1.WebUI.Controllers;
public class BlogController(BlogAppContext context) : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        List<Blog> blogs = context.Blogs.Where(blog => blog.IsStatus == true).ToList();
        return View(blogs);
    }
    [HttpGet]
    public IActionResult Details(int id)
    {
        Blog blog = context.Blogs.Find(id);
        blog.ViewCount += 1;
        context.SaveChanges();
        List<Comment> comments = context.Comments.Where(c => c.BlogId == id).ToList();
        ViewBag.Comments = comments;
        return View(blog);
    }
    [HttpPost]
    public IActionResult CreateComment(Comment comment)
    {
        comment.PublishDate = Convert.ToDateTime(DateTime.Now.ToString("G"));
        context.Comments.Add(comment);
        var blog = context.Blogs.Where(b => b.BlogId == comment.BlogId).FirstOrDefault();
        blog.CommentCount += 1;
        context.SaveChanges();
        return RedirectToAction("Details", new { id = comment.BlogId });
    }
}