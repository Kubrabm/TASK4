using OganiWebsite.DataAccessLayer.Entities;

namespace OganiWebsite.ViewModels
{
    public class ShopViewModel

    {
        public List<Sale> Sales { get; set; }
        public List<Discount> Discounts { get; set; }
        public List<DepartmentShop> DepartmentShops { get; set; }
        public List<Color> Colors { get; set; }
        public List<Size> Sizes { get; set; }
        public List<LatestProduct> LatestProducts { get; set; }
        public List<Breadcrumb> Breadcrumbs { get; set; }





    }
}
