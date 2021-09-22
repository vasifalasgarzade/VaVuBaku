using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TCYDMWebApp.Libs;
using VavuBakuMVCcore.Models;

namespace VavuBakuMVCcore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogsController : Controller
    {
        
        public async Task<IActionResult> Index()
        {
            List<Blog> blogs = new List<Blog>();
           using (var httpclient = new HttpClient())
            {
                using var request = await httpclient.GetAsync("http://localhost:62914/api/v1/blog/blogList/");
                string response = await request.Content.ReadAsStringAsync();

                blogs = JsonConvert.DeserializeObject<List<Blog>>(response);
            }
            return View(blogs);
        }
       public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,Photo,PhotoUpload,Tittle,Description")] Blog blog)
        {
            if (blog.PhotoUpload.Length < (1024 * 1024) * 2 &&
               (blog.PhotoUpload.ContentType == "image/png" ||
                blog.PhotoUpload.ContentType == "image/svg+xml" ||
                blog.PhotoUpload.ContentType == "image/jpeg"))
            {
                var filename = FileManager.IFormSaveLocal(blog.PhotoUpload, null);
                blog.Photo = filename;
            }
            using (var httpClient = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(blog), Encoding.UTF8, "application/json");

                using var reguest = await httpClient.PostAsync($"http://localhost:62914/api/v1/blog/create", content);
                string response = await reguest.Content.ReadAsStringAsync();
            }
            return RedirectToAction("index");

        }
        public async Task<IActionResult> Edit(int id)
        {


            Blog blog = new Blog();
            using (var httpclient = new HttpClient())
            {
                using var request = await httpclient.GetAsync("http://localhost:62914/api/v1/blog/" + id);
                string response = await request.Content.ReadAsStringAsync();

                blog = JsonConvert.DeserializeObject<Blog>(response);
            }
            return View(blog);
        }

        [HttpPost]
        public async Task<IActionResult> Edit([Bind("Id,Photo,PhotoUpload,Tittle,Description")] Blog blog)
        {

            if (blog.PhotoUpload.Length < (1024 * 1024) * 2 && (blog.PhotoUpload.ContentType == "image/png" ||
             blog.PhotoUpload.ContentType == "image/svg+xml" ||
              blog.PhotoUpload.ContentType == "image/jpeg"))
            {
                var filename = FileManager.IFormSaveLocal(blog.PhotoUpload, null);
                blog.Photo = filename;
            }
            using (var httpClient = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(blog), Encoding.UTF8, "application/json");

                using var reguest = await httpClient.PutAsync($"http://localhost:62914/api/v1/blog/edit/", content);
                string response = await reguest.Content.ReadAsStringAsync();
            }
            return RedirectToAction("index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            using (var httpClient = new HttpClient())
            {
                using var reguest = await httpClient.DeleteAsync($"http://localhost:62914/api/v1/blog/delete/{id}");

            }
            return RedirectToAction("index");
        }
    }
}
