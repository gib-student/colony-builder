using System;

namespace colony_builder.Casting
{
    public class Mine : Actor
    {
        public Mine(Point position)
        {
            SetPosition(position);
            SetImage(Constants.MINE_IMG_FILEPATH);
            SetWidth(Constants.MINE_WIDTH);
            SetHeight(Constants.MINE_HEIGHT);
        }

        public override void DoAction()
        {
            
        }

        public override void Update()
        {
            
        }
    }
}
