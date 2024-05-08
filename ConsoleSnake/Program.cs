using model;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Case[][] map = game.Map;


            for (int i = 0; i < map.Length; i++)
            {
                string s = "";
                for (int j = 0; j < map[i].Length; j++)
                {
                    string objetOrNot = " 0 ";
                    if (map[i][j].Item != null)
                    {
                        objetOrNot  = " 1 ";
                    }
                    s += objetOrNot;
                }
                Console.WriteLine(s);
            }
        }
    }
}