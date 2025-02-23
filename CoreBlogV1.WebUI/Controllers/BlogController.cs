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
        return View(blog);
    }
}