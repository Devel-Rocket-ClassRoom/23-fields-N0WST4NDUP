ScoreTracker mathTracker = new ScoreTracker("수학");
mathTracker.ShowScore();
mathTracker.SetScore(85);
mathTracker.AddBonus(10);
mathTracker.AddBonus(20);
mathTracker.SetScore(1000);
mathTracker.ShowScore();