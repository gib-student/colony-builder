using System;
using System.Collections.Generic;
using colony_builder.Casting;
using colony_builder.Services;

namespace colony_builder.Scripting
{
    public class ManageResourcesAction : Action
    {
        Resources _resources;
        EmployedVillagers _employedVillagers;
        Population _population;
        TimeService _timeService;

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Console.WriteLine($"ManageResourcesAction: second has passsed: {_timeService.SecondHasPassed()}");
            if (_timeService.SecondHasPassed())
            {
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
            Population population, TimeService timeService)
        {
            _resources = resources;
            _employedVillagers = employedVillagers;
            _population = population;
            _timeService = timeService;
        }
        
        private void AddResources(List<string> resourceNames)
        {
            if (Debug.debug)
            {
                Console.WriteLine("ManageResourcesAction: AddResources()");
            }
            foreach (string resourceName in resourceNames)
            {
                int newCount = ComputeNewResources(resourceName);
                _resources.AddResources(resourceName, newCount);
            }
        }

        private void TakeAwayResources(List<string> resourceNames)
        {
            // For now the only resource which has a natural decrease is food
            // because of hunger
            int totalPop = _population.GetPopulation();
            int foodEaten = _resources.GetHunger(totalPop);
            _resources.TakeAwayFood(foodEaten);
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
                    return _resources.GetFoodProduced(employedOnFood);

                case Constants.WOOD_ACTIONBAR_TEXT:
                    int employedOnWood = _employedVillagers.GetEmployedOnWood();
                    return _resources.GetWoodProduced(employedOnWood);

                case Constants.STONE_ACTIONBAR_TEXT:
                    int employedOnStone = _employedVillagers.GetEmployedOnStone();
                    return _resources.GetStoneProduced(employedOnStone);

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
            int foodDepleted = _resources.GetHunger(totalPop);
            int foodCount = _resources.GetResourceCount(Constants.FOOD_ACTIONBAR_TEXT);
            int newFoodCount = foodCount - foodDepleted;
            return newFoodCount;
        }
    }
}
