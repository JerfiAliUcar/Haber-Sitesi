using AspNetMvcNews.Data.Entity.Abstract;

namespace AspNetMvcNews.Data.Entity
{
    public class CategoryNews :BaseEntity
    {

        public int? CategoryId { get; set; }
        public int? NewsId { get; set; }


        public virtual News news { get; set; }
        public virtual Category category { get; set; }


    }
}
