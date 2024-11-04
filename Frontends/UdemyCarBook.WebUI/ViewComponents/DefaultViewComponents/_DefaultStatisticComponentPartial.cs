using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using UdemyCarBook.Dto.StatisticsDtos;

namespace UdemyCarBook.WebUI.ViewComponents.DefaultViewComponents
{
	public class _DefaultStatisticComponentPartial : ViewComponent
	{
        private readonly IHttpClientFactory _httpClientFactory;
        public _DefaultStatisticComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
		{
            Random random = new Random();

            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync("https://localhost:7005/api/Statistics/GetCarCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                int v1 = random.Next(0, 101);
                ViewBag.v1 = v1;
                ViewBag.carcount = values.carCount;
            }

            var responseMessage2 = await client.GetAsync("https://localhost:7005/api/Statistics/GetLocationCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                int locationCountRandom = random.Next(0, 101);
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData2);
                ViewBag.locationcount = values2.locationCount;
                ViewBag.locationCountRandom = locationCountRandom;
            }


            var responseMessage5 = await client.GetAsync("https://localhost:7005/api/Statistics/GetBrandCount");
            if (responseMessage5.IsSuccessStatusCode)
            {
                int brandCountRandom = random.Next(0, 101);
                var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
                var values5 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData5);
                ViewBag.brandCount = values5.brandCount;

                ViewBag.brandCountRandom = brandCountRandom;
            }

            var responseMessage4 = await client.GetAsync("https://localhost:7005/api/Statistics/GetBlogCount");
            if (responseMessage4.IsSuccessStatusCode)
            {
                int blogCountRandom = random.Next(0, 101);

                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var values4 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData4);
                ViewBag.blogCount = values4.blogCount;

                ViewBag.blogCountRandom = blogCountRandom;
            }
            return View();
		}
	}
}
