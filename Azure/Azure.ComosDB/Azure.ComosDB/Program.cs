using Azure.CosmosDB.DbContext;
using Azure.CosmosDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azure.CosmosDB
{
    class Program
    {
        static async Task Main(string[] args)
        {
            CosmosDbRepository<Product>.Initialize();
            //var product = new Product()
            //{
            //    Id = Guid.NewGuid().ToString(),
            //    Images = new List<string>() { "image1", "image2", "image3" },
            //    Name = "Điện thoại Oppo reno",
            //    Price = 100000,
            //    ProductProperties = new ProductProperty() { Name = "color", Value = "red" }
            //};
            //await CosmosDbRepository<Product>.CreateItemAsync(product);

            var product = await CosmosDbRepository<Product>.GetItemAsync("175a40c9-bfd9-4aed-bef6-68a68ed62994");
            if (product != null)
            {
                Console.WriteLine(product.Name);
            }

            var redItem = await CosmosDbRepository<Product>.GetItemsAsync(x => x.ProductProperties.Name == "color");
            if (redItem != null)
            {
                Console.WriteLine(redItem.FirstOrDefault()?.Name);
            }

            Console.ReadLine();
        }
    }
}
