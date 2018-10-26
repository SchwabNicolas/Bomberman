using Bomberman_server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman_server
{
    public class Game
    {
        Character[] characters;
        Map map;

        public Game()
        {
            characters = new Character[4];
            for (int i = 0; i < characters.Length; i++)
            {
                characters[i] = new Character(i);
            }


        }
    }
}
