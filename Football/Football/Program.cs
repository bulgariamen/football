using Football;

Game game = new Game();
Team team1, team2;

Goalkeeper goalkeeperT1 = new Goalkeeper("John", 1, 25, 180.5);
Defender defender1T1 = new Defender ("Mike", 2, 28, 175.0);
Defender defender2T1 = new Defender ("Joel", 3, 28, 175.0);
Defender defender3T1 = new Defender ("Musa", 4, 28, 175.0);
Defender defender4T1 = new Defender ("Ivan", 5, 28, 175.0);
Midfield midfield1T1 = new Midfield ("Kira", 8, 27, 185.0);
Midfield midfield2T1 = new Midfield ("Mitchell", 6, 27, 185.0);
Midfield midfield3T1 = new Midfield ("Jim", 9, 27, 185.0);
Striker striker1T1 = new Striker ("Eugene", 7, 30, 190.0);
Striker striker2T1 = new Striker ("Frederick", 10, 30, 190.0);
Striker striker3T1 = new Striker ("Alex", 11, 30, 190.0);

Goalkeeper goalkeeperT2 = new Goalkeeper("Niall", 1, 30, 175.0);
Defender defender1T2 = new Defender("Usman", 2, 28, 175.0);
Defender defender2T2 = new Defender("Marshall", 3, 28, 175.0);
Defender defender3T2 = new Defender("Aiden", 4, 30, 175.0);
Defender defender4T2 = new Defender("Floyd", 5, 28, 175.0);
Midfield midfield1T2 = new Midfield("Peter", 6, 32, 185.0);
Midfield midfield2T2 = new Midfield("Oskar", 7, 31, 175.0);
Midfield midfield3T2 = new Midfield("David", 8, 29, 185.0);
Striker striker1T2 = new Striker("Nora", 9, 30, 190.0);
Striker striker2T2 = new Striker("Marvin", 10, 30, 175.0);
Striker striker3T2 = new Striker("Ioan", 11, 33, 190.0);

team1 = new Team(new Coach("Renee", 40), new List<FootballPlayer>
{
    goalkeeperT1,
    defender1T1,
    defender2T1,
    defender3T1,
    defender3T1,
    midfield1T1,
    midfield2T1,
    midfield3T1,
    striker1T1,
    striker2T1,
    striker3T1
});
team2 = new Team(new Coach("Charlie", 45), new List<FootballPlayer>
{
    goalkeeperT2,
    defender1T2,
    defender2T2,
    defender3T2,
    defender3T2,
    midfield1T2,
    midfield2T2,
    midfield3T2,
    striker1T2,
    striker2T2,
    striker3T2
});

game.Team1 = team1;
game.Team2 = team2;
game.Referee = new Referee("Referee 1", 35);
game.AssistantReferees.Add(new Referee("Assistant Referee 1", 30));
game.AssistantReferees.Add(new Referee("Assistant Referee 2", 32));
game.Goals.Add(30, striker1T1);
game.Goals.Add(35, striker2T2);
game.Goals.Add(46, striker3T2);
game.Goals.Add(70, striker1T1);
game.Goals.Add(89, striker1T2);

Console.WriteLine("Game Result: " + game.GameResult);
Console.WriteLine("Winner: " + game.Winner);
Console.WriteLine("Team 1 Coach: " + game.Team1.Coach.Name);
Console.WriteLine("Team 1 Average Age: " + game.Team1.AverageAgeOfPlayers);
Console.WriteLine("Team 2 Coach: " + game.Team2.Coach.Name);
Console.WriteLine("Team 2 Average Age: " + game.Team2.AverageAgeOfPlayers);
Console.WriteLine("Goals:");

foreach (var goal in game.Goals)
{
    Console.WriteLine(" - Minute: " + goal.Key + ", Player: " + goal.Value.Name);
}
