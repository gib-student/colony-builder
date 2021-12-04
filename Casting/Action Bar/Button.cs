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
            if (Debug.debug)
            {
                Console.WriteLine($"Button action performed: {_buttonType}, {_resourceType}");
            }
            if (_buttonType == Constants.MINUS_BUTTON_TYPE)
            {
                switch (_resourceType)
                {
                    case Constants.FOOD_ACTIONBAR_TEXT:
                        if (_resources.GetResourceCount(Constants.FOOD_ACTIONBAR_TEXT) > 0)
                        {
                            _employedVillagers.DecrementEmployedOnFood();
                            _employedVillagers.IncrementUnemployed();
                            if (Debug.debug)
                            {
                                Console.WriteLine("\tEmployed food villagers decremented and unemployed incremented");
                            }
                        }
                        break;
                    case Constants.WOOD_ACTIONBAR_TEXT:
                        if (_resources.GetResourceCount(Constants.WOOD_ACTIONBAR_TEXT) > 0)
                        {
                            _employedVillagers.DecrementEmployedOnWood();
                            _employedVillagers.IncrementUnemployed();
                            if (Debug.debug)
                            {    
                                Console.WriteLine("\tEmployed wood villagers decremented and unemployed incremented");

                            }
                        }
                        break;
                    case Constants.STONE_ACTIONBAR_TEXT:
                        if (_resources.GetResourceCount(Constants.STONE_ACTIONBAR_TEXT) > 0)
                        {
                            _employedVillagers.DecrementEmployedOnStone();
                            _employedVillagers.IncrementUnemployed();
                            if (Debug.debug)
                            {
                                Console.WriteLine("\tEmployed stone villagers decremented and unemployed incremented");
   
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            else if (_buttonType == Constants.ADD_BUTTON_TYPE)
            {
                if (_employedVillagers.GetUnemployed() > 0)
                {
                    switch (_resourceType)
                    {
                        case Constants.FOOD_ACTIONBAR_TEXT:
                            _employedVillagers.IncrementEmployedOnFood();
                            _employedVillagers.DecrementUnemployed();
                            if (Debug.debug)
                            {
                                Console.WriteLine("\tFood incremented and unemployed decremented");
                            }
                            break;
                        case Constants.WOOD_ACTIONBAR_TEXT:
                            _employedVillagers.IncrementEmployedOnWood();
                            _employedVillagers.DecrementUnemployed();
                            if (Debug.debug)
                            {
                                Console.WriteLine("\tWood incremented and unemployed decremented");
                            }

                            break;
                        case Constants.STONE_ACTIONBAR_TEXT:
                            _employedVillagers.IncrementEmployedOnStone();
                            _employedVillagers.DecrementUnemployed();
                            if (Debug.debug)
                            {
                                Console.WriteLine("\tStoneincremented and unemployed decremented");   
                            }
                            break;
                        default:
                            break;
                    }
                }
            } 
        }

        public override void Update()
        {
               
        }
    }
}
