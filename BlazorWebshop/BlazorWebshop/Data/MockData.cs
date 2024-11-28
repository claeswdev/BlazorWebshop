using BlazorWebshop.Models;

namespace BlazorWebshop.Data
{
    public class MockData
    {
        public List<Product> SeedProducts()
        {
            return new List<Product>()
            {
                new Product
                {
                    ProductId = 1,
                    ProductName = "Camera",
                    Description = "Latest specs and quality built. Cheap too!",
                    ImageUrl = "/images/products/camera.jpg",
                    Price = 199,
                    Category = Categories.Tech
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "Lipstick",
                    Description = "Because you're worth it.",
                    ImageUrl = "/images/products/makeup.jpg",
                    Price = 29.99,
                    Category = Categories.MakeUp
                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "Milk",
                    Description = "Nutrishiously good for you, makes you bone-hard.",
                    ImageUrl = "/images/products/milk.jpg",
                    Price = 15.99,
                    Category = Categories.Food
                },
                new Product {
                    ProductId = 4,
                    ProductName = "Pancakes",
                    Description = "Delicious, fluffy pancakes, with maple syrap and bacon for sides. Yum-yum!",
                    ImageUrl = "images/products/pancakes.jpg",
                    Price = 15.50,
                    Category = Categories.Food
                },
                new Product
                {
                    ProductId = 5,
                    ProductName = "Screws",
                    Description = "Very useful, and in a hard material for longevity. 9/10 carpenters would recommend.",
                    ImageUrl = "images/products/screws.jpg",
                    Price = 4.99,
                    Category= Categories.Construction
                },
                new Product
                {
                    ProductId = 6,
                    ProductName = "Watch",
                    Description = "Keeps the time really well, and portable too. Comes with the latest design from Zurich, Switzerland",
                    ImageUrl = "images/products/watch.jpg",
                    Price = 1499.99,
                    Category = Categories.Tech
                }
            };
        }
    }
}
