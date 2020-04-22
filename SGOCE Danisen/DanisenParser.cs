using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGOCE_Danisen
{
    class DanisenParser
    {
        public DanisenParser(string input_path, string output_path, string output_path_2, string history_path)
        {
            InputPath = input_path;
            OutputPath = output_path;
            OutputPath2 = output_path_2;
            HistoryPath = history_path;

            // Initialise ranks
            ranks = new List<Rank>();
            ranks.Add(new Rank(RankNames.UR, 1, -1, RankNames.UR, RankNames.C));
            ranks.Add(new Rank(RankNames.C, 3, -3, RankNames.UR, RankNames.B));
            ranks.Add(new Rank(RankNames.B, 3, -3, RankNames.C, RankNames.A));
            ranks.Add(new Rank(RankNames.A, 3, -3, RankNames.B, RankNames.S));
            ranks.Add(new Rank(RankNames.S, 5, -1, RankNames.A, RankNames.S));
        }

        public void Go()
        {
            List<string> output = new List<string>();
            players = new List<Player>();

            playerHistory = new List<List<string>>();

            if (!File.Exists(InputPath))
                return;

            var lines = File.ReadLines(InputPath);
            bool header = true;

            // Loop through lines
            foreach (string l in lines)
            {
                if (header)
                {
                    // Skip first row
                    header = false;
                    output.Add(l);
                    continue;
                }

                var line = l.Split(',');

                // Get names of participants
                string winnerName = line[1];
                string loserName = line[8];

                // Get indexes of match participants
                int winnerIndex = GetPlayerIndex(winnerName);
                int loserIndex = GetPlayerIndex(loserName);

                // Get starting rank/score of participants
                int winnerRank = players[winnerIndex].rank;
                int winnerStartScore = players[winnerIndex].score;

                int loserRank = players[loserIndex].rank;
                int loserStartScore = players[loserIndex].score;

                // Update line string array with starting rank/score
                line[2] = ((RankNames)players[winnerIndex].rank).ToString();
                line[3] = players[winnerIndex].score.ToString();

                line[9] = ((RankNames)players[loserIndex].rank).ToString();
                line[10] = players[loserIndex].score.ToString();

                // Simulate match
                SimulateMatch(winnerIndex, loserIndex);

                // Update line string array with ending rank/score
                line[6] = ((RankNames)players[winnerIndex].rank).ToString();
                line[7] = players[winnerIndex].score.ToString();

                line[13] = ((RankNames)players[loserIndex].rank).ToString();
                line[14] = players[loserIndex].score.ToString();

                // Rejoin line
                output.Add(string.Join(",", line));

                playerHistory[winnerIndex].Add(string.Join(",", line));
                playerHistory[loserIndex].Add(string.Join(",", line));
            }

            // Save file
            if (!string.IsNullOrEmpty(OutputPath))
            {
                using (var w = new StreamWriter(OutputPath))
                {
                    foreach (var l in output)
                    {
                        w.WriteLine(l);
                        w.Flush();
                    }
                }
            }

            // Save file
            if (!string.IsNullOrEmpty(OutputPath2))
            {
                // Sort players list
                var sortedList = players
                    .OrderByDescending(l => l.rank)
                    .ThenByDescending(l => l.score)
                    .ThenBy(l => l.name);

                using (var w = new StreamWriter(OutputPath2))
                {
                    foreach (var p in sortedList)
                    {
                        string line = string.Format("{0},{1},{2}", (RankNames)p.rank, p.name, p.score);
                        w.WriteLine(line);
                        w.Flush();
                    }
                }
            }

            // Save player history
            if (!string.IsNullOrEmpty(HistoryPath))
            {
                // Make directory if it doesnt exist
                System.IO.Directory.CreateDirectory(HistoryPath);

                // Loop through players
                for (int i = 0; i < playerHistory.Count; i++)
                {
                    string playerName = players[i].name;
                    foreach (char c in System.IO.Path.GetInvalidFileNameChars())
                    {
                        playerName = playerName.Replace(c, '_');
                    }

                    using (var w = new StreamWriter(Path.Combine(HistoryPath, playerName + ".csv")))
                    {
                        foreach (var l in playerHistory[i])
                        {
                            w.WriteLine(l);
                            w.Flush();
                        }
                    }
                }
            }
        }

        private void SimulateMatch(int winner, int loser)
        {
            // Will this match result in a change in scores?
            if (players[winner].rank > ranks[players[loser].rank].maxChallenge)
            {
                // No change required
                return;
            }

            // Change scores
            players[winner].score++;
            players[loser].score--;

            // Handle rank changes
            HandleRankChange(winner);
            HandleRankChange(loser);
        }

        private void HandleRankChange(int p)
        {
            if (players[p].score == ranks[players[p].rank].rankUpScore)
            {
                // Rank up
                if (players[p].rank < (int)RankNames.S)
                {
                    players[p].rank++;
                    players[p].score = 0;
                }
                else
                    players[p].score--;
            }

            if (players[p].score == ranks[players[p].rank].rankDownScore)
            {
                // Rank Down
                if (players[p].rank > (int)RankNames.UR)
                {
                    players[p].rank--;
                    players[p].score = 0;
                }
                else
                    players[p].score = 0;
            }
        }

        private int GetPlayerIndex(string name)
        {
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].name == name)
                    return i;
            }

            // Add new player
            players.Add(new Player(name));
            playerHistory.Add(new List<string>());
            return players.Count - 1;
        }

        private string InputPath;
        private string OutputPath;
        private string OutputPath2;
        private string HistoryPath;
        private List<Player> players;
        private List<Rank> ranks;

        private List<List<string>> playerHistory;

        class Player
        {
            public string name;
            public int rank;
            public int score;

            public Player(string Name)
            {
                name = Name;
                rank = (int)RankNames.UR;
                score = 0;
            }
        }

        struct Rank
        {
            public int index;
            public int rankUpScore;
            public int rankDownScore;
            public int minChallenge;
            public int maxChallenge;

            public Rank(RankNames Index, int RankUpScore, int RankDownScore, RankNames MinChallenge, RankNames MaxChallenge)
            {
                index = (int)Index;
                rankUpScore = RankUpScore;
                rankDownScore = RankDownScore;
                minChallenge = (int)MinChallenge;
                maxChallenge = (int)MaxChallenge;
            }
        }

        enum RankNames
        {
            UR,
            C,
            B,
            A,
            S
        }
    }
}
