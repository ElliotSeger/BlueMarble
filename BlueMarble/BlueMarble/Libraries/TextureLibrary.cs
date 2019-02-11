using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueMarble.Libraries
{
    static class TextureLibrary
    {
        static Dictionary<string, Texture2D> myTextures;

        public static Texture2D GetTexture(string aKey)
        {
            return myTextures[aKey];
        }

        public static void LoadTextures(ContentManager someContent)
        {
            myTextures = new Dictionary<string, Texture2D>
            {

            };
        }
    }
}
