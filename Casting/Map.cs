using System;

namespace colony_builder.Casting
{
    public class Map : Actor
    {
        public Map()
        {
            SetImage(Constants.MAP_IMG_FILEPATH);
            SetWidth(Constants.MAP_WIDTH);
            SetHeight(Constants.MAP_HEIGHT);
        }
    }
}
