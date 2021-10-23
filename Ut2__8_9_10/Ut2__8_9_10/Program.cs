using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ut2__8_9_10
{
    //Author : Raj Barot
    // Purpose : unit test2 -  8 9 10
    public abstract class Games
    {
        public string gameName;
        public string creator;
        public string genre;

        public virtual void games()
        {

        }
    }

    public interface online
    {
        void gamename();
    }

    public interface offline
    {
        void gamename();
    }

    public class Dota2 : Games, online
    {
        public bool gamestatus;

        public void gamename()
        {
            Console.WriteLine("The game name is Dota2");
        }

        public void gameinformation()
        {
            Console.WriteLine("this game is best online game");
        }
    }

    public class Mario : Games, offline
    {
        public string Website;

        public void gamename()
        {
            Console.WriteLine("The game name is Mario");
        }

        public void gameinformation()
        {
            Console.WriteLine("this game is offline game from 1990s");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dota2 d1 = new Dota2();
            Mario m1 = new Mario();
            MyMethod(d1);
            MyMethod(m1);


        }

        static void MyMethod(object obj)
        {
            try
            {
                ((Dota2)obj).gameinformation();  // Casting the object similar to the prvious question , where if the cast is successfull it calls 
                                                 // the gameinformation method from dota2 class else the mario class
            }
            catch
            {
                ((Mario)obj).gameinformation();
            }
        }
    }
}
