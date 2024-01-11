namespace MiniChallengeEightToTen_Endpoints.Services.RestaurantPicker;
public class RestaurantPickerService : IRestaurantPickerService
{
    public string[] fastFoodArr = {"McDonald's", "Burger King", "Wendy's", "In N Out", "Jack In The Box", "Taco Bell", "Five Guys", "Chick-Fil-A", "Panda Express", "Sonics"};

    public string[] pizzaArr = {"Little Caesar's Pizza", "Blaze Pizza", "Domino's Pizza", "Round Table Pizza", "Eddie's Pizza", "Mountain Mikes", "Papa Murphy's Pizza", "Pizza Hut", "Pizza Guys", "Costco's Pizza"};

    public string[] seafoodArr = {"Red Lobster", "Captain Crab Seafood Restaurant", "Blazin' Cajun Restaurant", "The Crab Zone", "Bag o'Crab", "Dynasty Seafood Restaurant", "Bud's Seafood Grille", "Beto's Mexican & Seafood", "Seafood Express", "Pacific Seafood"};

    public Random randomNumber = new();
    public string RestaurantPicker(string input)
    {
        int randomIndex = randomNumber.Next(0, 11);
        string userInput = input.ToLower();
        if(userInput == "fast food" && userInput == "pizza" && userInput == "seafood"){
            if(userInput == "fast food"){
                return fastFoodArr[randomIndex];
            } else if (userInput == "pizza"){
                return pizzaArr[randomIndex];
            } else {
                return seafoodArr[randomIndex];
            }
        }else {
            return "Invalid input, please input one of these options: 'Fast Food' | 'Pizza' | 'Seafood'";
        }
        
        
    }

}
