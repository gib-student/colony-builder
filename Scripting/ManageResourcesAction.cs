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
        Population _population;

        double _timeElapsedTotal;
        double _previousTimeElapsed = 0;

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            _timeElapsedTotal = Raylib_cs.Raylib.GetTime();
            if (Debug.debug)
            {
                // Console.WriteLine($"ManageResourcesAction: _timeElapsedTotal: {_timeElapsedTotal}");
                // Console.WriteLine($"\t_previousTimeElapsed: {_previousTimeElapsed}");
            }
            if (SecondHasPassed())
            {
                if (Debug.debug)
                {
                    Console.WriteLine($"MangeResourcesAction: Second has passed");
                }
                List<string> resourceNames = new List<string>
                {
                    Constants.FOOD_ACTIONBAR_TEXT, Constants.WOOD_ACTIONBAR_TEXT,
                    Constants.STONE_ACTIONBAR_TEXT, Constants.GOLD_TEXT
                };
                AddResources(resourceNames);
                TakeAwayResources(resourceNames);
            }
        }
        
        public ManageResourcesAction(Resources resources, EmployedVillagers employedVillagers,
            Population population)
        {
            _resources = resources;
            _employedVillagers = employedVillagers;
            _population = population;
        }

        private bool SecondHasPassed()
        {
            double dtime = _timeElapsedTotal - _previousTimeElapsed;
            if (dtime >= 1)
            {
                _previousTimeElapsed = _timeElapsedTotal;
                return true;
            }

            return false;
        }
        
        private void AddResources(List<string> resourceNames)
        {
            foreach (string resourceName in resourceNames)
            {
                int newCount = ComputeNewResources(resourceName);
                _resources.SetResourceCount(resourceName, newCount);
            }
        }

        private void TakeAwayResources(List<string> resourceNames)
        {
            // For now the only resource which has a natural decrease is food
            // because of hunger
            int newFood = ComputeFoodAfterHunger();
            _resources.SetResourceCount(Constants.FOOD_ACTIONBAR_TEXT, newFood);
        }

        /// <summary>
        /// Compute the NEW resources which will be added to the total resources.
        /// </summary>
        /// <param name="resourceName">
        /// The name of the resource to be dealt with</param>
        private int ComputeNewResources(string resourceName)
        {   
            switch (resourceName)
            {
                case Constants.FOOD_ACTIONBAR_TEXT:
                    int employedOnFood = _employedVillagers.GetEmployedOnFood();
                    double foodProductionRate = _resources.GetFoodProductionRate(employedOnFood);
                    double foodCount = _resources.GetResourceCount(resourceName);
                    double newFoodCount = foodCount + foodCount * foodProductionRate;
                    return (int)newFoodCount;

                case Constants.WOOD_ACTIONBAR_TEXT:
                    int employedOnWood = _employedVillagers.GetEmployedOnWood();
                    double woodProductionRate = _resources.GetWoodProductionRate(employedOnWood);
                    double woodCount = _resources.GetResourceCount(resourceName);
                    double newWoodCount = woodCount + woodCount * woodProductionRate;
                    return (int)newWoodCount;

                case Constants.STONE_ACTIONBAR_TEXT:
                    int employedOnStone = _employedVillagers.GetEmployedOnStone();
                    double stoneProductionRate = _resources.GetStoneProductionRate(employedOnStone);
                    double stoneCount = _resources.GetResourceCount(resourceName);
                    double newStoneCount = stoneCount + stoneCount * stoneProductionRate;
                    return (int)newStoneCount;

                case Constants.GOLD_TEXT:
                    // For now don't change the amount of gold
                    return _resources.GetResourceCount(Constants.GOLD_TEXT);

                default:
                    return Constants.ERROR;
            }
        }

        /// <summary>
        /// Compute the new amount of food after the population eats
        /// </summary>
        private int ComputeFoodAfterHunger()
        {
            int totalPop = _population.GetPopulation();
            double hungerRate = _resources.GetHungerRate(totalPop);
            double foodCount = _resources.GetResourceCount(Constants.FOOD_ACTIONBAR_TEXT);
            double newFoodCount = foodCount + foodCount * hungerRate;
            return (int)newFoodCount;
        }
    }
}
