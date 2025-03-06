namespace Maze_game_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Maze maze = new Maze(40, 20); // Construct new maze 

            while (true)
            {
                maze.DrawMaze();
                maze.MovePlayer();
            }
            
        }
    }
}
