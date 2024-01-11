namespace MiniChallengeEightToTen_Endpoints.Services.GuessIt;

public class GuessItService : IGuessItService
{
    public Random randomNumber = new();
    public string GuessItEasy(string num)
    {
        if(int.TryParse(num, out int number)){
            if(number >= 1 && number <= 10){
                int correctNum = randomNumber.Next(1, 11);
                if(number > correctNum){
                    return $"The correct number is lower than your guess: {num}";
                } else if (number < correctNum){
                    return $"The correct number is higher than your guess: {num}";
                } else {
                    return $"Your Guess: {num} was the correct answer! ({correctNum})";
                }
            } else {
                return "Please input a number that is 1-10";
            }
        } else {
            return "Invalid Input, please input a number that is 1-10";
        }
        
    }

    public string GuessItHard(string num)
    {
        if(Int32.TryParse(num, out int number)){
            
        }
        throw new NotImplementedException();
    }

    public string GuessItMedium(string num)
    {
        if(Int32.TryParse(num, out int number)){
            
        }
        throw new NotImplementedException();
    }
}
