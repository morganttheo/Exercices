using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Combien de notes allez-vous saisir ? = ");
            int nbnotes = int.Parse(Console.ReadLine());
            int min = 20, max = 0;
            for (int k=1; k<=nbnotes; k++)

            {
                Console.WriteLine("Note n° " + k + " = ");
                int note = int.Parse(Console.ReadLine());    
                max = Math.Max(max, note);
                min = Math.Min(min, note);
            }
            Console.WriteLine("max =" + max);
            Console.WriteLine("min =" + min);
            Console.ReadLine();







        }
    }
}
