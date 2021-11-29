using System;

namespace colony_builder.Casting
{
    public class GoldImg : Actor
    {
        public GoldImg()
        {
            SetPosition(new Point(Constants.GOLD_IMG_X, Constants.RESOURCES_IMG_Y));
            SetWidth(Constants.GOLD_IMG_WIDTH);
            SetHeight(Constants.GOLD_IMG_HEIGHT);
        }
    }
}
