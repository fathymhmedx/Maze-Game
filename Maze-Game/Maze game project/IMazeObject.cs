using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_game_project
{
    public interface IMazeObject
    {
        char Icon { get; } // The Chape of the maze object
        bool IsSoliid { get; } //Movement block
    }
}
