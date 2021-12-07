using System;

namespace colony_builder.Casting
{
    public class Button : Actor
    {
        string _buttonType;
        string _resourceType;
        Resources _resources;
        EmployedVillagers _employedVillagers;

        public Button(Point position, string buttonType, string resourceType, 
            EmployedVillagers employedVillagers, Resources resources)
        {
            // TODO
            // SetImage(Constants.);
            SetPosition(position);
            _buttonType = buttonType;
            _resourceType = resourceType;
            _resources = resources;
            _employedVillagers = employedVillagers;
            SetWidth(Constants.BUTTON_WIDTH);
            SetHeight(Constants.BUTTON_HEIGHT);
            SetHasActionIfPressed(true);
        }

        public override void DoAction()
        {
            if (_buttonType == Constants.MINUS_BUTTON_TYPE)
            {
                switch (_resourceType)
                {
                    case Constants.FOOD_ACTIONBAR_TEXT:
                        _employedVillagers.MinusEmployedOnFoodButton();
                        break;

                    case Constants.WOOD_ACTIONBAR_TEXT:
                        _employedVillagers.MinusEmployedOnWoodButton();

                        break;
                    case Constants.STONE_ACTIONBAR_TEXT:
                        _employedVillagers.MinusEmployedOnStoneButton();

                        break;
                    default:
                        break;
                }
            }
            else if (_buttonType == Constants.ADD_BUTTON_TYPE)
            {
                switch (_resourceType)
                {
                    case Constants.FOOD_ACTIONBAR_TEXT:
                        _employedVillagers.AddEmployedOnFoodButton();
                        break;

                    case Constants.WOOD_ACTIONBAR_TEXT:
                        _employedVillagers.AddEmployedOnWoodButton();
                        break;
                        
                    case Constants.STONE_ACTIONBAR_TEXT:
                        _employedVillagers.AddEmployedOnStoneButton();

                        break;
                    default:
                        break;
                }
            } 
        }

        public override void Update()
        {
               
        }
    }
}
