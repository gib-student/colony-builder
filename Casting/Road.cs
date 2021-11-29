using System;

namespace colony_builder.Casting
{
    public class Road : Actor
    {
        public Road(Point position)
        {
            SetPosition(position);
            SetWidth(Constants.ROAD_WIDTH);
            SetHeight(Constants.ROAD_HEIGHT);
        }
    }
}
