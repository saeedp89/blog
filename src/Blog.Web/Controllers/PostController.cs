using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Blog.Web.Models;
using Microsoft.EntityFrameworkCore;
using Blog.Web.Data;

namespace Blog.Web.Controllers;

public class PostController : Controller
{
    private readonly BlogDbContext _dbContext;

    public PostController(BlogDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    [HttpGet]
    public IActionResult Get(int id)
    {
        var post=_dbContext.Posts.Find(id);
        return View(post);
    }

    [HttpGet]
    public IActionResult Edit()
    {
        return View(new Post());
    }

    [HttpPost]
    public IActionResult Edit(Post model)
    {
        _dbContext.Add(model);
        _dbContext.SaveChanges();
        return RedirectToAction("Index","Home");
    }
}
