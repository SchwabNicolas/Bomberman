using System;
using System.Collections.Generic;
using System.Text;

namespace Bomberman_server
{
    public class Tile
    {
        public char id;
        public int[] coords;
        public int[] windowCoords { get; set; }
        public bool canBeBroken;

        public enum Block { Air, BorderWall, Brick }

        public Tile(int id, int[] coords)
        {
            switch(id)
            {
                case (int)Block.Air:

                    break;
                case (int)Block.BorderWall:

                    break;
                case (int)Block.Brick:

                    break;
            }
        }
    }
}
