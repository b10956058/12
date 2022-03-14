using System;
using System;
            using System.Collections.Generic;
            using System.Text;
namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {





            int i, j;
            string[] name = new string[5] { "Jack", "Tom ", "Fred", "Mary", "Lucy" };
            int[] number = new int[5] { 1, 2, 3, 4, 5 };
            int[] comscore = { 80,77, 75, 88, 95 };
            int[] mathscore = { 69,86,74,79,81 };
            int[] englishscore = { 99, 77, 63, 84, 72 };        
            Console.WriteLine("座號 姓名 成績 ");

            while (true) { 
                Console.Write("輸入座號");
                var input = Console.ReadLine();
                int inputstudentno = int.Parse(input);
                int arryindex = Array.IndexOf(number, inputstudentno);
                if (arryindex > -1)
                {
                    Console.Write("姓名"+ name[arryindex]);
                    Console.Write("電腦概論" + comscore[arryindex]);
                    Console.Write("數學" + mathscore[arryindex]);
                    Console.Write("英文" + englishscore[arryindex]);
                    
                }
                else
                {
                    Console.Write("座號不在範圍內" );
                }
               
            }

           

        }


    }
}