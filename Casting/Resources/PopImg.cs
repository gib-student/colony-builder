using System;

namespace colony_builder.Casting
{
    public class PopImg : Actor
    {
        public PopImg()
        {
            SetPosition(new Point(Constants.POP_IMG_X, Constants.POP_IMG_Y));
            SetImage(Constants.POP_IMG_FILEPATH);
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
