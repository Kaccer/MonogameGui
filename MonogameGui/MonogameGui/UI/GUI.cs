﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Client_PC.UI
{
    class GUI
    {
        public SpriteFont smallFont;
        public SpriteFont smediumFont;
        public SpriteFont mediumFont;
        public SpriteFont hugeFont;
        public SpriteFont bigFont;
        public GraphicsDevice GraphicsDevice;

        public GUI(ContentManager content, GraphicsDevice graphicsDevice)
        {
            GraphicsDevice = graphicsDevice;
            LoadContent(content);
        }
        public void LoadContent(ContentManager content)
        {
            smallFont = content.Load<SpriteFont>("fonts/small");
            smediumFont = content.Load<SpriteFont>("fonts/smedium");
            mediumFont = content.Load<SpriteFont>("fonts/medium");
            hugeFont = content.Load<SpriteFont>("fonts/huge");
            bigFont = content.Load<SpriteFont>("fonts/big");
        }
    }
}
