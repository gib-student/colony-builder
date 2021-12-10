using System;
using colony_builder.Services;

namespace colony_builder.Casting
{
    public class UnbuiltSettlement : Actor
    {
        Resources _resources;
        BuildService _buildService;
        int _settlementNum;

        public UnbuiltSettlement(Point position, bool availableToBuild, 
            int settlementNum, Resources resources, BuildService buildService)
        {
            SetPosition(position);
            SetImage(Constants.UNBUILT_SETTLEMENT_IMG_FILEPATH);
            SetWidth(Constants.SETTLEMENT_WIDTH);
            SetHeight(Constants.SETTLEMENT_HEIGHT);
            _settlementNum = settlementNum;
            _resources  = resources;
            _buildService = buildService;

            if (availableToBuild)
            {
                SetHasActionIfPressed(true);
            }
        }

        public override void DoAction()
        {
            // Check if they have enough resources to build
            bool canBuild = _buildService.CanBuildSettlement(_settlementNum);
            if (canBuild)
            {
                _buildService.BuildSettlement(_settlementNum);
                _resources.DestroyFood((double)Constants.SETTLEMENT_FOOD_COST);
                _resources.DestroyWood((double)Constants.SETTLEMENT_WOOD_COST);
                _resources.DestroyStone((double)Constants.SETTLEMENT_STONE_COST);
            }
        }

        public override void Update()
        {
            
        }

        public int GetSettlementNum()
        {
            return _settlementNum;
        }
    }
}
