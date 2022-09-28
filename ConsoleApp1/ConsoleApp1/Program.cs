using System;

namespace HELOO
{
    class Vukhi
    {
      public  string name = "Ten vu khi";
       public Vukhi()
        {
            Console.WriteLine("Khoi tao");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Vukhi sungluc = new Vukhi();
            Console.WriteLine(sungluc.name);
        }
    }
}
