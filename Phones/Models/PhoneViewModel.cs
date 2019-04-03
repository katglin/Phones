using System;
using System.ComponentModel.DataAnnotations;

namespace Phones.Models
{
    public class PhoneViewModel
    {
        public string ImagePath { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
    }
}
