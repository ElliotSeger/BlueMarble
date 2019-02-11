using BlueMarble.Libraries;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueMarble.Objects.Creatures.Player
{
    class Player : Creature
    {
        public Player() :
            base(TextureLibrary.GetTexture("Player"), new Rectangle(100, 100, 100, 100))
        {

        }
    }
}
