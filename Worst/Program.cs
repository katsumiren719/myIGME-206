using System;

namespace Worst
{
    using When = Episode;
    using Episode = Worst.Episode.Ever;                     /// <-------------  2.
    class Meme
    {
        public void printing()
        {
            Console.WriteLine("meme");
        }
    }
    namespace Episode
    {
        using Ever = Ever;
        //Ever e1 = new Ever();
        //Ever.printing();
          
        class Ever
        {
            public void printing()
            {
                Console.WriteLine("Ever");
            }
        }
       
    }
   
           
    

}
    class Program
    {
        static void Main(string[] args)
        {
        Worst.Episode.Ever e1 = new Worst.Episode.Ever();  /// <-------------  1.
        e1.printing();
                 
        }
    }


