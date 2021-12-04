using System;

namespace colony_builder.Casting
{
    public class Road : Actor
    {
        public Road(Point position, string orientation)
        {
            SetPosition(position);
            // TODO
            // SetImage(Constants.);            
            if (orientation == Constants.ORIENTATION_VERTICAL)
            {
                SetWidth(Constants.VERTICAL_ROAD_WIDTH);
                SetHeight(Constants.VERTICAL_ROAD_HEIGHT);
            }
            else if (orientation == Constants.ORIENTATION_HORIZONTAL)
            {
                SetWidth(Constants.HORIZONTAL_ROAD_WIDTH);
                SetHeight(Constants.HORIZONTAL_ROAD_HEIGHT);
            }
        }

        public override void DoAction()
        {
            
        }

        public override void Update()
        {
            
        }
    }
}
