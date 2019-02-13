using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Typetestconsolegame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> inputList = new List<char>();
            List<char> alphabet = new List<char>();

            alphabet.Add('a');
            alphabet.Add('b');
            alphabet.Add('c');
            alphabet.Add('d');
            alphabet.Add('e');
            alphabet.Add('f');
            alphabet.Add('g');
            alphabet.Add('h');
            alphabet.Add('i');
            alphabet.Add('j');
            alphabet.Add('k');
            alphabet.Add('l');
            alphabet.Add('m');
            alphabet.Add('n');
            alphabet.Add('o');
            alphabet.Add('p');
            alphabet.Add('q');
            alphabet.Add('r');
            alphabet.Add('s');
            alphabet.Add('t');
            alphabet.Add('u');
            alphabet.Add('v');
            alphabet.Add('w');
            alphabet.Add('x');
            alphabet.Add('y');
            alphabet.Add('z');

            //while (true)
            //{

            //    char input = (Console.ReadKey().KeyChar);
            //    inputList.Add(input);
            //    Console.WriteLine(input);

            //}


            while (true)
            {
                char input = (Console.ReadKey().KeyChar);
                if (input == alphabet[0])
                {
                    alphabet.RemoveAt(0);
                    Console.WriteLine(alphabet.Count);
                }
                if(alphabet.Count <= 0)
                {
                    break;
                    Console.WriteLine("Alphabet done");
                }

                Console.WriteLine(alphabet.Count);
            }

            
            //int enterTime = Int32.Parse(Console.ReadLine());

            //// Create new timer
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //for (int i = 0; i < x * 500; i++)
            //{
            //    Thread.Sleep(1);
            //}
            //stopwatch.Stop();
            //Console.WriteLine("Out of Time", stopwatch.Elapsed);
            //Console.Read();

        }


        
    }
}



//==PSEUDOCODE==

//list<char> inputList;
//input time(int)
//random [[[for strict]]]
//start time: 0 and start stopwatch going
//everlasting loop

//read one key (Console.Read())
//add character to inputList<char>  [[[check last character; ensure this character matches next expected character]]]
//look at time
//check : is current time still less than inputTime? 
//no ==> break; out of the loop
//Console.WriteLine(inputList.length) NUMBER OF CHARACTERS INPUT IN TIME GIVEN

//1. Everlasting loop, input individual characters
//2. List and add characters to list
//3. Add time. 





//==TASK==
//input a number = time in seconds. 2 modes 

//1st mode - ordered mode, letters must be typed in order of alphabet.

//2nd mode - random mode, any letters, any order.

//output - number of characters, array of characters typed.