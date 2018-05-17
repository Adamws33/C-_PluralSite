using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tolowert
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] beatles = { "JOHN", "PAUL", "GEORGE", "RINGO" };
            List<string> TheBeatles = beatles.OfType<string>().ToList();
            TheBeatles.ForEach(Console.WriteLine);

            List<string> BeatlesList = new List<string>(beatles);
            BeatlesList.ForEach(Console.WriteLine);



            for (int i=0; i < beatles.Length; i++)
            {
                foreach (string beatle in beatles) {

                    beatles[i] = beatle.ToLower();

                    Console.WriteLine(beatles[i]);
                    i++;
                }
            }







        }
    }
}
