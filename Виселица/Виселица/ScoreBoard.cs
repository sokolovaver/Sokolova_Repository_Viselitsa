using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Виселица
{
    class ScoreBoard
    {
        public static string me { get; set; }
       
        public static Dictionary<string, int> get()
        {
            return File.ReadAllLines("Рекорды.txt").Where(l => !string.IsNullOrWhiteSpace(l)).ToDictionary(name => name.Substring(0, name.IndexOf("|")), name => int.Parse(name.Substring(name.IndexOf("|")+1)));
        }
        public static void win()
        {
            Dictionary<string, int> score = get();
            if (score.ContainsKey(me)) score[me] += 1;
            else score.Add(me, 1);

            string[] arr = score.Select(z => (z.Key + "|" + z.Value)).ToArray();
            File.WriteAllLines("Рекорды.txt", arr);
        }
       
    }
}
