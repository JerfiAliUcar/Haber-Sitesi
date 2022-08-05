using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;

namespace AspNetMvcNews.Web.Mvc.ViewComponents
{
    public class TopHeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var client = new RestClient();
            var request = new RestRequest("https://api.collectapi.com/economy/currencyToAll?int=10&base=USD", Method.Get);
            request.AddHeader("authorization", "apikey 7JLGBi5nz73Aa7VpR6KFsg:48hhnuouJDikyGE1Y09T1X");
            request.AddHeader("content-type", "application/json");
            var response = client.Execute(request);
            dynamic content = JsonConvert.DeserializeObject<dynamic>(response.Content);

            double rateTl = Convert.ToDouble(content.result.data[49].rate);
            double rateEuro = Convert.ToDouble(content.result.data[14].rate);

            ViewBag.DolarKuru = rateTl.ToString("0.00");
            ViewBag.EuroKuru = ((2 - rateEuro) * rateTl).ToString("0.00");

            return View();
        }
    }
}
