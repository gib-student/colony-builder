using System;
using Raylib_cs;
using colony_builder.Casting;

namespace colony_builder.Services
{
    public class InputService
    {
        public InputService()
        {
           
        }

        public bool IsLeftMouseButtonPressed()
        {
            if (Debug.debug && Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
            {
                Console.WriteLine("InputService: Left Mouse click detected");
            }
            return Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON);
        }
        
        public bool IsRightMouseButtonPressed()
        {
            if (Debug.debug && Raylib.IsMouseButtonPressed(MouseButton.MOUSE_RIGHT_BUTTON))
            {
                Console.WriteLine("InputService: Right Mouse click detected");
            }
            return Raylib.IsMouseButtonPressed(MouseButton.MOUSE_RIGHT_BUTTON);
        }

        public int GetMouseX()
        {
            return Raylib.GetMouseX();
        }

        public int GetMouseY()
        {
            return Raylib.GetMouseY();
        }

        /// <summary>
        /// Gets the Mouse X and Y position
        /// </summary>
        public Point GetMousePosition()
        {
            int x = GetMouseX();
            int y = GetMouseY();

            return new Point(x, y);
        }

        /// <summary>
        /// Returns true if the user has attempted to close the window.
        /// </summary>
        /// <returns></returns>
        public bool IsWindowClosing()
        {
            return Raylib.WindowShouldClose();
        }
    }
}
