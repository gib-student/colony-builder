using System;

namespace colony_builder.Casting
{
    public class Mine : Actor
    {
        public Mine(Point position)
        {
            SetPosition(position);
            SetWidth(Constants.MINE_WIDTH);
            SetHeight(Constants.MINE_HEIGHT);
        }
    }
}
