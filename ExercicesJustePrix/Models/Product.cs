using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesJustePrix.Models
{
    public class Product
    {
        private string _title;
        private string _description;
        private int _price;
        private string _imgUrl;

        public string Title { get => _title; set => _title = value; }
        public string Description { get => _description; set => _description = value; }
        public int Price { get => _price; set => _price = value; }
        public string ImgUrl { get => _imgUrl; set => _imgUrl = value; }

        public Product(string title, string description, int price, string imgUrl)
        {
            Title = title;
            Description = description;
            Price = price;
            ImgUrl = imgUrl;
        }
    }
}
