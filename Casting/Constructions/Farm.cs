using System;

namespace colony_builder.Casting
{
    public class Farm : Actor
    {
        public Farm(Point position)
        {
            // TODO
            // SetImage(Constants.);
            SetPosition(position);  
            SetWidth(Constants.FARM_WIDTH);
            SetHeight(Constants.FARM_HEIGHT);
        }
    }
}
