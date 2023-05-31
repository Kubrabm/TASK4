using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace OganiWebsite.DataAccessLayer.Entities
{
    public class LatestProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImgUrl { get; set; }
    }
}
