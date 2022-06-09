using System.Text.Json.Serialization;

namespace WebAPI.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        [JsonIgnore]
        public List<Article>? Articles { get; set; }
    }
}
