using System;

namespace StructToClass
{
    // Author : Raj Barot
    // Purpose : Unit test 2 Q14
       class Friend // Changing the struct to class
        {
        public string name;
        public string greeting;
        public DateTime birthdate;
        public string address;
        }


    class Program
    {

        static void Main(string[] args)
        {
            Friend friend = new Friend();  // Initializing new objects of the class
            Friend enemy = new Friend();   // Initializing new objects of the class

            // create my friend Charlie Sheen
            friend.name = "Charlie Sheen";
            friend.greeting = "Dear Charlie";
            friend.birthdate = DateTime.Parse("1967-12-25");
            friend.address = "123 Any Street, NY NY 12202";

            // now he has become my enemy
            enemy = friend;

            // set the enemy greeting and address without changing the friend variable
            enemy.greeting = "Sorry Charlie";
            enemy.address = "Return to sender.  Address unknown.";

            Console.WriteLine($"friend.greeting => enemy.greeting: {friend.greeting} => {enemy.greeting}");
            Console.WriteLine($"friend.address => enemy.address: {friend.address} => {enemy.address}");
        }
    }
}
