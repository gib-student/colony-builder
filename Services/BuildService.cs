using System;
using System.Collections.Generic;
using colony_builder.Casting;
using colony_builder.Scripting;

namespace colony_builder.Services
{
    public class BuildService
    {
        Resources _resources;
        Constructions _constructions;
        EditCastAction _editCastAction;

        public BuildService(Resources resources, Constructions constructions,
            EditCastAction editCastAction)
        {
            _resources = resources;
            _constructions = constructions;
            _editCastAction = editCastAction;
        }

        /// Build a specific settlement.
        public void BuildSettlement(int settlementNum)
        {
            switch (settlementNum)
            {
                case Constants.SETTLEMENT_2_NUM:
                    // Create the new actors needed when settlement #2 is built
                    // Also, remove the unbuilt settlement from the cast
                    Settlement settlement2 = new Settlement(new Point(
                        Constants.SETTLEMENT_2_X, Constants.SETTLEMENT_2_Y));
                    UnbuiltFarm unbuiltFarm2 = new UnbuiltFarm(new Point(
                        Constants.FARM_2_X, Constants.FARM_2_Y));
                    UnbuiltMine unbuiltMine2 = new UnbuiltMine(new Point(
                        Constants.MINE_2_X, Constants.MINE_2_Y));
                    _editCastAction.AddActor(settlement2, 
                        Constants.SETTLEMENT_LIST_KEY);
                    _editCastAction.AddActor(unbuiltFarm2,
                        Constants.UNBUILT_FARM_LIST_KEY);
                    _editCastAction.AddActor(unbuiltMine2,
                        Constants.UNBUILT_MINE_LIST_KEY);
                    
                    _editCastAction.RemoveUnbuiltSettlement(Constants.SETTLEMENT_2_NUM);
                    break;
            }            
        }

        /// <summary>
        /// Ensure all the requirements are met in order to build a new settlement.
        /// </summary>
        /// <param name="settlementNum">The number identifying which settlement 
        /// is being checked</param>
        public bool CanBuildSettlement(int settlementNum)
        {
            List<int> roadNums;
            switch (settlementNum)
            {
                case (Constants.SETTLEMENT_2_NUM):
                    roadNums = new List<int> {
                        Constants.DEFAULT_ROAD_NUM
                    };
                    break;
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
            bool enoughResources = EnoughResourcesForSettlement();
            bool roadsAreBuilt = _constructions.RoadsAreBuilt(roadNums);
            if (Debug.debug)
            {
                Console.WriteLine($"BuildService: enoughResources: {enoughResources}, roadsAreBuilt: {roadsAreBuilt}");
            }
            return (enoughResources && roadsAreBuilt);
        }

        private bool EnoughResourcesForSettlement()
        {
            // Check food
            double foodCount = _resources.GetResourceCount(Constants.FOOD_ACTIONBAR_TEXT);
            bool enoughFood = foodCount > (double)Constants.SETTLEMENT_FOOD_COST;
            // Check wood
            double woodCount = _resources.GetResourceCount(Constants.WOOD_ACTIONBAR_TEXT);
            bool enoughWood = woodCount > (double)Constants.SETTLEMENT_WOOD_COST;
            // Check stone
            double stoneCount = _resources.GetResourceCount(Constants.STONE_ACTIONBAR_TEXT);
            bool enoughStone = stoneCount > (double)Constants.SETTLEMENT_STONE_COST;

            return (enoughFood && enoughWood && enoughStone);
        }
    }
}