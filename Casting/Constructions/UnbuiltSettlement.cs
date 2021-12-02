using System;

namespace colony_builder.Casting
{
    public class UnbuiltSettlement : Actor
    {
        public UnbuiltSettlement(Point position, bool availableToBuild)
        {
            SetPosition(position);
            SetImage(Constants.UNBUILT_SETTLEMENT_IMG_FILEPATH);
            SetWidth(Constants.SETTLEMENT_WIDTH);
            SetHeight(Constants.SETTLEMENT_HEIGHT);

            if (availableToBuild)
            {
                SetHasActionIfPressed(Constants.AVAILABLE_TO_BUILD);
            }
        }
    }
}
