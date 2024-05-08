using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Game
    {
        private Case[][] map;
        public Case[][] Map { get => map; set => map = value; }
        private const int SIZE = 15; // L x H
        private List<IObject> snake;

        public Game()
        {
            int x = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(SIZE / 2)));
            this.InitMap();
            this.InitSnake(x, x);
            this.SendSnakeToMap();

        }

        /// <summary>
        /// Initie la map
        /// </summary>
        private void InitMap()
        {
            this.map = new Case[SIZE][];
            // Colonne
            for (int i = 0; i < SIZE; i++)
            {
                this.map[i] = new Case[SIZE];
                // Ligne
                for (int j = 0; j < SIZE; j++)
                {
                    this.map[i][j] = new Case();
                }
            }
        }

        /// <summary>
        /// Initie le serpent
        /// </summary>
        private void InitSnake(int x, int y)
        {
            // On initie le snake
            int startLenght = 3;
            this.snake = new List<IObject>();
            for (int i = 0; i < startLenght; i++)
            {
                Coordinate co = new Coordinate(y + i, x); // Créer le serpent selon les coordonées de base donnée
                BodySnake bs = new BodySnake(co);
                this.snake.Add(bs);
            }
        }

        /// <summary>
        /// on place le serpent sur la map
        /// </summary>
        private void SendSnakeToMap()
        {
            foreach(BodySnake obj in this.snake)
            {
                Coordinate co = obj.Coordonnee;
                this.map[co.Y][co.X].Item = obj;
            }
        }
    }
}
