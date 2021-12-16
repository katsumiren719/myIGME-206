using System;

namespace Q2
{

    // the program is just an adjacency graph
    class Program
    {
        // Author : Raj Barot
        static void Main(string[] args)
        {

        }   
     


         private static (int Cost, int Direction)[,] mGraph = new (int, int)[,]
        {
                //A B C D E F G H
                /*A*/{(0,0), (1,1), (5,2), (-1,-1), (-1,-1), (-1,-1), (-1,-1), (-1,-1) },
                /*B*/{(-1,-1), (-1,-1), (-1,-1), (1,2), (-1,-1),(7,2),(-1,-1),(-1,-1) },
                /*C*/{(-1,-1), (-1,-1), (-1,-1), (0,0), (2,3), (-1,-1), (-1,-1), (-1,-1) },
                /*D*/{(-1,-1), (1,1), (0,2), (-1,-1), (-1,-1), (-1,-1), (-1,-1), (-1,-1)  },
                /*E*/{(-1,-1), (-1,-1), (2,2), (-1,-1), (-1,-1), (-1,-1), (2,0), (-1,-1) },
                /*F*/{(-1,-1), (-1,-1), (-1,-1), (-1,-1), (-1,-1), (-1,-1), (-1,-1), (4,3) },
                /*G*/{(-1,-1), (-1,-1), (-1,-1), (-1,-1), (2,3), (1,2), (-1,-1), (-1,-1)  },
                /*H*/{(-1,-1), (-1,-1), (-1,-1), (-1,-1), (-1,-1), (-1,-1), (-1,-1), (-1,-1) }
        };

        //list
        private static (int Room, int Cost, int State)[][] lGraph = new (int, int, int)[][]
        {
                /*A*/new (int,int,int)[] {(1,1,1),(2,5,2) },
                /*B*/new (int,int,int)[] {(3,1,2),(5,7,2) },
                /*C*/new (int,int,int)[] {(3,0,0),(4,2,3) },
                /*D*/new (int,int,int)[] {(1,1,1),(2,0,2) },
                /*E*/new (int,int,int)[] {(2,2,2),(6,2,0) },
                /*F*/new (int,int,int)[] {(7,4,3) },
                /*G*/new (int,int,int)[] {(4,2,3),(5,1,2) },
                /*H*/new (int,int,int)[] { }
        };

       
        private static string[] rooms = { "A", "B", "C", "D", "E", "F", "G", "H" };
    }
}

    

