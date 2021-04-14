using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = MyList<string>();
            isimler.Add("Sezgin");
            
            Console.WriteLine("Hello World!");
        }
    }
}
