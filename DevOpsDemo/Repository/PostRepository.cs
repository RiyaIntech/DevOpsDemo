using DevOpsDemo.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Numerics;

namespace DevOpsDemo.Repository
{
    public class PostRepository : IPostRepository
    {
        public List<PostViewModel> GetPosts()
        {
            var posts = new List<PostViewModel> {
            new PostViewModel(){ PostId =101, Title = "DevOps Demo Title 1", Description ="DevOps DemoDescription 1", Author="Riya Sankesara"},
            new PostViewModel(){ PostId =102, Title = "DevOps Demo Title 2", Description ="DevOps DemoDescription 2", Author="Ritu Shah"},
            new PostViewModel() { PostId = 103, Title = "DevOps Demo Title 3", Description = "DevOps DemoDescription 3", Author = "Darshil Shah" },
            };
            return posts;
        }
    }
}
