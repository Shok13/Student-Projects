using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WorldCupPlayoffs
{
    class Program
    {
        public struct MatchData
        {
            string firstTeam;
            int firstGoals;
            string secondTeam;
            int secondGoals;
            public MatchData(string _1stTeam, string _2ndTeam, int goals1, int goals2)
            {
                firstTeam = _1stTeam;
                firstGoals = goals1;
                secondTeam = _2ndTeam;
                secondGoals = goals2;
            }
            public void ShowInfo()
            {
                Console.WriteLine($"{firstTeam} - {secondTeam}: {firstGoals} - {secondGoals}");
            }
            public static MatchData PlayGame(MatchData firstMatch, MatchData secondMatch)
            {
                string firstWinner = null;
                string secondWinner = null;
                firstWinner = firstMatch.firstGoals > firstMatch.secondGoals ? firstMatch.firstTeam : firstMatch.secondTeam;
                secondWinner = secondMatch.firstGoals > secondMatch.secondGoals ? secondMatch.firstTeam : secondMatch.secondTeam;
                var goals1 = new Random().Next(0, 7);
                var goals2 = new Random().Next(0, 7);
                while (goals1 == goals2)
                {
                    goals2 = new Random().Next(0, 7);
                }
                return new MatchData(firstWinner, secondWinner, goals1, goals2);
            }
        }
        public static void PlayOffGridShow(BinaryTreeNode<MatchData> node, string offset)
        {
            if (node != null)
            { 
                Console.Write(offset);
                node.data.ShowInfo();
                offset += "   ";
                PlayOffGridShow(node.left, offset);
                PlayOffGridShow(node.right, offset);
            }
        }
        static void Main(string[] args)
        {
            var tournamentGrid = new BinaryTree<MatchData>();
            var emptyData = new MatchData("", "", 0, 0);
            var nodes = new BinaryTreeNode<MatchData>[15];

            for (int parent = 0, children = 3; parent < nodes.Length / 2; parent++)
            {
                if (parent == 0)
                {
                    nodes[0] = tournamentGrid.AddRoot(emptyData);
                    nodes[1] = tournamentGrid.AddLeft(nodes[0], emptyData);
                    nodes[2] = tournamentGrid.AddRight(nodes[0], emptyData);
                }
                else
                {
                    nodes[children++] = tournamentGrid.AddLeft(nodes[parent], emptyData);
                    nodes[children++] = tournamentGrid.AddRight(nodes[parent], emptyData);
                }
            }

            var rnd = new Random();
            var matchDataSet = new MatchData[8];
            string[] countries = { "COL", "URU", "BRA", "CHI", "FRA", "NIG", "GER", "ALG", "NED", "MEX", "CRC", "GRE", "ARG", "SWI", "BEL", "USA" };
            var cnt = 0;
            for (int i = 0; i < matchDataSet.Length; i++)
            {
                var goals1 = rnd.Next(0, 7);
                var goals2 = rnd.Next(0, 7);
                while (goals1 == goals2)
                {
                    goals2 = rnd.Next(0, 7);
                }
                matchDataSet[i] = new MatchData(countries[cnt++], countries[cnt++], goals1, goals2);
            }
            for (int i = 14; i >= 7; i--)
            {
                nodes[i].data = matchDataSet[i - 7];
            }
            for(int i = 6; i>= 0; i--)
            {
                var team = i * 2 + 2;
                nodes[i].data = MatchData.PlayGame(nodes[team].data,nodes[team-1].data);
            }
            var root = nodes[0];
            PlayOffGridShow(root, "");
        }
    }
}
