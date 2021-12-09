using System;
using System.Collections.Generic;
using colony_builder.Casting;

namespace colony_builder.Services
{
    public class BuildService
    {
        Resources _resources;
        Constructions _constructions;

        public BuildService(Resources resources, Constructions constructions)
        {
            _resources = resources;
            _constructions = constructions;
        }

        public bool CanBuildSettlement(int settlementNumber)
        {
            List<int> roadNums;
            switch (settlementNumber)
            {
                case (2):
                    return true;    // Always true.
                case (3):
                    roadNums = new List<int>
                    {
                        // I need to know what the map is going to look like
                        // to be able to make these lists
                    };
                    break;
                case (4):
                    roadNums = new List<int>
                    {

                    };
                    break;
                case (5):
                    roadNums = new List<int>
                    {

                    };
                    break;
                default:
                    return false;
            }
            
            bool enoughResources = SettlementEnoughResources();
            bool roadsAreBuilt = _constructions.RoadsAreBuilt(roadNums);
            return (enoughResources && roadsAreBuilt);
        }

        private bool SettlementEnoughResources()
        {
            // Check food
            int foodCount = _resources.GetResourceCount(Constants.FOOD_ACTIONBAR_TEXT);
            bool enoughFood = foodCount > Constants.SETTLEMENT_FOOD_COST;
            // Check wood
            int woodCount = _resources.GetResourceCount(Constants.WOOD_ACTIONBAR_TEXT);
            bool enoughWood = woodCount > Constants.SETTLEMENT_WOOD_COST;
            // Check stone
            int stoneCount = _resources.GetResourceCount(Constants.STONE_ACTIONBAR_TEXT);
            bool enoughStone = stoneCount > Constants.SETTLEMENT_STONE_COST;

            return (enoughFood && enoughWood && enoughStone);
        }
    }
}