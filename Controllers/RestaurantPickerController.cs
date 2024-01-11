using Microsoft.AspNetCore.Mvc;
using MiniChallengeEightToTen_Endpoints.Services.RestaurantPicker;

namespace MiniChallengeEightToTen_Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        private readonly IRestaurantPickerService _restaurantPickerService;

        public RestaurantPickerController(IRestaurantPickerService restaurantPickerService)
        {
            _restaurantPickerService = restaurantPickerService;
        }

        [HttpGet]
        [Route("Fast Food? Pizza? Seafood?/{category}")]
        public string RestaurantPicker(string category){
            return _restaurantPickerService.RestaurantPicker(category);
        }
    }
}