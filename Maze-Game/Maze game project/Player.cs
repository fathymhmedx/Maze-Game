using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_game_project
{
    internal class Player : IMazeObject  // CTRL + ( . ) on IMazeObject to implementation
    {
        public int X { get; set; }
        public int Y { get; set; }

        public char Icon { get => '@'; }
        public bool IsSoliid { get => true; }
    }
}

