using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace Trolopoloy
{
    class PlayerPiece
    {
        public PlayerPiece(List<Texture2D> animationFrames)
        {
            this.animationFrames = animationFrames;
            this.startFrame = 0;
        }

        public PlayerPiece(List<Texture2D> animationFrames, int startFrame)
        {
            this.animationFrames = animationFrames;
            this.startFrame = startFrame;
        }

        private List<Texture2D> animationFrames;
        private int startFrame;
    }
}