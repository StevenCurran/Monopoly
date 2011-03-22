using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace Trolopoloy
{
    abstract class Square
    {
        protected Texture2D image;
        protected String name;
        private int id;

        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        public abstract void PerformAction(Player inhabitant);
    }
}
