namespace model
{
    public class Snake
    {
        private List<IObject> snakeBody; // Le corp du serpent
        private int startLenght = 3;


        /// <summary>
        /// Créer le serpent
        /// </summary>
        /// <param name="spawnCoordinate"> Coordonnée de spawn </param>
        public Snake(int y, int x)
        {
            snakeBody = new List<IObject>();
            for (int i = 0; i < startLenght; i++)
            {
                Coordinate co = new Coordinate(y + i, x); // Créer le serpent selon les coordonées de base donnée
                snakeBody.Add(new BodySnake(co));
            }
        }
    }
}
