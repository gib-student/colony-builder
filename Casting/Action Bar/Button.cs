using System;

namespace colony_builder.Casting
{
    public class Button : Actor
    {
        public Button(Point position)
        {
            // TODO
            // SetImage(Constants.);
            SetPosition(position);
            SetWidth(Constants.BUTTON_WIDTH);
            SetHeight(Constants.BUTTON_HEIGHT);
            SetHasActionIfPressed(Constants.AVAILABLE_TO_BUILD);
        }
    }
}
