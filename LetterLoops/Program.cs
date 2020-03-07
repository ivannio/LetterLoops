using System;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey bud. Go ahead and type something in and press enter. I'm gonna take it and do some stuff with it and spit it back out at ya.");

            var input = Console.ReadLine();

            var first = char.ToUpper(input[0]) + "-";

            var second = "";

            var concat = "";            

            for (var i = 1; i < input.Length; i++) 
            {
                var section = new String(char.ToLower(input[i]), i + 1) + "-";
                var upperCasedFirst = char.ToUpper(section[0]) + section.Substring(1);
                concat += upperCasedFirst;                
            }
            second = concat.Remove(concat.Length - 1, 1);
            Console.WriteLine(first + second);
            Console.ReadLine();
        }
    }
}
