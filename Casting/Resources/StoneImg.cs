using System;

namespace colony_builder.Casting
{
    public class StoneImg : Actor
    {
        public StoneImg()
        {
            SetPosition(new Point(Constants.STONE_IMG_X, Constants.RESOURCES_IMG_Y));
            // TODO
            // SetImage(Constants.);
            SetWidth(Constants.STONE_IMG_WIDTH);
            SetHeight(Constants.STONE_IMG_HEIGHT);
        }

        public override void DoAction()
        {
            
        }
    }
}
