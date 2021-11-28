using System;

namespace colony_builder.Casting
{
    public class Settlement : Actor
    {
        public Settlement(Point position)
        {
            SetPosition(position);
            SetImage(Constants.RED_BLOCK_IMG_FILEPATH);
            SetWidth(Constants.SETTLEMENT_WIDTH);
            SetHeight(Constants.SETTLEMENT_HEIGHT);
        }
    }
}
