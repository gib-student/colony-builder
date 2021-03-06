using System;
using System.Collections.Generic;
using colony_builder.Casting;
using colony_builder.Services;

namespace colony_builder.Scripting
{
    public class ManagePopulationAction : Action
    {
        Population _population;
        Resources _resources;
        TimeService _timeService;
        Constructions  _constructions;
        int counter = 0;

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            counter++;
            // Increase the population according to the population growth rate.
            // If the food is less than 20% of the population, then the 
            // population will not naturally increase,
            double foodCount = _resources.GetResourceCount(Constants.FOOD_ACTIONBAR_TEXT);
            int populationCount = _population.GetPopulation();
            bool canReproduce = foodCount > (0.2 * (double)populationCount);
            bool secondHasPassed = _timeService.SecondHasPassed();
            int livingSpaceAvailable = _constructions.GetLivingSpace();
            bool enoughLivingSpace = populationCount <= livingSpaceAvailable;

            if (canReproduce && secondHasPassed && enoughLivingSpace)
            {
                _population.HaveChildren();
            }
        }

        public ManagePopulationAction(Population population, Resources resources,
            TimeService timeService, Constructions constructions)
        {
            _population = population;
            _resources = resources;
            _timeService = timeService;
            _constructions = constructions;
        }
    }
}
