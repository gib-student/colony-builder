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
            if (_timeService.SecondHasPassed())
            {
                List<string> resourceNames = new List<string>
                {
                    Constants.FOOD_ACTIONBAR_TEXT, Constants.WOOD_ACTIONBAR_TEXT,
                    Constants.STONE_ACTIONBAR_TEXT, Constants.GOLD_TEXT
                };
                AddResources(resourceNames);
                ApplyHunger();
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
            foreach (string resourceName in resourceNames)
            {
                double newResources = ComputeNewResources(resourceName);
                _resources.AddResources(resourceName, newResources);
            }
        }

        private void ApplyHunger()
        {
            double foodEaten = ComputeFoodLossByHunger();
            _resources.DestroyFood(foodEaten);
        }

        /// <summary>
        /// Compute the NEW resources which will be added to the total resources.
        /// </summary>
        /// <param name="resourceName">
        /// The name of the resource to be dealt with</param>
        private double ComputeNewResources(string resourceName)
        {
            int villagersEmployed;
            double resourcesProducedPerVillager;
            double newResources;
            
            switch (resourceName)
            {
                case Constants.FOOD_ACTIONBAR_TEXT:
                    villagersEmployed = _employedVillagers.GetEmployedOnFood();
                    resourcesProducedPerVillager  = _resources.GetFoodProducedPerVillager();
                    break;

                case Constants.WOOD_ACTIONBAR_TEXT:
                    villagersEmployed = _employedVillagers.GetEmployedOnWood();
                    resourcesProducedPerVillager = _resources.GetWoodProducedPerVillager();
                    break;

                case Constants.STONE_ACTIONBAR_TEXT:
                    villagersEmployed = _employedVillagers.GetEmployedOnStone();
                    resourcesProducedPerVillager = _resources.GetStoneProducedPerVillager();
                    break;

                case Constants.GOLD_TEXT:
                    // For now don't change the amount of gold
                    return 0;

                default:
                    return Constants.ERROR;
            }

            newResources = resourcesProducedPerVillager * (double)villagersEmployed;
            return newResources;
        }

        /// <summary>
        /// Compute the new amount of food after the population eats
        /// </summary>
        private double ComputeFoodLossByHunger()
        {
            int totalPop = _population.GetPopulation();
            double foodDepletedPerVillager = _resources.GetFoodDepletedPerVillager();
            double foodDepleted = foodDepletedPerVillager * (double)totalPop;
            
            return foodDepleted;
        }
    }
}
