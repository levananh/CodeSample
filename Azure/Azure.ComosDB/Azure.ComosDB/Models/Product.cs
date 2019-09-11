using System.Collections.Generic;

namespace Azure.CosmosDB.Models
{
    public class Product
    {
        public string Id { get; set; }

        // nếu muốn trong database lưu dưới tên viết thường thì làm như này 
        //[JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        public List<string> Images { get; set; }

        public float Price { get; set; }

        public ProductProperty ProductProperties { get; set; }
    }
}
