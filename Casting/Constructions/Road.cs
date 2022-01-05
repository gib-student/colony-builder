using System;

namespace colony_builder.Casting
{
    public class Road : Actor
    {
        public Road(Point position, string orientation)
        {
            // This is a comment
            SetPosition(position);
            if (orientation == Constants.ORIENTATION_VERTICAL)
            {
                SetImage(Constants.ROAD_VERTICAL_IMG_FILEPATH);            
                SetWidth(Constants.VERTICAL_ROAD_WIDTH);
                SetHeight(Constants.VERTICAL_ROAD_HEIGHT);
            }
            else if (orientation == Constants.ORIENTATION_HORIZONTAL)
            {
                SetImage(Constants.ROAD_HORIZONTAL_IMG_FILEPATH);
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
