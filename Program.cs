using System;

namespace testConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Program getrandomnumbers = new Program();
            var getAllharsh = getrandomnumbers.getRandom();
            Console.WriteLine($"The harshed numbers are {getAllharsh}" );
        }
      

        public int getRandom()
        {
           var  getrandom = new Random().Next(1000000, 90000089).GetHashCode();

            return getrandom;
        }

    }
}
