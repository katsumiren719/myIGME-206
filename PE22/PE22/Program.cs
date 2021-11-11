using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Web;
using System.Net;
using System.IO;

namespace Dont_Die_Part_2
{
    class Trivia
    {
        public int response_code;
        public List<TriviaResult> results;
    }

    class TriviaResult
    {
        public string category;
        public string type;
        public string difficulty;
        public string question;
        public string correct_answer;
        public List<string> incorrect_answers;
    }

    class Program
    {
        // neighboring points can be determined by if (maxtrixGraph[x, y].Item1 == x)
        // relative direction is Item1 in the tuple
        // cost is Item2 in the tuple

        private static bool bWin = false;
        private static bool bRight = false;


        static (string, int)[,] matrixGraph = new (string, int)[,]
        {
                 //    A           B           C           D           E           F           G           H
          /*A*/  {("NE", 0),  ("S", 2),   (null, -1), (null, -1), (null, -1), (null, -1), (null, -1), (null, -1)},
          /*B*/  {(null, -1), (null, -1), ("S", 2),   ("E", 3),   (null, -1), (null, -1), (null, -1), (null, -1)},
          /*C*/  {(null, -1), ("N", 2),   (null, -1), (null, -1), (null, -1), (null, -1), (null, -1), ("S", 20)},
          /*D*/  {(null, -1), ("W", 3),   ("S", 5),   (null, -1), ("N", 2),   ("E", 4),   (null, -1), (null, -1)},
          /*E*/  {(null, -1), (null, -1), (null, -1), (null, -1), (null, -1), ("S", 3),   (null, -1), (null, -1)},
          /*F*/  {(null, -1), (null, -1), (null, -1), (null, -1), (null, -1), (null, -1), ("E", 1),   (null, -1)},
          /*G*/  {(null, -1), (null, -1), (null, -1), (null, -1), ("N", 0),   (null, -1), (null, -1), ("S", 2)},
          /*H*/  {(null, -1), (null, -1), (null, -1), (null, -1), (null, -1), (null, -1), (null, -1), (null, -1)}
        };

        //Item1 is the index of the neighbor, Item2 is the direction and Item3 is the cost
        static (int, string, int)[][] listGraph = new (int, string, int)[][]
        {
            /*A*/ new (int, string, int)[] {(0, "N", 0), (0, "E", 0), (1, "S", 2)},
            /*B*/ new (int, string, int)[] {(2, "S", 2), (3, "E", 3)},
            new (int, string, int)[] {(1, "N", 2), (7, "S", 20)},
            new (int, string, int)[] {(1, "W", 3), (2, "S", 5), (4, "N", 2), (5, "E", 4)},
            new (int, string, int)[] {(5, "S", 3)},
            new (int, string, int)[] {(6, "E", 1)},
            new (int, string, int)[] {(4, "N", 0)},
            null
        };

        // parallel arrays to store the weight, direction and room indexes
        // weight graph
        static int[][] wGraph = new int[][]
        {
            /*A*/ new int[] {0, 0, 2}
            /*B new (int, string, int)[] {(2, "S", 2), (3, "E", 3)},
            new (int, string, int)[] {(1, "N", 2), (7, "S", 20)},
            new (int, string, int)[] {(1, "W", 3), (2, "S", 5), (4, "N", 2), (5, "E", 4)},
            new (int, string, int)[] {(5, "S", 3)},
            new (int, string, int)[] {(6, "E", 1)},
            new (int, string, int)[] {(4, "N", 0)},
            null  */
        };

        // room graphs: contains the indexes of the connected rooms
        static int[][] iGraph = new int[][]
        {
            /*A*/ new int[] {0, 0, 1}
            /*B new (int, string, int)[] {(2, "S", 2), (3, "E", 3)},
            new (int, string, int)[] {(1, "N", 2), (7, "S", 20)},
            new (int, string, int)[] {(1, "W", 3), (2, "S", 5), (4, "N", 2), (5, "E", 4)},
            new (int, string, int)[] {(5, "S", 3)},
            new (int, string, int)[] {(6, "E", 1)},
            new (int, string, int)[] {(4, "N", 0)},
            null  */
        };


        static void Main(string[] args)
        {
            int nRoom = 0;

            int playerHp = 1;

            while (nRoom != 7)
            {
                // if not room A and not room H then randomly reduce their HP such that they don't die

                // display a desc of the room
                // Console.Writeline(desc[nRoom]);

                // display any exits from the room
                (int, string, int)[] thisRoomsNeighbors = listGraph[nRoom];

                int nExits = 0;

                foreach ((int, string, int) neighbor in thisRoomsNeighbors)
                {
                    if (playerHp > neighbor.Item3)
                    {
                        Console.WriteLine("There is an exit to the " + neighbor.Item2 + " which costs " + neighbor.Item3 + "HP");
                        ++nExits;
                    }
                }

                // display the hp
                Console.WriteLine($"You have {playerHp} HP");

                // ask the player if they want wager (w) for more hp or leave (l) the room only if there are nExits > 0
                string sResponse;

                sResponse = Console.ReadLine();

                if (sResponse.ToLower() == "l" /* leaving room */ )
                {
                    bool bValid = false;
                    string sDirection;

                    while (!bValid)
                    {
                        sDirection = Console.ReadLine();

                        for (int nCntr = 0; nCntr < 8; ++nCntr)
                        {
                            if (matrixGraph[nRoom, nCntr].Item1.Contains(sDirection) && playerHp > matrixGraph[nRoom, nCntr].Item2)
                            {
                                nRoom = nCntr;
                                playerHp -= matrixGraph[nRoom, nCntr].Item2;
                                bValid = true;
                                break;
                            }
                        }

                        if (!bValid)

                        {
                            Console.WriteLine("That isn't a valid direction");
                        }
                    }
                }
                else
                {
                    // trivia question
                    // fetch api
                    // 15 second limit to answer
                    // multiple choice 1-4

                    // ask player how much HP to wager (limited to playerHp)

                    string url = null;
                    string s = null;

                    HttpWebRequest request;
                    HttpWebResponse response;
                    StreamReader reader;

                    url = "https://opentdb.com/api.php?amount=1&type=multiple";

                    request = (HttpWebRequest)WebRequest.Create(url);
                    response = (HttpWebResponse)request.GetResponse();
                    reader = new StreamReader(response.GetResponseStream());
                    s = reader.ReadToEnd();
                    reader.Close();

                    Trivia trivia = JsonConvert.DeserializeObject<Trivia>(s);

                    trivia.results[0].question = HttpUtility.HtmlDecode(trivia.results[0].question);
                    trivia.results[0].correct_answer = HttpUtility.HtmlDecode(trivia.results[0].correct_answer);
                    for (int i = 0; i < trivia.results[0].incorrect_answers.Count; ++i)
                    {
                        trivia.results[0].incorrect_answers[i] = HttpUtility.HtmlDecode(trivia.results[0].incorrect_answers[i]);
                    }

                    // put the answers in random order
                    // prefix each answer with number 1-4 so the player only need to type the number
                    // 15 second timer


                }
            }
        }
    }
}