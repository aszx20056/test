using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SQLite;
using corevue.DAL;
using corevue.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace corevue.Controllers
{
    [Route("api/[controller]")]
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("[action]")]
        public IActionResult Add([FromForm]string jstr,[FromForm] string Title)
        {
            //string res = a.Content.ReadAsAsync();
            //string jstr = "";
            string t = Title.Trim();
            Post b = JsonConvert.DeserializeObject<Post>(jstr);
            using (var db = new BloggingContext())
            {
                db.Add(b);
                var count = db.SaveChanges();
                Console.WriteLine();
            }
            return Ok("done");
        }
    }
}
