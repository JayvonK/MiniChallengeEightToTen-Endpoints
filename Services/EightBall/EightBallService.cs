namespace MiniChallengeEightToTen_Endpoints.Services.EightBall;

public class EightBallService : IEightBallService
{
    public string[] answers = new string[];

    public EightBallService()
    {
        answers = ["My reply is no", "Try again later", "Cannot predict now", "Signs Point to No", "Definitely", "Most Likely", "My sources are saying no", "You may rely on it"]
    }
    public string AskMe(string input)
    {
        Random randomGen = new Random();
        int randomIndex = randomGen.Next(0, answers.Length);
        return answers[randomIndex];
    }
}
