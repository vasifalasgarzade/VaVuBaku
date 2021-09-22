using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TCYDMWebApp.Libs;
using VavuBakuMVCcore.Areas.Admin.ViewModels;
using VavuBakuMVCcore.Models;

namespace VavuBakuMVCcore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutsController : Controller
    {

        // about get method
        public async Task<IActionResult> Index()
        {

            AboutViewModel model = new AboutViewModel();

            List<About> abouts = new List<About>();
                
                using (var httpclient = new HttpClient())
                {
                    using var request = await httpclient.GetAsync("http://localhost:62914/api/v1/about/aboutlist");
                    string response = await request.Content.ReadAsStringAsync();

                    abouts = JsonConvert.DeserializeObject<List<About>>(response);
                }
            model.Abouts = abouts;
            About about = new About();

            using (var httpclient = new HttpClient())
            {
                using var request = await httpclient.GetAsync("http://localhost:62914/api/v1/about/");
                string response = await request.Content.ReadAsStringAsync();

                about = JsonConvert.DeserializeObject<About>(response);
            }
            model.Abouts = abouts;
            return View(model);
        }

        // about get create
        public IActionResult Create()
        {
            return View();
        }

        // about post method

        [HttpPost]
        public async Task<IActionResult>Create([Bind("Id,Photo,PhotoUpload,Title,Description")] About about)
        {
            if (about.PhotoUpload.Length < (1024 * 1024) * 2 && (about.PhotoUpload.ContentType == "image/png" ||
                about.PhotoUpload.ContentType == "image/svg+xml" ||
                 about.PhotoUpload.ContentType == "image/jpeg"))
            {
                var filename = FileManager.IFormSaveLocal(about.PhotoUpload, null);
                about.Photo = filename;
            }
            using (var httpClient = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(about), Encoding.UTF8, "application/json");
                using var reguest = await httpClient.PostAsync($"http://localhost:62914/api/v1/about/create", content);
                string response = await reguest.Content.ReadAsStringAsync();
            }
            return RedirectToAction("index");

        }
        // about put/edit method

        public async Task<IActionResult> Edit(int id)
        {


            About abouts = new About();
            using (var httpclient = new HttpClient())
            {
                using var request = await httpclient.GetAsync("http://localhost:62914/api/v1/about/"+id);
                string response = await request.Content.ReadAsStringAsync();

                abouts = JsonConvert.DeserializeObject<About>(response);
            }
            return View(abouts);
        }
        [HttpPost]

        public async Task<IActionResult> Edit([Bind("Id,Photo,PhotoUpload,Title,Description")] About about)
        {
            if (about.PhotoUpload.Length < (1024 * 1024) * 2 && (about.PhotoUpload.ContentType == "image/png" ||
              about.PhotoUpload.ContentType == "image/svg+xml" ||
               about.PhotoUpload.ContentType == "image/jpeg"))
            {
                var filename = FileManager.IFormSaveLocal(about.PhotoUpload, null);
                about.Photo = filename;
            }


            using (var httpClient = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(about), Encoding.UTF8, "application/json");

                using var reguest = await httpClient.PutAsync($"http://localhost:62914/api/v1/about/edit/", content);
                string response = await reguest.Content.ReadAsStringAsync();
            }
            return RedirectToAction("index");
        }

        // about delete method
        public async Task<IActionResult> Delete(int id)
        {
            using (var httpClient = new HttpClient())
            {
                using var reguest = await httpClient.DeleteAsync($"http://localhost:62914/api/v1/about/delete/{id}");

            }
            return RedirectToAction("index");
        }

      


       



    }
}
