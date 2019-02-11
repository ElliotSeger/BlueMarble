using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueMarble.Objects
{
    class GameObject
    {
        protected Texture2D AccessTexture { get; set; }
        protected Rectangle AccessRectangle { get; set; }
        protected float AccessRotation { get; set; }

        public GameObject(Texture2D aTexture, Rectangle aRectangle, float aRotation = 0)
        {
            AccessTexture = aTexture;
            AccessRectangle = aRectangle;
            AccessRotation = aRotation;
        }

        public virtual void Update(GameTime someTime) { }

        public virtual void Draw(GameTime someTime, SpriteBatch aSpriteBatch)
        {
            aSpriteBatch.Draw(AccessTexture, AccessRectangle, null, Color.White, AccessRotation, AccessTexture.Bounds.Size.ToVector2() * 0.5f, SpriteEffects.None, 0f);
        }
    }
}
