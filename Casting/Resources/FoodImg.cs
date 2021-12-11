using System;

namespace colony_builder.Casting
{
    public class FoodImg : Actor
    {
        public FoodImg()
        {
            SetPosition(new Point(Constants.FOOD_IMG_X, Constants.RESOURCES_IMG_Y));
            SetImage(Constants.FOOD_IMG_FILEPATH);
            SetWidth(Constants.FOOD_IMG_WIDTH);
            SetHeight(Constants.FOOD_IMG_HEIGHT);
        }

        public override void DoAction()
        {
            
        }

        public override void Update()
        {
            
        }
    }
}
