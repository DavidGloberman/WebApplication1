using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WebApplication1.Models
{

    public class Item
    {
        public Item(int id, string title, string category, string description, string image)
        {
            Id = id;
            Title = title;
            Category = category;
            Description = description;
            Image = image;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}