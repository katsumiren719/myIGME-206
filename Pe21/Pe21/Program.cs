using System;


namespace Pe21
{
    class Program
    {
        // Author : Raj Barot
        // Purpose : To perform  Pe21, implement adjancecy graph and matrix as shown in the diagram
        static int[,] AdjacencyGraph = new int[,]
        {
           // Numbers denote the distance between leters, and -1 denotes unreachable, since we cannot write infinite in INT array  
           { 0, 2, -1, -1, -1, -1, -1, -1},
           {-1, -1, 2, 3, -1, -1, -1, -1 },
           {-1, 2, -1, -1, -1, -1, -1, 20 },
           {-1, 3, 5, -1, 2, 4, -1, -1 },
           {-1, -1, -1, -1, -1, 3, -1, -1 },
           {-1, -1, -1, -1, -1, -1, 1, -1 },
           {-1, -1, -1, -1, 0, -1, -1, 2 },
           {-1, -1, -1, -1, -1, -1, -1,-1 }
        };

        static char[,] AdjacencyList = new char[,]
        {
               
            {'A','A',' ',' ' },
            {' ','D','C',' ' },
            {'B',' ','H',' ' },
            {'E','F','C','B' },
            {' ',' ','F',' ' },
            {' ','G',' ',' ' },
            {'E',' ','H',' ' },
            {' ',' ',' ',' ' }
        };
    }
}



