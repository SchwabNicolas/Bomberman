using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman_server
{
    public class Character
    {
        public int id;
        public int[] coords;
        public int[] Velocity { get; set; }

        public Character(int id)
        {
            this.id = id;
            coords = new int[2];
            Velocity = new int[2];
            switch (id)
            {
                case 0:
                    coords[0] = 100;
                    coords[1] = 100;
                    break;
                case 1:
                    coords[0] = 100;
                    coords[1] = 100;
                    break;
                case 2:
                    coords[0] = 100;
                    coords[1] = 100;
                    break;
                case 3:
                    coords[0] = 100;
                    coords[1] = 100;
                    break;
            }

        }

        public void Move()
        {
            coords[0] += Velocity[0];
            coords[1] += Velocity[1];
        }
    }
}
