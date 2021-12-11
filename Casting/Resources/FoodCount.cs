using System;

namespace colony_builder.Casting
{
    public class FoodCount : Actor
    {
        Resources _resources;
        int _foodCount;

        public FoodCount(Resources resources)
        {
            _resources = resources;
            SetPosition(new Point(Constants.FOOD_COUNT_TEXT_X, 
                Constants.RESOURCES_COUNT_TEXT_Y));
            Update();
        }

        public override void DoAction()
        {
            
        }

        public override void Update()
        {
            _foodCount = 
                (int)_resources.GetResourceCount(Constants.FOOD_ACTIONBAR_TEXT);
            SetText(_foodCount.ToString());
        }
    }
}
