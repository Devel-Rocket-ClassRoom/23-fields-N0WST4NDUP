using System;

ScoreTracker mathTracker = new ScoreTracker("수학");
mathTracker.ShowScore();
mathTracker.SetScore(85);
mathTracker.AddBonus(10);
mathTracker.AddBonus(20);
mathTracker.SetScore(1000);
mathTracker.ShowScore();

class ScoreTracker
{
    private const int k_MaxScore = 100;
    private const int k_MinScore = 0;
    private int _currScore = 0;
    private int _bonusCount = 0;

    public string Course;

    public ScoreTracker(string course)
    {
        this.Course = course;
    }

    public void SetScore(int score)
    {
        if (score > k_MaxScore || score < k_MinScore)
        {
            Console.WriteLine($"점수는 {k_MinScore}~{k_MaxScore} 사이여야 합니다.");
            return;
        }

        _currScore = score;
        Console.WriteLine($"점수를 {score}점으로 설정했습니다.");
    }

    public void AddBonus(int bonus)
    {
        _currScore = Math.Min(k_MaxScore, _currScore + bonus);
        _bonusCount++;
        Console.WriteLine($"{bonus}점 보너스 적용! 현재 점수: {_currScore}");
    }

    public void ShowScore()
    {
        Console.WriteLine(
            $"=== {Course} ===" + "\n" +
            $"점수: {_currScore}/{k_MaxScore}" + "\n" +
            $"보너스 적용 횟수: {_bonusCount}" + "\n"
            );
    }
}