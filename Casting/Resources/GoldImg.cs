using System;

namespace colony_builder.Casting
{
    public class GoldImg : Actor
    {
        public GoldImg()
        {
            SetPosition(new Point(Constants.GOLD_IMG_X, Constants.GOLD_IMG_Y));
            SetImage(Constants.GOLD_IMG_FILEPATH);
            SetWidth(Constants.GOLD_IMG_WIDTH);
            SetHeight(Constants.GOLD_IMG_HEIGHT);
        }

        public override void DoAction()
        {
            
        }

        public override void Update()
        {
            
        }
    }
}
