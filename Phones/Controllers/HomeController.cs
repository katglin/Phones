using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Phones.Models;

namespace Phones.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var images = GetPopularImages();
            ViewBag.images = images;
            var phones = GetPhones();
            return View(phones);
        }

        private IEnumerable<string> GetPopularImages()
        {
            List<string> images = new List<string>();
            string parent = new DirectoryInfo(Server.MapPath("~/Storage/Images/Popular/")).FullName;
            images = Directory.EnumerateFiles(parent)
                              .Select(fn => "~/Storage/Images/Popular/" + Path.GetFileName(fn)).ToList();

            return images;
        }

        private IEnumerable<PhoneViewModel> GetPhones()
        {
            List<PhoneViewModel> phones = new List<PhoneViewModel>
            {
                new PhoneViewModel
                {
                    ImagePath = "~/Storage/Images/Phones/1.jpeg",
                    Title = "HUAWEI P30 PRO//P30",
                    Description = "The smaller Pixel 3 starts at $799 while the Pixel 3 XL starts at $899 for the 64GB model." +
                    	" They are both powered by Android 9.0 Pie and will receive OS upgrades for three years. Google's newest" +
                    	" Assistant features are present along with some other Google software advances.",
                    Price = 10350.99f
                },
                new PhoneViewModel
                {
                    ImagePath = "~/Storage/Images/Phones/2.jpg",
                    Title = "SAMSUNG GALAXY S10//S10 PLUS",
                    Description = "The smaller Pixel 3 starts at $799 while the Pixel 3 XL starts at $899 for the 64GB model." +
                        " They are both powered by Android 9.0 Pie and will receive OS upgrades for three years. Google's newest" +
                        " Assistant features are present along with some other Google software advances.",
                    Price = 15350.99f
                },
                new PhoneViewModel
                {
                    ImagePath = "~/Storage/Images/Phones/3.jpeg",
                    Title = "SAMSUNG GALAXY NOTE 9",
                    Description = "The smaller Pixel 3 starts at $799 while the Pixel 3 XL starts at $899 for the 64GB model." +
                        " They are both powered by Android 9.0 Pie and will receive OS upgrades for three years. Google's newest" +
                        " Assistant features are present along with some other Google software advances.",
                    Price = 3120.99f
                },
                new PhoneViewModel
                {
                    ImagePath = "~/Storage/Images/Phones/4.jpg",
                    Title = "HUAWEI MATE 20 PRO",
                    Description = "The smaller Pixel 3 starts at $799 while the Pixel 3 XL starts at $899 for the 64GB model." +
                        " They are both powered by Android 9.0 Pie and will receive OS upgrades for three years. Google's newest" +
                        " Assistant features are present along with some other Google software advances.",
                    Price = 7200.99f
                },
                new PhoneViewModel
                {
                    ImagePath = "~/Storage/Images/Phones/5.jpeg",
                    Title = "SAMSUNG GALAXY S10E",
                    Description = "The smaller Pixel 3 starts at $799 while the Pixel 3 XL starts at $899 for the 64GB model." +
                        " They are both powered by Android 9.0 Pie and will receive OS upgrades for three years. Google's newest" +
                        " Assistant features are present along with some other Google software advances.",
                    Price = 5350.0f
                }
            };
            return phones;
        }
    }
}