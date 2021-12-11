using System;

namespace colony_builder.Casting
{
    public class WoodImg : Actor
    {
        public WoodImg()
        {
            SetPosition(new Point(Constants.WOOD_IMG_X, Constants.RESOURCES_IMG_Y));
            SetImage(Constants.WOOD_IMG_FILEPATH);
            SetWidth(Constants.WOOD_IMG_WIDTH);
            SetHeight(Constants.WOOD_IMG_HEIGHT);
        }

        public override void DoAction()
        {
            
        }

        public override void Update()
        {
            
        }
    }
}
