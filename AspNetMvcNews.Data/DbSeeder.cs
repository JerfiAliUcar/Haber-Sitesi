using AspNetMvcNews.Data.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetMvcNews.Data
{
    public class DbSeeder
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<AppDbContext>();
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var Categories = new List<Category>()
                {
                    new Category() {  Name = "Spor", Description = "Spor Haberleri" },
                    new Category() {  Name = "Gündem", Description = "Gündem Haberleri" },
                    new Category() {  Name = "Ekonomi", Description = "Ekonomi Haberleri" },
                    new Category() {  Name = "Teknoloji", Description = "Teknoloji Haberleri" },
                };
                context.Categories.AddRange(Categories);
                context.SaveChanges();

                var Users = new List<User>()
                {
                    new User() {Name="Jerfi Ali",Email="jali@gmail.com",Password="1234",City="Londra"},
                    new User() {Name="Ahmet",Email="ahmet@gmail.com",Password="12345",City="Toronto"},
                    new User() {Name="Dilay",Email="dilay@gmail.com",Password="123456",City="Kars"},
                };
                context.Users.AddRange(Users);
                context.SaveChanges();

                var Settings = new List<Setting>()
                {
                    new Setting(){UserId= 1, Name="Kullanıcı Ayarları",Value=" " },
                    new Setting(){UserId= 2, Name="Sayfa Ayarları",Value=" " },
                    new Setting(){UserId= 3, Name="Yetkilendirme Ayarları",Value=" " },
                    new Setting(){UserId= 3, Name="Güvenlik Ayarları",Value=" " },
                };
                context.Settings.AddRange(Settings);
                context.SaveChanges();

                var Pages = new List<Page>()
                {
                    new Page() { Title ="Lorem1",Content="Integer a ligula facilisis, cursus mauris sed, dictum turpis. ", IsActive=true },
                    new Page() { Title ="Lorem2",Content="Integer a ligula facilisis, cursus mauris sed, dictum turpis. ", IsActive=true },
                    new Page() { Title ="Lorem3",Content="Integer a ligula facilisis, cursus mauris sed, dictum turpis. ", IsActive=true }
                };
                context.Pages.AddRange(Pages);
                context.SaveChanges();

                var News = new List<News>()
                {
                    new News() {UserId = 1,CreatedAt=DateTime.Now.ToString("MMMM dd,yyyy"), Title = "GS-FB derbi sonucu", Content = "GS fenerbahceyi 7-0 YENDİ.  printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum." },
                    new News() {UserId = 2,CreatedAt=DateTime.Now.ToString("MMMM dd,yyyy"), Title = "Trabzonspor Yeni Transfer", Content = "Ahmet Topdaş artık Trabzonspor'da!!.  printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum." },
                    new News() {UserId = 3,CreatedAt=DateTime.Now.ToString("MMMM dd,yyyy"), Title = "Yeni Savaş Uçakları", Content = "F-35'ler yolda.  printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum." },
                    new News() {UserId = 1,CreatedAt=DateTime.Now.ToString("MMMM dd,yyyy"), Title = "Zam Zam Zam !!", Content = "Benzine yeniden 2TL zam geldi.  printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum." },
                    new News() {UserId = 2,CreatedAt=DateTime.Now.ToString("MMMM dd,yyyy"), Title = "Dolar düştü TL Değer Kazandı", Content = "Dolar düştü TL Değer KazandıLorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum." },
                    new News() {UserId = 3,CreatedAt=DateTime.Now.ToString("MMMM dd,yyyy"), Title = "Teknolojik ürünlere zam geldi", Content = "Tüm teknolojik ürünlere %20 zam.Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum." },
                    new News() {UserId = 1,CreatedAt=DateTime.Now.ToString("MMMM dd,yyyy"), Title = "Türkiye'nin Büyük Bankası Metaverse'de Ofis Açtı", Content = "Türkiye'nin Büyük Bankası Metaverse'de Ofis AçtıLorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum." },
                    new News() {UserId = 2,CreatedAt=DateTime.Now.ToString("MMMM dd,yyyy"), Title = "AMD yeni ekran katını piyasaya sürdü", Content = "AMD'nin yeni ekran kartı İntel'i korkutmayı başardı.Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum." },
                };
                context.News.AddRange(News);
                context.SaveChanges();

                var NewsComment = new List<NewsComment>()
                {
                    new NewsComment() { PostId= 1, UserId= 1, Comment="Lorem ipsum dolor sit amet, consectetur adipiscing elit.", IsActive=true},
                    new NewsComment() { PostId= 2, UserId= 2, Comment="Lorem ipsum.", IsActive=true},
                    new NewsComment() { PostId= 1, UserId= 3, Comment="Lorem ipsum dolor sit amet.", IsActive=true}
                };
                context.NewsComments.AddRange(NewsComment);
                context.SaveChanges();

                var NewsImages = new List<NewsImage>()
                {
                    new NewsImage() { NewsId = 1, ImagePath = "https://ajssarimg2.mediatriple.net/1604593.jpg.webp?w=1200&h=675" },
                    new NewsImage() { NewsId = 2, ImagePath = "https://img.fanatik.com.tr/img/78/740x418/629e5c3266a97c9a13651fd3.jpg" },
                    new NewsImage() { NewsId = 3, ImagePath = "https://img.piri.net/mnresize/840/-/resim/imagecrop/2022/03/03/12/01/resized_995a2-e3d826e8ukraynadireniyor.jpg" },
                    new NewsImage() { NewsId = 4, ImagePath = "https://icdn.ensonhaber.com/resimler/diger/kok/2022/06/07/akaryakit-zam_8270.jpg" },
                    new NewsImage() { NewsId = 5, ImagePath = "https://iasbh.tmgrup.com.tr/5a7356/960/505/0/0/1138/600?u=https://isbh.tmgrup.com.tr/sbh/2020/12/28/son-dakika-haber-dolar-kuru-sert-dustu-dolar-dususunu-surdurecek-mi-1609159656901.jpg" },
                    new NewsImage() { NewsId = 6, ImagePath = "https://donanimgunlugu.com/wp-content/upload/2021/03/1-63.png" },
                    new NewsImage() { NewsId = 7, ImagePath = "https://www.kriptoarena.com/wp-content/uploads/2022/02/ff79.jpg"},
                    new NewsImage() { NewsId = 8, ImagePath = "https://www.amd.com/system/files/2022-04/1375711-ryzen-pro-6000-angle-1260x709_0.jpg"}
                };
                context.NewsImages.AddRange(NewsImages);
                context.SaveChanges();

                var CategoryNews = new List<CategoryNews>
                {
                new CategoryNews() { CategoryId = 1, NewsId = 1 },
                new CategoryNews() { CategoryId = 1, NewsId = 2 },
                new CategoryNews() { CategoryId = 2, NewsId = 3 },
                new CategoryNews() { CategoryId = 2, NewsId = 4 },
                new CategoryNews() { CategoryId = 3, NewsId = 5 },
                new CategoryNews() { CategoryId = 3, NewsId = 6},
                new CategoryNews() { CategoryId = 4, NewsId = 7 },
                new CategoryNews() { CategoryId = 4, NewsId = 8},
            };
                context.CategoryNews.AddRange(CategoryNews);
                context.SaveChanges();
            }
        }
    }
}