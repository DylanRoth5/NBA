namespace NBA.Entities;

public class Score
{
    public static int Id;
    public static int PlayerScore;
    public static TimeSpan GameTime;

    public Score(int id,int score,TimeSpan gameTime)
    {
        Id = id;
        PlayerScore = score;
        GameTime = gameTime;
    }
}