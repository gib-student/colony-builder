using System;
using colony_builder.Services;

namespace colony_builder.Casting
{
    public class UnbuiltRoad : Actor
    {
        private int _roadNum;
        BuildService _buildService;

        public UnbuiltRoad(Point position, string orientation, int roadNum,
            BuildService buildService)
        {
            SetPosition(position);
            // TODO
            // SetImage(Constants.);
            if (orientation == Constants.ORIENTATION_VERTICAL)
            {
                SetWidth(Constants.VERTICAL_ROAD_WIDTH);
                SetHeight(Constants.VERTICAL_ROAD_HEIGHT);
            }
            else if (orientation == Constants.ORIENTATION_HORIZONTAL)
            {
                SetWidth(Constants.HORIZONTAL_ROAD_WIDTH);
                SetHeight(Constants.HORIZONTAL_ROAD_HEIGHT);
            }
            SetHasActionIfPressed(true);
            _roadNum = roadNum;
            _buildService = buildService;
        }

        public override void DoAction()
        {
            bool canBuild = _buildService.CanBuildRoad();
            if (canBuild)
            {
                _buildService.BuildRoad(_roadNum);
            }
        }

        public override void Update()
        {
            
        }
        
        public int GetRoadNum()
        {
            return _roadNum;
        }
    }
}
