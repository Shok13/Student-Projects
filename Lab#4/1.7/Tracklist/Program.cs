using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tracklist
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tracklist = new string[] { "1.Gentle Giant – Free Hand[6:15]",
                                                "2.Supertramp – Child Of Vision[07:27]",
                                                "3.Camel – Lawrence[10:46]",
                                                "4.Yes – Don’t Kill The Whale[3:55]",
                                                "5. 10CC – Notell Hotel[04:58]",
                                                "6.Nektar – King Of Twilight[4:16]",
                                                "7.The Flower Kings – Monsters & Men[21:19]",
                                                "8.Focus – Le Clochard[1:59]",
                                                "9.Pendragon – Fallen Dream And Angel[5:23]",
                                                "10.Kaipa – Remains Of The Day(08:02)" };


            Regex rx = new Regex(@"\d+:\d{2}");
            string[] duration_text = new string[10];
            int[] duration = new int[10];
            for (int i = 0; i < tracklist.Length; i++)
            {
                duration_text[i] = rx.Match(tracklist[i]).Value;
            }


            int sum = 0;
            for (int i = 0; i < duration_text.Length; i++)
            {

                int position_separator = duration_text[i].IndexOf(':');
                if (position_separator == 1)
                {
                    duration[i] = (Convert.ToInt32(duration_text[i][0]) - 48) * 60
                        + (Convert.ToInt32(duration_text[i][2]) - 48) * 10 + Convert.ToInt32(duration_text[i][3]) - 48;
                }
                if (position_separator == 2)
                {
                    duration[i] = (Convert.ToInt32(duration_text[i][0]) - 48) * 600 + (Convert.ToInt32(duration_text[i][1]) - 48) * 60
                        + (Convert.ToInt32(duration_text[i][3] - 48) * 10 + Convert.ToInt32(duration_text[i][4]) - 48);
                }
                sum += duration[i];
            }


            int shortest_song = 0, longest_song = 0;
            int min = duration[0], max = duration[0];
            for (int i = 0; i < duration.Length; i++)
            {
                
                if (duration[i] > max)
                {
                    max = duration[i];
                    longest_song = i;
                }
                if (duration[i] < min)
                {
                    min = duration[i];
                    shortest_song = i;
                }
            }


            int min_difference = Int32.MaxValue, first_min_track = 0, second_min_track = 0;
            for (int i = 0; i < duration.Length; i++)
            {
                for (int j = 0; j < duration.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (Math.Abs(duration[i] - duration[j]) < min_difference)
                    {
                        first_min_track = i;
                        second_min_track = j;
                        min_difference = Math.Abs(duration[i] - duration[j]);
                    }
                }
            }

            Console.WriteLine($"The sum of the duration of the tracks = {sum}");
            Console.WriteLine($"The shortest song is {tracklist[shortest_song]}");
            Console.WriteLine($"The longest song is {tracklist[longest_song]}");
            Console.WriteLine($"A couple of songs with a minimal difference is " +
                $"{tracklist[first_min_track]} and {tracklist[second_min_track]}");
        }
    }
}
