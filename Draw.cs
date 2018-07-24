﻿using GTA;
using System.Drawing;

namespace GGOHud
{
    class Draw
    {
        /// <summary>
        /// Draws a text on the screen.
        /// </summary>
        /// <param name="Message">The message to draw.</param>
        /// <param name="Position">The position on the screen.</param>
        /// <param name="FontSize">The size of the font.</param>
        public static void Text(string Message, Point Position, float FontSize = 0.475f)
        {
            UIText ToDraw = new UIText(Message, Position, FontSize);
            ToDraw.Draw();
        }

        /// <summary>
        /// Draw a dummy text on the screen.
        /// A dummy text is a string that contains "-".
        /// </summary>
        /// <param name="Position">The position on the screen.</param>
        public static void Dummy(Point Position)
        {
            UIText ToDraw = new UIText("-", Position, 0.475f);
            ToDraw.Draw();
        }

        /// <summary>
        /// Draws a texture from a file on the disk.
        /// REMEMBER TO USE RELATIVE PATH's!
        /// </summary>
        /// <param name="Filename">The image file to draw.</param>
        /// <param name="Position">The position on the screen.</param>
        /// <param name="DrawSize">The size of the image being drawn.</param>
        public static void Texture(string Filename, Point Position, Size DrawSize)
        {
            UI.DrawTexture(Filename, 0, 0, 200, Position, DrawSize);
        }

        /// <summary>
        /// Draws a rectangle on the screen.
        /// </summary>
        /// <param name="Position">The position on the screen.</param>
        /// <param name="DrawSize">The size of the rectangle being created.</param>
        /// <param name="ShapeColor">The color of the rectangle.</param>
        public static void Rectangle(Point Position, Size DrawSize, Color ShapeColor)
        {
            UIRectangle ToDraw = new UIRectangle(Position, DrawSize, ShapeColor);
            ToDraw.Draw();
        }
    }
}