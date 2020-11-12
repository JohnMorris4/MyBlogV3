using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyBlogV3.Models;

namespace MyBlogV3.Data.Repository
{
    public interface IRepository
    {
        Post GetPost(int id);
        List<Post> GetAllPosts();
        void AddPost(Post post);
        void RemovePost(int id);
        void UpdatePost(Post post);

        Task<bool> SaveChangesAsync();
        
    }
}
