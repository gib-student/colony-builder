using System;

namespace colony_builder.Casting
{
    public class StoneImg : Actor
    {
        public StoneImg()
        {
            SetPosition(new Point(Constants.STONE_IMG_X, Constants.RESOURCES_IMG_Y));
            SetWidth(Constants.STONE_IMG_WIDTH);
            SetHeight(Constants.STONE_IMG_HEIGHT);
        }
    }
}
