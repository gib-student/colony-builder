using System;
using colony_builder.Services;

namespace colony_builder.Casting
{
    public class UnbuiltSettlement : Actor
    {
        Resources _resources;
        BuildService _buildService;
        int _settlementNumber;

        public UnbuiltSettlement(Point position, bool availableToBuild, 
            int settlementNumber, Resources resources, BuildService buildService)
        {
            SetPosition(position);
            SetImage(Constants.UNBUILT_SETTLEMENT_IMG_FILEPATH);
            SetWidth(Constants.SETTLEMENT_WIDTH);
            SetHeight(Constants.SETTLEMENT_HEIGHT);
            _settlementNumber = settlementNumber;
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
            bool canBuild = _buildService.CanBuildSettlement(_settlementNumber);
        }

        public override void Update()
        {
            
        }
    }
}
