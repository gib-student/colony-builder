using System;
using Raylib_cs;

namespace colony_builder.Services
{
    public class InputService
    {
        public InputService()
        {
           
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
