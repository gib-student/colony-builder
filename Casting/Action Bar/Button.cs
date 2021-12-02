using System;

namespace colony_builder.Casting
{
    public class Button : Actor
    {
        string _buttonType;
        string _resource;

        public Button(Point position, string buttonType, string resource)
        {
            // TODO
            // SetImage(Constants.);
            SetPosition(position);
            _buttonType = buttonType;
            _resource = resource;
            SetWidth(Constants.BUTTON_WIDTH);
            SetHeight(Constants.BUTTON_HEIGHT);
            SetHasActionIfPressed(Constants.AVAILABLE_TO_BUILD);
        }

        public override void DoAction()
        {
            if (_buttonType == Constants.MINUS_BUTTON_TYPE)
            {
                
            }
            else if (_buttonType == Constants.ADD_BUTTON_TYPE)
            {

            } 
        }
    }
}
