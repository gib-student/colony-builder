using System;
using System.Collections.Generic;
using colony_builder.Casting;
using colony_builder.Logic;

namespace colony_builder.Scripting
{
    public class ManageResourcesAction : Action
    {
        Resources _resources;
        EmployedVillagers _employedVillagers;
        ResourceRates _resourceRates = new ResourceRates();
        double _timeElapsedTotal;
        double _previousTimeElapsed = 0;

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            _timeElapsedTotal = Raylib_cs.Raylib.GetTime();
            if (SecondHasPassed())
            {
                AddResources();
                TakeAwayResources();
            }

            _previousTimeElapsed = _timeElapsedTotal;
        }
        
        public ManageResourcesAction(Resources resources, EmployedVillagers employedVillagers)
        {
            _resources = resources;
            _employedVillagers = employedVillagers;
        }

        private bool SecondHasPassed()
        {
            double dtime = _timeElapsedTotal - _previousTimeElapsed;
            if (dtime >= 1)
            {
                return true;
            }

            return false;
        }

        private void AddResources()
        {
            List<string> resourceNames = new List<string>
            {
                Constants.FOOD_ACTIONBAR_TEXT, Constants.WOOD_ACTIONBAR_TEXT,
                Constants.STONE_ACTIONBAR_TEXT, Constants.GOLD_TEXT
            };

            foreach (string resourceName in resourceNames)
            {
                int newCount = ComputeNewResourceCount(resourceName);
                _resources.SetResourceCount(resourceName, newCount);
            }
        }

        private void TakeAwayResources()
        {
            
        }

        private int ComputeNewResourceCount(string resourceName)
        {   
            switch (resourceName)
            {
                case Constants.FOOD_ACTIONBAR_TEXT:
                    int employedOnFood = _employedVillagers.GetEmployedOnFood();
                    double foodProductionRate = _resourceRates.GetFoodProductionRate(employedOnFood);
                    double foodCount = _resources.GetResourceCount(resourceName);
                    double newFoodCount = foodCount + foodCount * foodProductionRate;
                    return (int)newFoodCount;
                case Constants.WOOD_ACTIONBAR_TEXT:
                    int employedOnWood = _employedVillagers.GetEmployedOnWood();
                    double woodProductionRate = _resourceRates.GetWoodProductionRate(employedOnWood);
                    double woodCount = _resources.GetResourceCount(resourceName);
                    double newWoodCount = woodCount + woodCount * woodProductionRate;
                    return (int)newWoodCount;
                case Constants.STONE_ACTIONBAR_TEXT:
                    int employedOnStone = _employedVillagers.GetEmployedOnStone();
                    double stoneProductionRate = _resourceRates.GetStoneProductionRate(employedOnStone);
                    double stoneCount = _resources.GetResourceCount(resourceName);
                    double newStoneCount = stoneCount + stoneCount * stoneProductionRate;
                    return (int)newStoneCount;
                default:
                    return Constants.ERROR;
            }
        }
    }
}
