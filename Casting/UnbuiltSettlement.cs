using System;

namespace colony_builder.Casting
{
    public class UnbuiltSettlement : Actor
    {
        public UnbuiltSettlement(Point position)
        {
            SetPosition(position);
            SetImage(Constants.UNBUILT_SETTLEMENT_IMG_FILEPATH);
            SetWidth(Constants.SETTLEMENT_WIDTH);
            SetHeight(Constants.SETTLEMENT_HEIGHT);
        }
    }
}
