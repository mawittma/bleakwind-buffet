using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;


namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IEnumerable<IOrderItem> Items { get; set; }
        public string SearchTerms { get; set; }

        public string[] FoodType { get; set; }

        public double? PriceMin { get; set; }

        public double? PriceMax { get; set; }

        public uint? CaloriesMin { get; set; }

        public uint? CaloriesMax { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string searchTerms, string[] foodType, double? priceMin, double? priceMax, uint? caloriesMin, uint? caloriesMax)
        {
            Items = Menu.Search(searchTerms);
            Items = Menu.FilterByFoodType(Items, foodType);
            Items = Menu.FilterByPrice(Items, priceMin, priceMax);
            Items = Menu.FilterByCalories(Items, caloriesMin, caloriesMax);
            SearchTerms = searchTerms;
            FoodType = foodType;
            PriceMax = priceMax;
            PriceMin = priceMin;
            CaloriesMax = caloriesMax;
            CaloriesMin = caloriesMin;

            //SearchTerms = Request.Query["SearchTerms"];
            //FoodType = Request.Query["FoodType"];
            
        }
    }
}
